using Google.Cloud.Firestore;
using Server.env;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DAO
{
    public class FriendInter
    {
        private static FriendInter instance;
        public static FriendInter Instance
        {
            get { if (instance == null) instance = new FriendInter(); return instance; }
            private set { instance = value; }
        }
        private FriendInter() { }

        public async Task<List<FriendlyAssistance.UserInfo>> FriendSearch(string search, string currentUser)
        {
            var db = FireStoreHelper.db;
            CollectionReference usersRef = db.Collection("users");
            DocumentReference currentUserRef = db.Collection("friends").Document(currentUser);

            // Fetch all users
            QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();

            // Prepare a list to store the matching users
            List<FriendlyAssistance.UserInfo> matchingUsers = new List<FriendlyAssistance.UserInfo>();

            foreach (DocumentSnapshot doc in snapshot.Documents)
            {
                if (doc.Exists)
                {
                    string displayName = doc.GetValue<string>("displayName");
                    string userName = doc.GetValue<string>("username");

                    if ((search.StartsWith("@") && userName.IndexOf(search.Substring(1), StringComparison.OrdinalIgnoreCase) >= 0) ||
                        (!search.StartsWith("@") && displayName.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0))
                    {
                        matchingUsers.Add(new FriendlyAssistance.UserInfo
                        {
                            DisplayName = displayName,
                            UserName = userName
                        });
                    }
                }
            }

            // Exclude the current user
            matchingUsers = matchingUsers.Where(user => user.UserName != currentUser).ToList();

            // Get the current user's friends and friend requests
            DocumentSnapshot currentUserSnapshot = await currentUserRef.GetSnapshotAsync();
            List<string> friends = currentUserSnapshot.ContainsField("friends") ? currentUserSnapshot.GetValue<List<string>>("friends") : new List<string>();
            List<string> friendRequestsSent = currentUserSnapshot.ContainsField("friendRequestsSent") ? currentUserSnapshot.GetValue<List<string>>("friendRequestsSent") : new List<string>();

            // Update the matching users with friendship status
            foreach (var user in matchingUsers)
            {
                user.CheckFriend = currentUserSnapshot.Exists && friends.Contains(user.UserName);
                user.FriendSent = currentUserSnapshot.Exists && friendRequestsSent.Contains(user.UserName);
                Console.WriteLine($"DisplayName: {user.DisplayName}, UserName: {user.UserName}, Is Friend: {user.CheckFriend}, Friend Request Sent: {user.FriendSent}");
            }

            return matchingUsers;
        }



        public async Task<bool> SendFriendRequest(string currentUser, string userName)
        {
            var db = FireStoreHelper.db;
            DocumentReference currentUserRef = db.Collection("friends").Document(currentUser);
            DocumentReference otherUserRef = db.Collection("friends").Document(userName);

            // Ensure currentUser document exists
            await EnsureDocumentExists(currentUserRef, currentUser);

            // Ensure otherUser document exists
            await EnsureDocumentExists(otherUserRef, userName);

            await currentUserRef.UpdateAsync("friendRequestsSent", FieldValue.ArrayUnion(userName));
            await otherUserRef.UpdateAsync("friendRequestsReceived", FieldValue.ArrayUnion(currentUser));
            await LogAction(currentUser, userName, "sent friend request");
            return true;
        }

        // Huy yeu cau ket ban
        public async Task<bool> UnsendFriendRequest(string currentUser, string userName)
        {
            var db = FireStoreHelper.db;
            DocumentReference currentUserRef = db.Collection("friends").Document(currentUser);
            DocumentReference otherUserRef = db.Collection("friends").Document(userName);

            // Ensure currentUser document exists
            await EnsureDocumentExists(currentUserRef, currentUser);

            // Ensure otherUser document exists
            await EnsureDocumentExists(otherUserRef, userName);

            await currentUserRef.UpdateAsync("friendRequestsSent", FieldValue.ArrayRemove(userName));
            await otherUserRef.UpdateAsync("friendRequestsReceived", FieldValue.ArrayRemove(currentUser));
            await LogAction(currentUser, userName, "unsent friend request");
            return true;
        }

        // Huy ket ban
        public async Task<bool> UnfriendUser(string currentUser, string userName)
        {
            var db = FireStoreHelper.db;
            DocumentReference currentUserRef = db.Collection("friends").Document(currentUser);
            DocumentReference otherUserRef = db.Collection("friends").Document(userName);

            // Ensure currentUser document exists
            await EnsureDocumentExists(currentUserRef, currentUser);

            // Ensure otherUser document exists
            await EnsureDocumentExists(otherUserRef, userName);

            await currentUserRef.UpdateAsync("friends", FieldValue.ArrayRemove(userName));
            await otherUserRef.UpdateAsync("friends", FieldValue.ArrayRemove(currentUser));
            await LogAction(currentUser, userName, "unfriended");
            return true;
        }

        // Chap nhan ket ban
        public async Task<bool> AcceptFriendRequest(string currentUser, string userName)
        {
            var db = FireStoreHelper.db;
            DocumentReference currentUserRef = db.Collection("friends").Document(currentUser);
            DocumentReference otherUserRef = db.Collection("friends").Document(userName);

            // Ensure currentUser document exists
            await EnsureDocumentExists(currentUserRef, currentUser);

            // Ensure otherUser document exists
            await EnsureDocumentExists(otherUserRef, userName);

            await currentUserRef.UpdateAsync("friends", FieldValue.ArrayUnion(userName));
            await currentUserRef.UpdateAsync("friendRequestsReceived", FieldValue.ArrayRemove(userName));
            await otherUserRef.UpdateAsync("friends", FieldValue.ArrayUnion(currentUser));
            await otherUserRef.UpdateAsync("friendRequestsSent", FieldValue.ArrayRemove(currentUser));
            await LogAction(currentUser, userName, "accepted friend request");
            return true;
        }

        // Tu choi ket ban
        public async Task<bool> RejectFriendRequest(string currentUser, string userName)
        {
            var db = FireStoreHelper.db;
            DocumentReference currentUserRef = db.Collection("friends").Document(currentUser);
            DocumentReference otherUserRef = db.Collection("friends").Document(userName);

            // Ensure currentUser document exists
            await EnsureDocumentExists(currentUserRef, currentUser);

            // Ensure otherUser document exists
            await EnsureDocumentExists(otherUserRef, userName);

            await currentUserRef.UpdateAsync("friendRequestsReceived", FieldValue.ArrayRemove(userName));
            await otherUserRef.UpdateAsync("friendRequestsSent", FieldValue.ArrayRemove(currentUser));
            await LogAction(currentUser, userName, "rejected friend request");
            return true;
        }

        private async Task EnsureDocumentExists(DocumentReference docRef, string userName)
        {
            var snapshot = await docRef.GetSnapshotAsync();
            if (!snapshot.Exists)
            {
                await docRef.SetAsync(new
                {
                    username = userName,
                    friends = new List<string>(),
                    friendRequestsSent = new List<string>(),
                    friendRequestsReceived = new List<string>()
                });
            }
        }


        private async Task LogAction(string currentUser, string userName, string action)
        {
            var db = FireStoreHelper.db;
            DocumentReference otherUserRef = db.Collection("friends").Document(userName);

            Dictionary<string, object> logEntry = new Dictionary<string, object>
            {
                { "action", action },
                { "timestamp", Timestamp.GetCurrentTimestamp() },
                { "by", currentUser }
            };

            await otherUserRef.UpdateAsync("actionLogs", FieldValue.ArrayUnion(logEntry));
        }
        // Load thong tin ban be
        public async Task<string> GetFriendInfo(string username)
        {
            try
            {
                var db = FireStoreHelper.db;
                DocumentReference currentUserRef = db.Collection("friends").Document(username);
                DocumentSnapshot snapshot = await currentUserRef.GetSnapshotAsync();

                if (!snapshot.Exists)
                {
                    return "User not found in friends collection.";
                }

                Dictionary<string, object> friendData = snapshot.ToDictionary();
                List<object> friendRequestsSentObjects = friendData.ContainsKey("friends") ?
                    friendData["friends"] as List<object> ?? new List<object>() : new List<object>();

                List<string> friendRequestsSent = friendRequestsSentObjects.Select(r => r.ToString()).ToList();

                List<string> friendRequestInfoList = new List<string>();
                foreach (string requestUsername in friendRequestsSent)
                {
                    // Query the users collection to find the document with the matching username field
                    Query userQuery = db.Collection("users").WhereEqualTo("username", requestUsername);
                    QuerySnapshot userQuerySnapshot = await userQuery.GetSnapshotAsync();

                    if (userQuerySnapshot.Documents.Count > 0)
                    {
                        DocumentSnapshot userDocument = userQuerySnapshot.Documents[0];
                        string displayName = userDocument.ContainsField("displayName") ? userDocument.GetValue<string>("displayName") : "Unknown";
                        friendRequestInfoList.Add($"{displayName} ({requestUsername})");
                    }
                    else
                    {
                        friendRequestInfoList.Add($"Unknown ({requestUsername})");
                    }
                }

                return string.Join(";", friendRequestInfoList); // Return as a semicolon-separated string
            }
            catch (Exception ex)
            {
                // Log the exception (optional)
                Console.WriteLine($"An error occurred: {ex.Message}");
                return "An error occurred while fetching friend requests.";
            }
        }

        // Load thong tin yeu cau ket ban da gui
        public async Task<string> GetFriendRequestsSent(string username)
        {
            try
            {
                var db = FireStoreHelper.db;
                DocumentReference currentUserRef = db.Collection("friends").Document(username);
                DocumentSnapshot snapshot = await currentUserRef.GetSnapshotAsync();

                if (!snapshot.Exists)
                {
                    return "User not found in friends collection.";
                }

                Dictionary<string, object> friendData = snapshot.ToDictionary();
                List<object> friendRequestsSentObjects = friendData.ContainsKey("friendRequestsSent") ?
                    friendData["friendRequestsSent"] as List<object> ?? new List<object>() : new List<object>();

                List<string> friendRequestsSent = friendRequestsSentObjects.Select(r => r.ToString()).ToList();

                List<string> friendRequestInfoList = new List<string>();
                foreach (string requestUsername in friendRequestsSent)
                {
                    // Query the users collection to find the document with the matching username field
                    Query userQuery = db.Collection("users").WhereEqualTo("username", requestUsername);
                    QuerySnapshot userQuerySnapshot = await userQuery.GetSnapshotAsync();

                    if (userQuerySnapshot.Documents.Count > 0)
                    {
                        DocumentSnapshot userDocument = userQuerySnapshot.Documents[0];
                        string displayName = userDocument.ContainsField("displayName") ? userDocument.GetValue<string>("displayName") : "Unknown";
                        friendRequestInfoList.Add($"{displayName} ({requestUsername})");
                    }
                    else
                    {
                        friendRequestInfoList.Add($"Unknown ({requestUsername})");
                    }
                }

                return string.Join(";", friendRequestInfoList); // Return as a semicolon-separated string
            }
            catch (Exception ex)
            {
                // Log the exception (optional)
                Console.WriteLine($"An error occurred: {ex.Message}");
                return "An error occurred while fetching friend requests.";
            }
        }



        // Load thong tin yeu cau ket qua duoc nhan
        public async Task<string> GetFriendRequestsReceived(string username)
        {
            try
            {
                var db = FireStoreHelper.db;
                DocumentReference currentUserRef = db.Collection("friends").Document(username);
                DocumentSnapshot snapshot = await currentUserRef.GetSnapshotAsync();

                if (!snapshot.Exists)
                {
                    return "User not found in friends collection.";
                }

                Dictionary<string, object> friendData = snapshot.ToDictionary();
                List<object> friendRequestsSentObjects = friendData.ContainsKey("friendRequestsReceived") ?
                    friendData["friendRequestsReceived"] as List<object> ?? new List<object>() : new List<object>();

                List<string> friendRequestsSent = friendRequestsSentObjects.Select(r => r.ToString()).ToList();

                List<string> friendRequestInfoList = new List<string>();
                foreach (string requestUsername in friendRequestsSent)
                {
                    // Query the users collection to find the document with the matching username field
                    Query userQuery = db.Collection("users").WhereEqualTo("username", requestUsername);
                    QuerySnapshot userQuerySnapshot = await userQuery.GetSnapshotAsync();

                    if (userQuerySnapshot.Documents.Count > 0)
                    {
                        DocumentSnapshot userDocument = userQuerySnapshot.Documents[0];
                        string displayName = userDocument.ContainsField("displayName") ? userDocument.GetValue<string>("displayName") : "Unknown";
                        friendRequestInfoList.Add($"{displayName} ({requestUsername})");
                    }
                    else
                    {
                        friendRequestInfoList.Add($"Unknown ({requestUsername})");
                    }
                }

                return string.Join(";", friendRequestInfoList); // Return as a semicolon-separated string
            }
            catch (Exception ex)
            {
                // Log the exception (optional)
                Console.WriteLine($"An error occurred: {ex.Message}");
                return "An error occurred while fetching friend requests.";
            }
        }


        public async Task<string> SendToUserAsync(string senderUsername, string receiverUsername, string tinNhan)
        {
            // Tạo đối tượng Message với thông tin cần thiết
            ChatFriend message = new ChatFriend
            {
                Username = senderUsername,
                Otheruser = receiverUsername,
                TinNhan = tinNhan
            };

            // Tham chiếu đến bộ sưu tập "messages" trong Firestore
            CollectionReference messagesRef = FireStoreHelper.db.Collection("FriendMessages");

            // Lấy ID của tin nhắn cuối cùng
            QuerySnapshot lastMessageSnapshot = await messagesRef
                .OrderByDescending("id")
                .Limit(1)
                .GetSnapshotAsync();

            int lastId = 0;
            if (lastMessageSnapshot.Documents.Count > 0)
            {
                lastId = lastMessageSnapshot.Documents[0].GetValue<int>("id");
            }

            // Tăng lastId lên 1 để sử dụng cho tin nhắn mới
            lastId++;

            // Tạo dữ liệu tin nhắn dưới dạng từ điển cho người gửi
            Dictionary<string, object> senderMessageData = new Dictionary<string, object>
            {
                { "id", lastId },
                { "username", senderUsername },
                { "receiver", receiverUsername },
                { "noidung", message.TinNhan },
                { "trangthai", "Đã Gửi" },
                { "thoigian", DateTime.Now.ToString() },
                { "nguoigui", message.Username }
            };

             // Tạo dữ liệu tin nhắn dưới dạng từ điển cho người nhận
            Dictionary<string, object> receiverMessageData = new Dictionary<string, object>
            {
                { "id", lastId },
                { "username", receiverUsername },
                { "receiver", senderUsername },
                { "noidung", message.TinNhan },
                { "trangthai", "Đã Nhận" },
                { "thoigian", DateTime.Now.ToString() },
                { "nguoigui", message.Username }
            };

            // Thêm tin nhắn của người gửi vào bộ sưu tập "messages" trong Firestore
            await messagesRef.AddAsync(senderMessageData);

            // Thêm tin nhắn của người nhận vào bộ sưu tập "messages" trong Firestore
            await messagesRef.AddAsync(receiverMessageData);

            // Trả về chuỗi kết quả, bao gồm id của tin nhắn cuối cùng cách nhau bởi ký hiệu "~"
            return $"[DONE]~{lastId}";
        }

        public async Task<string> CheckMessFriend(string us, string ous, string sl)
        {
            ChatFriend cf = new ChatFriend
            {
                Username = us,
                Otheruser = ous
            };

            string traLoi = "";

            // Reference đến collection "messages" trên Firestore
            CollectionReference messagesRef = FireStoreHelper.db.Collection("FriendMessages");

            // Thực hiện truy vấn dựa trên tham số 'sl'
            QuerySnapshot querySnapshot;
            if (sl == "full")
            {
                querySnapshot = await messagesRef
                    .WhereEqualTo("receiver", cf.Otheruser)
                    .WhereIn("trangthai", new List<string> { "Đã Nhận", "Đã Bị Thu Hồi" })
                    .WhereEqualTo("username", cf.Username)
                    .GetSnapshotAsync();
            }
            else
            {
                // Các trường hợp khác của 'sl' (ví dụ: "recent") có thể được xử lý ở đây
                return "NULL";
            }

            // Kiểm tra xem querySnapshot có dữ liệu hay không
            if (querySnapshot != null)
            {
                foreach (DocumentSnapshot docSnapshot in querySnapshot.Documents)
                {
                    Dictionary<string, object> messageData = docSnapshot.ToDictionary();

                    // Gọi phương thức DisPlayName bằng cách sử dụng await
                    string tenhienthi = await DisPlayName(messageData["nguoigui"].ToString());
                    string noidung = messageData["noidung"].ToString();
                    string thoigian = messageData["thoigian"].ToString();
                    string nguoigui = messageData["nguoigui"].ToString();
                    string id_mess = docSnapshot.Id;
                    string trangthai = messageData["trangthai"].ToString();

                    // Mã hóa nội dung tin nhắn
                    MD5Helper md5 = new MD5Helper(await TakeKeyFriendAsync(cf.Otheruser));


                    // Xây dựng chuỗi kết quả
                    traLoi += $"{tenhienthi}~{noidung}~{thoigian}~{nguoigui}~{cf.Username}~{id_mess}~{trangthai}^";
                }

                // Trả về chuỗi kết quả đã xây dựng
                return traLoi.TrimEnd('^');
            }
            else
            {
                // Trả về "NULL" nếu không có tin nhắn nào thỏa mãn điều kiện
                return "NULL";
            }
        }

        public async Task<string> DisPlayName(string us)
        {
            var db = FireStoreHelper.db;

            CollectionReference accountsRef = db.Collection("users");
            QuerySnapshot accountSnapshot = await accountsRef.WhereEqualTo("username", us).GetSnapshotAsync();

            if (accountSnapshot != null && accountSnapshot.Documents.Count > 0)
            {
                DocumentSnapshot accountDoc = accountSnapshot.Documents[0];
                string displayName = accountDoc.GetValue<string>("displayName");
                return displayName;
            }
            else
            {
                return "Không xác định";
            }
        }

        public async Task<string> TakeKeyFriendAsync(string gn)
        {
            CollectionReference groupsRef = FireStoreHelper.db.Collection("groups");
            QuerySnapshot groupSnapshot = await groupsRef.WhereEqualTo("groupname", gn).GetSnapshotAsync();

            if (groupSnapshot != null && groupSnapshot.Documents.Count > 0)
            {
                DocumentSnapshot groupDoc = groupSnapshot.Documents[0];
                string username = groupDoc.GetValue<string>("owner");
                string traLoi = await TakeKeyAsync(username);
                return traLoi;
            }
            else
            {
                return "NULL";
            }
        }

        public async Task<string> TakeKeyAsync(string us)
        {
            CollectionReference accountsRef = FireStoreHelper.db.Collection("users");
            QuerySnapshot accountSnapshot = await accountsRef.WhereEqualTo("username", us).GetSnapshotAsync();

            if (accountSnapshot != null && accountSnapshot.Documents.Count > 0)
            {
                DocumentSnapshot accountDoc = accountSnapshot.Documents[0];
                string sKey = accountDoc.GetValue<string>("username");
                return sKey;
            }
            else
            {
                return "NULL";
            }
        }

        public async Task<string> NewMessFriendAsync(string us, string ous)
        {
            var db = FireStoreHelper.db;
            CollectionReference groupsRef = db.Collection("users");

            // Check if the user is still in the group
            QuerySnapshot otherUserSnapshot = await groupsRef
                .WhereEqualTo("username", ous)
                .GetSnapshotAsync();

            if (otherUserSnapshot.Documents.Count == 0)
            {
                return "UserNotFound";
            }

            // User is in the group
            CollectionReference messagesRef = db.Collection("FriendMessages");
            QuerySnapshot messageSnapshot = await messagesRef
                .WhereEqualTo("username", us)
                .WhereEqualTo("receiver", ous)
                .WhereIn("trangthai", new List<string> { "Đã Gửi", "Thu Hồi" })
                .GetSnapshotAsync();

            if (messageSnapshot != null && messageSnapshot.Documents.Count > 0)
            {
                StringBuilder traLoi = new StringBuilder();
                foreach (DocumentSnapshot doc in messageSnapshot.Documents)
                {
                    Dictionary<string, object> messageData = doc.ToDictionary();
                    string nguoigui = await DisPlayName(messageData["nguoigui"].ToString());
                    traLoi.Append($"{nguoigui}~{messageData["noidung"]}~{messageData["thoigian"]}~{messageData["nguoigui"]}~{us}~{messageData["id"]}~{messageData["trangthai"]}^");
                }

                //dsTinNhan[i].Split('~')[0] - tên hiển thị
                // [1] - nội dung
                //dsTinNhan[i].Split('~')[2] - thời gian
                //dsTinNhan[i].Split('~')[3] - user gửi
                //dsTinNhan[i].Split('~')[4] - user nhận

                // Update message statuses
                foreach (DocumentSnapshot doc in messageSnapshot.Documents)
                {
                    string trangthai = (string)doc.GetValue<string>("trangthai") == "Đã Gửi" ? "Đã Nhận" : "Đã Bị Thu Hồi";
                    await doc.Reference.UpdateAsync("trangthai", trangthai);
                }

                return traLoi.ToString().TrimEnd('^');
            }
            else
            {
                return "NULL";
            }
        }

        public async Task<string> NewMessFriend_DelAsync(string us, string ous)
        {

            var db = FireStoreHelper.db;

            // Tham chiếu đến bộ sưu tập "groups"
            CollectionReference usersRef = db.Collection("users");

            // Thực hiện truy vấn để lấy tài liệu nhóm có tên nhóm là gn
            QuerySnapshot otherUserSnapshot = await usersRef
                .WhereEqualTo("username", ous)
                .GetSnapshotAsync();

            if (otherUserSnapshot.Documents.Count == 0)
            {
                return "UserNotFound";
            }

            // Tham chiếu đến bộ sưu tập "messages"
            CollectionReference messagesRef = db.Collection("FriendMessages");
            QuerySnapshot messageSnapshot = await messagesRef
                .WhereEqualTo("username", us)
                .WhereEqualTo("receiver", ous)
                .WhereEqualTo("trangthai", "Thu Hồi")
                .GetSnapshotAsync();

            if (messageSnapshot != null && messageSnapshot.Documents.Count > 0)
            {
                StringBuilder traLoi = new StringBuilder();
                foreach (DocumentSnapshot doc in messageSnapshot.Documents)
                {
                    int messageId = doc.GetValue<int>("id");
                    traLoi.Append($"{messageId}^");
                }

                // Cập nhật trạng thái tin nhắn
                foreach (DocumentSnapshot doc in messageSnapshot.Documents)
                {
                    await doc.Reference.UpdateAsync("trangthai", "Đã Bị Thu hồi");
                }

                return traLoi.ToString().TrimEnd('^');
            }
            else
            {
                return "NULL";
            }
        }
        public async Task<string> OldMessFriendAsync(string us, string ous)
        {
            var db = FireStoreHelper.db;

            // User is in the group
            CollectionReference messagesRef = db.Collection("FriendMessages");
            QuerySnapshot messageSnapshot = await messagesRef
                .WhereEqualTo("receiver", ous)
                .WhereIn("trangthai", new List<string> { "Đã Nhận", "Thu Hồi", "Đã gửi" })
                .WhereEqualTo("username", us)
                .OrderBy("id") // Sắp xếp theo trường id
                .GetSnapshotAsync();

            if (messageSnapshot != null && messageSnapshot.Documents.Count > 0)
            {
                StringBuilder traLoi = new StringBuilder();
                foreach (DocumentSnapshot doc in messageSnapshot.Documents)
                {
                    Dictionary<string, object> messageData = doc.ToDictionary();
                    string nguoigui = await DisPlayName(messageData["nguoigui"].ToString());
                    traLoi.Append($"{nguoigui}~{messageData["noidung"]}~{messageData["thoigian"]}~{messageData["nguoigui"]}~{us}~{messageData["id"]}~{messageData["trangthai"]}^");
                }

                //dsTinNhan[i].Split('~')[0] - tên hiển thị
                // [1] - nội dung
                //dsTinNhan[i].Split('~')[2] - thời gian
                //dsTinNhan[i].Split('~')[3] - user gửi
                //dsTinNhan[i].Split('~')[4] - user nhận
                foreach (DocumentSnapshot doc in messageSnapshot.Documents)
                {
                    string trangthai = (string)doc.GetValue<string>("trangthai");
                    if (trangthai == "Đã Gửi")
                        trangthai = "Đã Nhận";
                    await doc.Reference.UpdateAsync("trangthai", trangthai);
                }

                return traLoi.ToString().TrimEnd('^');
            }
            else
            {
                return "NULL";
            }
        }
        public async Task DelFriendMessAsync(int id)
        {

            var db = FireStoreHelper.db;
            CollectionReference messagesRef = db.Collection("FriendMessages");

            // Thực hiện truy vấn để lấy tất cả tài liệu tin nhắn trong collection "messages" với id là id được cung cấp
            QuerySnapshot querySnapshot = await messagesRef
                .WhereEqualTo("id", id)  // Chuyển đổi id từ string sang int để so sánh với trường id trong Firestore
                .GetSnapshotAsync();

            // Duyệt qua tất cả các tài liệu thỏa mãn điều kiện truy vấn
            foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
            {
                // Lấy tham chiếu đến tài liệu cần cập nhật
                DocumentReference docRef = documentSnapshot.Reference;

                // Lấy dữ liệu hiện tại của tài liệu
                var data = documentSnapshot.ToDictionary();

                // Kiểm tra và in ra các giá trị của username và nguoigui để đảm bảo chúng tồn tại
                if (data.ContainsKey("username") && data.ContainsKey("nguoigui"))
                {
                    string username = data["username"].ToString();
                    string nguoigui = data["nguoigui"].ToString();

                    // Xác định trạng thái mới dựa trên người gửi
                    string newStatus = (username == nguoigui) ? "Đã Bị Thu Hồi" : "Thu Hồi";

                    // Cập nhật trạng thái tin nhắn
                    Dictionary<string, object> updates = new Dictionary<string, object>
                    {
                        { "trangthai", newStatus }
                    };

                    // Cập nhật tài liệu trong Firestore
                    await docRef.UpdateAsync(updates);
                    Console.WriteLine($"Document {docRef.Id} updated with status {newStatus}");
                }
                else
                {
                    Console.WriteLine("The document does not contain the required fields.");
                }
            }

        }

        public async Task<string> GetDisplayNameByUsernameAsync(string username)
        {
            var db = FireStoreHelper.db;
            CollectionReference usersRef = db.Collection("users");

            // Thực hiện truy vấn để lấy tài liệu của người dùng có username là username
            QuerySnapshot userSnapshot = await usersRef
                .WhereEqualTo("username", username)
                .GetSnapshotAsync();

            if (userSnapshot.Documents.Count == 0)
            {
                return null; // hoặc bạn có thể trả về một chuỗi thông báo lỗi khác
            }

            // Lấy tài liệu người dùng đầu tiên (vì username là duy nhất)
            DocumentSnapshot userDoc = userSnapshot.Documents[0];
            string displayName = userDoc.GetValue<string>("displayName");

            return displayName;
        }
    }
}
