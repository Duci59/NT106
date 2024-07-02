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

    }
}
