
using Google.Cloud.Firestore;
using Server.env;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
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

    }
}
