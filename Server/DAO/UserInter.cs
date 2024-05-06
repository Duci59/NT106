
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
    public class UserInter
    {
        private static UserInter instance;
        public static UserInter Instance
        {
            get { if (instance == null) instance = new UserInter(); return instance; }
            private set { instance = value; }
        }
        private UserInter() { }
        public async Task RegisterUserAsync(string username, string displayName, string email, string password)
        {

            var db = FireStoreHelper.db;
            // Reference to the "users" collection
            CollectionReference usersRef = db.Collection("users");

            // Get all documents in the "users" collection synchronously
            QuerySnapshot usersSnapshot = await usersRef.GetSnapshotAsync();

            // Count the number of documents
            int documentCount = usersSnapshot.Documents.Count;

            // Create a new document with a unique ID based on the count
            DocumentReference docRef = db.Collection("users").Document(documentCount.ToString());
            Dictionary<string, object> data = new Dictionary<string, object>
        {
            { "username", username },
            { "displayName", displayName },
            { "email", email },
            { "password", password } // Note: Password should be hashed before storing in Firestore
        };
            // Set the data to Firestore
            await docRef.SetAsync(data);
            Console.WriteLine("User '" + username + "' registered successfully!");

        }
        public async Task<bool> userexist(string username, string email)
        {
            var db = FireStoreHelper.db;
            CollectionReference usersRef = db.Collection("users");
            QuerySnapshot querySnapshot = await usersRef
            // Query to check if a document exists with the provided username or email
            .WhereEqualTo("username", username)
            .GetSnapshotAsync();

            // Check if any document matches the query for username
            if (querySnapshot.Count > 0)
                return true;

            // If no match is found for username, check for email
            querySnapshot = await usersRef
                .WhereEqualTo("email", email)
                .GetSnapshotAsync();

            // Check if any document matches the query for email
            return querySnapshot.Count > 0;
        }

        public async Task<int> login(string username, string password)
        {
            var db = FireStoreHelper.db;
            CollectionReference usersRef = db.Collection("users");
            QuerySnapshot snapshot = await usersRef.WhereEqualTo("username", username).GetSnapshotAsync();
            if (snapshot.Count == 0)
                return 0;
            foreach (DocumentSnapshot userDoc in snapshot.Documents)
            {
                // Get user data
                Dictionary<string, object> userData = userDoc.ToDictionary();

                // Check if the password matches
                if (userData.ContainsKey("password") && (string)userData["password"] == password)
                {
                    // Password matches, user is authenticated
                    Console.WriteLine("User '" + username + "' login successfully!");
                    return 1;
                }
            }
            return -1;
        }
        public async Task<bool> ForgotPasswordAsync(string email)
        {
            var db = FireStoreHelper.db;
            CollectionReference usersRef = db.Collection("users");

            // Query to find the user with the specified email
            QuerySnapshot querySnapshot = await usersRef
                .WhereEqualTo("email", email)
                .GetSnapshotAsync();

            // Check if any document matches the query for email
            if (querySnapshot.Count > 0)
            {
                // Assuming there's exactly one user per unique email
                DocumentSnapshot userDoc = querySnapshot.Documents.First();

                // Generate a password reset token (this can be a secure random token)
                string resetToken = GenerateResetToken();

                // Store the reset token in the user document (you may want to encrypt or hash it)
                Dictionary<string, object> data = new Dictionary<string, object>
        {
            { "resetToken", resetToken }
        };
                await userDoc.Reference.SetAsync(data, SetOptions.MergeAll);

                // Send an email to the user with a link to reset password
                bool emailSent = await SendResetPasswordEmail(email, resetToken);
                return emailSent;
            }

            // If no match is found for the email, return false
            return false;
        }

        private string GenerateResetToken()
        {
            // This method should generate a secure random token for password reset
            // For example, you can use Guid.NewGuid() to create a unique token
            return Guid.NewGuid().ToString();
        }

        private async Task<bool> SendResetPasswordEmail(string email, string resetToken)
        {
            // Implement your email sending logic here (using SMTP, third-party service, etc.)
            // This is a simplified example assuming you have a service to send emails
            try
            {
                // Placeholder for email sending logic (replace with your implementation)
                Console.WriteLine($"Password reset email sent to {email} with token: {resetToken}");
                return true; // Email sent successfully
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to send password reset email: {ex.Message}");
                return false; // Failed to send email
            }
        }

    }
}
