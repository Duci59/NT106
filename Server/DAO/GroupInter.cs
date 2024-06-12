
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
            if (querySnapshot != null )
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


    }
}
