
using Google.Cloud.Firestore;
using Server.env;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Server.DAO
{
    public class GroupInter
    {
        private static GroupInter instance;
        public static GroupInter Instance
        {
            get { if (instance == null) instance = new GroupInter(); return instance; }
            private set { instance = value; }
        }



        private GroupInter() { }
        public async Task RegisterGroupAsync(string idgroup, string groupname, string owner, string[] member, string password)
        {
            var db = FireStoreHelper.db;
            // Reference to the "users" collection
            CollectionReference groupsRef = db.Collection("groups");

            // Get all documents in the "users" collection synchronously
            QuerySnapshot groupsSnapshot = await groupsRef.GetSnapshotAsync();

            // Count the number of documents
            int documentCount = groupsSnapshot.Documents.Count;

            // Create a new document with a unique ID based on the count
            DocumentReference docRef = db.Collection("groups").Document(documentCount.ToString());
            Dictionary<string, object> data = new Dictionary<string, object>
            {
                //{ "id", idgroup },
                //{ "groupname", groupname },
                //{ "owner", email },
                //{ "password", password }, // Note: Password should be hashed before storing in Firestore
                //{ "usertype", usertype}
            };
            // Set the data to Firestore
            await docRef.SetAsync(data);
            //Console.WriteLine("User '" + username + "' registered successfully!");
        }

        public async Task<bool> FieldExistAsync(string field, string value)
        {
            var db = FireStoreHelper.db;
            CollectionReference groupsRef = db.Collection("groups");

            // Tìm tất cả các tài liệu trong collection "groups" 

            QuerySnapshot querySnapshot = await groupsRef
                .WhereEqualTo(field, value)
                .GetSnapshotAsync();

            // Trả về true nếu có ít nhất một tài liệu trong collection thỏa mãn điều kiện
            return querySnapshot.Count > 0;
        }

        public async Task RegisterGroupAsync(string groupname, string owner, string password)
        {
            var db = FireStoreHelper.db;
            CollectionReference groupsRef = db.Collection("groups");

            // Tạo một danh sách member và thêm chủ sở hữu vào đầu danh sách
            string[] member = { owner };

            // Tạo một document mới trong collection "groups" với ID tự tăng dần
            DocumentReference docRef = await groupsRef.AddAsync(new Dictionary<string, object>
    {
        { "groupname", groupname },
        { "owner", owner },
        { "password", password }
    });

            // Lấy ID của document vừa được tạo
            string idgroup = docRef.Id;

            // Để cập nhật thông tin id và member, sử dụng phương thức UpdateAsync
            await docRef.UpdateAsync(new Dictionary<string, object>
    {
        { "id", idgroup },
        { "member", member }
    });
        }

        public async Task<string> LoadGroupAsync(string username)
        {
            var db = FireStoreHelper.db;
            CollectionReference groupsRef = db.Collection("groups");


            QuerySnapshot querySnapshot = await groupsRef
                .WhereArrayContains("member", username)
                .GetSnapshotAsync();

            // Kiểm tra xem có tài liệu nào được trả về không
            if (querySnapshot != null)
            {
                StringBuilder responseBuilder = new StringBuilder();

                // Duyệt qua tất cả các tài liệu thỏa mãn điều kiện truy vấn
                foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
                {
                    Dictionary<string, object> groupData = documentSnapshot.ToDictionary();

                    // Lấy các thông tin cần thiết từ tài liệu
                    string groupName = groupData.ContainsKey("groupname") ? groupData["groupname"].ToString() : "";
                    string owner = groupData.ContainsKey("owner") ? groupData["owner"].ToString() : "";
                    string password = groupData.ContainsKey("password") ? groupData["password"].ToString() : "";

                    // Kiểm tra xem username có giống với chủ sở hữu không
                    if (username == owner)
                    {
                        // Xây dựng chuỗi kết quả chỉ khi username giống với chủ sở hữu
                        responseBuilder.Append(groupName + "~" + username);

                        responseBuilder.Append("~truongnhom~" + password);
                        responseBuilder.Append("^");
                    }
                    else
                    {
                        // Xây dựng chuỗi kết quả chỉ khi username không giống với chủ sở hữu
                        responseBuilder.Append(groupName + "~" + username);
                        responseBuilder.Append("~thanhvien");
                        responseBuilder.Append("^");
                    }
                }

                // Trả về chuỗi kết quả đã xây dựng
                return responseBuilder.ToString();
            }
            else
            {
                // Trả về [NULL] nếu không có nhóm nào
                return "[NULL]";
            }
        }

        public async Task DeleteGroupAsync(string groupName)
        {
            var db = FireStoreHelper.db;
            CollectionReference groupsRef = db.Collection("groups");


            QuerySnapshot querySnapshot = await groupsRef
                .WhereEqualTo("groupname", groupName)
                .GetSnapshotAsync();

            // Duyệt qua tất cả các tài liệu thỏa mãn điều kiện truy vấn
            foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
            {
                // Lấy tham chiếu đến tài liệu cần xóa
                DocumentReference docRef = documentSnapshot.Reference;

                // Xóa tài liệu khỏi Firestore
                await docRef.DeleteAsync();
            }
        }

        public async Task<bool> CheckGroupCredentials(string groupName, string groupPassword)
        {
            var db = FireStoreHelper.db;
            CollectionReference groupsRef = db.Collection("groups");
            QuerySnapshot snapshot = await groupsRef.WhereEqualTo("groupname", groupName).GetSnapshotAsync();

            if (snapshot.Count == 0)
            {
                Console.WriteLine("Group '" + groupName + "' does not exist.");
                return false;
            }

            foreach (DocumentSnapshot groupDoc in snapshot.Documents)
            {
                Dictionary<string, object> groupData = groupDoc.ToDictionary();

                if (groupData.ContainsKey("password") && (string)groupData["password"] == groupPassword)
                {
                    Console.WriteLine("Group credentials for '" + groupName + "' are valid.");
                    return true;
                }
            }

            Console.WriteLine("Group credentials for '" + groupName + "' are invalid.");
            return false;
        }

        public async Task<bool> AddUserToGroup(string username, string groupName)
        {
            var db = FireStoreHelper.db;
            CollectionReference groupsRef = db.Collection("groups");
            QuerySnapshot snapshot = await groupsRef.WhereEqualTo("groupname", groupName).GetSnapshotAsync();

            if (snapshot.Count == 0)
            {
                Console.WriteLine("Group '" + groupName + "' does not exist.");
                return false;
            }

            DocumentSnapshot groupDoc = snapshot.Documents.First();
            Dictionary<string, object> groupData = groupDoc.ToDictionary();

            if (groupData.ContainsKey("member"))
            {
                List<string> members = ((List<object>)groupData["member"]).Select(x => x.ToString()).ToList();

                if (!members.Contains(username))
                {
                    members.Add(username);
                    groupData["member"] = members;
                    DocumentReference groupRef = groupDoc.Reference;
                    await groupRef.UpdateAsync(groupData);
                    Console.WriteLine("User '" + username + "' added to group '" + groupName + "' successfully.");
                    return true;
                }
                else
                {
                    Console.WriteLine("User '" + username + "' is already a member of group '" + groupName + "'.");
                    return false;
                }
            }
            else
            {
                // If the member field does not exist, create it and add the user.
                List<string> members = new List<string> { username };
                groupData["member"] = members;
                DocumentReference groupRef = groupDoc.Reference;
                await groupRef.UpdateAsync(groupData);
                Console.WriteLine("User '" + username + "' added to group '" + groupName + "' successfully.");
                return true;
            }
        }
        public async Task<bool> LeaveGroupAsync(string username, string groupName)
        {
            var db = FireStoreHelper.db;
            CollectionReference groupsRef = db.Collection("groups");
            QuerySnapshot snapshot = await groupsRef.WhereEqualTo("groupname", groupName).GetSnapshotAsync();

            if (snapshot.Count == 0)
            {
                Console.WriteLine("Group '" + groupName + "' does not exist.");
                return false;
            }

            DocumentSnapshot groupDoc = snapshot.Documents.First();
            Dictionary<string, object> groupData = groupDoc.ToDictionary();

            if (groupData.ContainsKey("owner") && (string)groupData["owner"] == username)
            {
                Console.WriteLine("You are the owner of group '" + groupName + "'. You cannot leave your own group.");
                return false;
            }

            if (groupData.ContainsKey("member"))
            {
                List<string> members = ((List<object>)groupData["member"]).Select(x => x.ToString()).ToList();

                if (members.Contains(username))
                {
                    members.Remove(username);
                    groupData["member"] = members;
                    DocumentReference groupRef = groupDoc.Reference;
                    await groupRef.UpdateAsync(groupData);
                    Console.WriteLine("User '" + username + "' left group '" + groupName + "' successfully.");
                    return true;
                }
                else
                {
                    Console.WriteLine("User '" + username + "' is not a member of group '" + groupName + "'.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Group '" + groupName + "' does not have any members.");
                return false;
            }
        }

        public async Task<string> SendToGrAsync(string username, string tenNhom, string tinNhan)
        {
            // Tạo đối tượng GroupChat với thông tin cần thiết
            GroupChat gc = new GroupChat
            {
                Username = username,
                TenNhom = tenNhom,
                TinNhan = tinNhan
            };



            // Tham chiếu đến bộ sưu tập "groups" trong Firestore
            CollectionReference groupsRef = FireStoreHelper.db.Collection("groups");

            // Thực hiện truy vấn để lấy tài liệu của nhóm có tên nhóm là gc.TenNhom
            QuerySnapshot groupsSnapshot = await groupsRef
                .WhereEqualTo("groupname", gc.TenNhom)
                .GetSnapshotAsync();

            if (groupsSnapshot.Documents.Count == 0)
            {
                return "[ERROR] Group not found";
            }

            // Lấy tài liệu của nhóm đầu tiên (vì tên nhóm là duy nhất)
            DocumentSnapshot groupDoc = groupsSnapshot.Documents[0];
            List<string> members = groupDoc.GetValue<List<string>>("member");

            // Tham chiếu đến bộ sưu tập "messages" trong Firestore
            CollectionReference messagesRef = FireStoreHelper.db.Collection("messages");

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

            // Tăng lastId lên 1 để sử dụng cho tất cả các tin nhắn trong lần gửi này
            lastId++;

            foreach (string memberUsername in members)
            {
                // Xác định trạng thái tin nhắn (Đã Nhận hoặc Đã Gửi)
                string trangthai = memberUsername == gc.Username ? "Đã Nhận" : "Đã Gửi";

                // Tạo dữ liệu tin nhắn dưới dạng từ điển
                Dictionary<string, object> messageData = new Dictionary<string, object>
        {
            { "id", lastId },
            { "username", memberUsername },
            { "tennhom", gc.TenNhom },
            { "noidung", gc.TinNhan },
            { "trangthai", trangthai },
            { "thoigian", DateTime.Now.ToString() },
            { "nguoigui", gc.Username }
        };

                // Thêm tin nhắn vào bộ sưu tập "messages" trong Firestore
                await messagesRef.AddAsync(messageData);
            }

            // Trả về chuỗi kết quả, bao gồm id của tin nhắn cuối cùng cách nhau bởi ký hiệu "~"
            return $"[DONE]~{lastId}";
        }




        public async Task DelMessAsync(int id)
        {

            var db = FireStoreHelper.db;
            CollectionReference messagesRef = db.Collection("messages");

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












        public async Task<string> TakeKeyGroupAsync(string gn)
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




        public async Task<string> CheckMessGr(string us, string gn, string sl)
        {
            GroupChat gc = new GroupChat
            {
                Username = us,
                TenNhom = gn
            };

            string traLoi = "";

            // Reference đến collection "messages" trên Firestore
            CollectionReference messagesRef = FireStoreHelper.db.Collection("messages");

            // Thực hiện truy vấn dựa trên tham số 'sl'
            QuerySnapshot querySnapshot;
            if (sl == "full")
            {
                querySnapshot = await messagesRef
                    .WhereEqualTo("tennhom", gc.TenNhom)
                    .WhereIn("trangthai", new List<string> { "Đã Nhận", "Đã Bị Thu Hồi" })
                    .WhereEqualTo("username", gc.Username)
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
                    MD5Helper md5 = new MD5Helper(await TakeKeyGroupAsync(gc.TenNhom));


                    // Xây dựng chuỗi kết quả
                    traLoi += $"{tenhienthi}~{noidung}~{thoigian}~{nguoigui}~{gc.Username}~{id_mess}~{trangthai}^";
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

        public async Task<string> NewMessGrAsync(string us, string gn)
        {
            var db = FireStoreHelper.db;
            CollectionReference groupsRef = db.Collection("groups");

            // Check if the user is still in the group
            QuerySnapshot groupSnapshot = await groupsRef
                .WhereEqualTo("groupname", gn)
                .GetSnapshotAsync();

            if (groupSnapshot.Documents.Count == 0)
            {
                return "NotInGr";
            }

            DocumentSnapshot groupDoc = groupSnapshot.Documents[0];
            List<string> members = groupDoc.GetValue<List<string>>("member");

            if (!members.Contains(us))
            {
                return "NotInGr";
            }

            // User is in the group
            CollectionReference messagesRef = db.Collection("messages");
            QuerySnapshot messageSnapshot = await messagesRef
                .WhereEqualTo("tennhom", gn)
                .WhereIn("trangthai", new List<string> { "Đã Gửi", "Thu Hồi", })
                .WhereEqualTo("username", us)
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


        public async Task<string> LoadMemGrAsync(string us, string gn)
        {
            GroupChat gc = new GroupChat
            {
                Username = us
            };

            var db = FireStoreHelper.db; // Giả định rằng FireStoreHelper.db là đối tượng FirestoreDb đã được khởi tạo.

            // Tham chiếu đến bộ sưu tập "groups" trong Firestore
            CollectionReference groupsRef = db.Collection("groups");

            // Thực hiện truy vấn để lấy tài liệu nhóm có tên nhóm là gn
            QuerySnapshot groupSnapshot = await groupsRef
                .WhereEqualTo("groupname", gn)
                .GetSnapshotAsync();

            if (groupSnapshot.Documents.Count == 0)
            {
                return "NULL";
            }

            // Lấy tài liệu nhóm đầu tiên (vì tên nhóm là duy nhất)
            DocumentSnapshot groupDoc = groupSnapshot.Documents[0];
            List<string> members = groupDoc.GetValue<List<string>>("member");

            StringBuilder traloiBuilder = new StringBuilder();

            if (members.Count > 0)
            {
                foreach (string memberUsername in members)
                {
                    string displayName = await DisPlayName(memberUsername);
                    traloiBuilder.Append($"{memberUsername}~{displayName}^");
                }

                // Trả về chuỗi kết quả, loại bỏ ký tự '^' cuối cùng
                return traloiBuilder.ToString().TrimEnd('^');
            }
            else
            {
                return "NULL";
            }
        }

        public async Task<int> MemLoadingAsync(string gn)
        {
            var db = FireStoreHelper.db;
            CollectionReference groupsRef = db.Collection("groups");

            // Thực hiện truy vấn để lấy tài liệu nhóm có tên nhóm là gn
            QuerySnapshot groupSnapshot = await groupsRef
                .WhereEqualTo("groupname", gn)
                .GetSnapshotAsync();

            if (groupSnapshot.Documents.Count == 0)
            {
                // Nếu không tìm thấy nhóm, trả về 0
                return 0;
            }

            // Lấy tài liệu nhóm đầu tiên (vì tên nhóm là duy nhất)
            DocumentSnapshot groupDoc = groupSnapshot.Documents[0];
            List<string> members = groupDoc.GetValue<List<string>>("member");

            if (members.Count > 0)
            {
                // Trừ đi 1 nếu nhóm có admin
                return members.Count;
            }
            else
            {
                return 0;
            }
        }

        public async Task<string> OldMessGrAsync(string us, string gn)
        {
            var db = FireStoreHelper.db;

            // User is in the group
            CollectionReference messagesRef = db.Collection("messages");
            QuerySnapshot messageSnapshot = await messagesRef
                .WhereEqualTo("tennhom", gn)
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



        public async Task<string> NewMessGr_DelAsync(string us, string gn)
        {

            var db = FireStoreHelper.db;

            // Tham chiếu đến bộ sưu tập "groups"
            CollectionReference groupsRef = db.Collection("groups");

            // Thực hiện truy vấn để lấy tài liệu nhóm có tên nhóm là gn
            QuerySnapshot groupSnapshot = await groupsRef
                .WhereEqualTo("groupname", gn)
                .GetSnapshotAsync();

            if (groupSnapshot.Documents.Count == 0)
            {
                return "NotInGr";
            }

            // Lấy tài liệu nhóm đầu tiên (vì tên nhóm là duy nhất)
            DocumentSnapshot groupDoc = groupSnapshot.Documents[0];
            List<string> members = groupDoc.GetValue<List<string>>("member");

            // Kiểm tra nếu người dùng vẫn còn trong nhóm
            if (!members.Contains(us))
            {
                return "NotInGr";
            }

            // Tham chiếu đến bộ sưu tập "messages"
            CollectionReference messagesRef = db.Collection("messages");
            QuerySnapshot messageSnapshot = await messagesRef
                .WhereEqualTo("tennhom", gn)
                .WhereEqualTo("trangthai", "Thu Hồi")
                .WhereEqualTo("username", us)
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


        public async Task KickMemberFromGroup(string us, string gn)
        {
            var db = FireStoreHelper.db;

            // Reference the "groups" collection
            CollectionReference groupsRef = db.Collection("groups");

            // Query to retrieve the group document
            QuerySnapshot groupSnapshot = await groupsRef
                .WhereEqualTo("groupname", gn)
                .GetSnapshotAsync();

            if (groupSnapshot.Documents.Count > 0)
            {
                // Get the group document
                DocumentSnapshot groupDoc = groupSnapshot.Documents[0];
                List<string> members = groupDoc.GetValue<List<string>>("member");

                // Remove the user from the members list
                if (members.Contains(us))
                {
                    members.Remove(us);
                    await groupDoc.Reference.UpdateAsync("member", members);
                }
            }
        }

        public async Task EditPassGrAsync(string gn, string new_pass_gr)
        {
            var db = FireStoreHelper.db;

            CollectionReference groupsRef = db.Collection("groups");
            Query query = groupsRef.WhereEqualTo("groupname", gn);
            QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

            if (querySnapshot.Count > 0)
            {
                foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
                {
                    DocumentReference documentRef = documentSnapshot.Reference;
                    Dictionary<string, object> updates = new Dictionary<string, object>
            {
                { "password", new_pass_gr }
            };
                    await documentRef.UpdateAsync(updates);
                }
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

        public async Task<bool> StatusMember(string gn, string us)
        {
            var db = FireStoreHelper.db;
            CollectionReference groupsRef = db.Collection("groups");

            // Tìm nhóm theo tên
            QuerySnapshot groupSnapshot = await groupsRef.WhereEqualTo("groupname", gn).GetSnapshotAsync();

            if (groupSnapshot.Documents.Count == 0)
            {
                return false; // Nhóm không tồn tại
            }

            DocumentSnapshot groupDoc = groupSnapshot.Documents.First();

            if (groupDoc.TryGetValue("member", out List<string> members))
            {
                // Kiểm tra xem người dùng có trong danh sách thành viên không
                if (members.Contains(us))
                {
                    return true; // Người dùng là thành viên
                }
            }

            return false; // Người dùng không phải là thành viên
        }



    }


}

