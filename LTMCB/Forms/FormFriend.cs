using Guna.UI2.WinForms;
using LTMCB.env;
using LTMCB.MaHoa;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTMCB.Forms
{
    public partial class FormFriend : Form
    {
        #region Field
        private string Username;
        #endregion

        public FormFriend(string us)
        {
            Username = us;
            InitializeComponent();
            this.DoubleBuffered = true;
            LoadFunction();
        }

        private void LoadFunction()
        {
            LoadFriend(Username);
            LoadInRequest(Username);
            LoadSendRequest(Username);
        }
        private async void LoadFriend(string us)
        {
            FriendPannel.Controls.Clear();
            string yeucau = "LoadFriend~" + us;
            string ketqua = await Task.Run(() => Result.Instance.Request(yeucau));

            if (!string.IsNullOrEmpty(ketqua) && !ketqua.Equals("User not found in friends collection."))
            {
                // Split the result into individual friends
                string[] friends = ketqua.Split(';');

                // Create UI elements for each friend
                foreach (string friend in friends)
                {
                    // Assume friend format is "DisplayName (Username)"
                    string[] parts = friend.Split('(', ')');
                    if (parts.Length >= 2)
                    {
                        string displayName = parts[0].Trim();
                        string username = parts[1].Trim();

                        // Create a label for the friend
                        Label lblFriend = new Label();
                        lblFriend.Text = $"{displayName} ({username})";
                        lblFriend.AutoSize = true;
                        lblFriend.Margin = new Padding(3);
                        lblFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblFriend.ForeColor = Color.Black;
                        toolTipGroup.SetToolTip(lblFriend, "Nhấn chuột phải để xem thông tin");

                        // Create a button to open chat
                        Button btnChat = new Button();
                        btnChat.Text = "Chat";
                        btnChat.ForeColor = Color.White;
                        btnChat.Tag = username; // Store the username in the button's Tag property
                        btnChat.AutoSize = true;
                        btnChat.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                        btnChat.Size = new Size(50, 50);
                        btnChat.Click += (s, e) => OpenChatForm(username);

                        // Create a button to unfriend
                        Button btnUnfriend = new Button();
                        btnUnfriend.Text = "Unfriend";
                        btnUnfriend.ForeColor = Color.White;
                        btnUnfriend.Tag = username; // Store the username in the button's Tag property
                        btnUnfriend.AutoSize = true;
                        btnUnfriend.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                        btnUnfriend.Size = new Size(50, 50);
                        btnUnfriend.Click += (s, e) => ConfirmUnfriend(username);

                        ContextMenuStrip cms = new ContextMenuStrip();
                        cms.Items.Add("Xem thông tin");
                        cms.Items[0].Click += (s, e) =>
                        {
                            FormInfo a = new FormInfo(username, 0);
                            a.Show();
                        };

                        // Add the controls to a panel or other container
                        FlowLayoutPanel panel = new FlowLayoutPanel();
                        panel.AutoSize = true;
                        panel.Controls.Add(lblFriend);
                        panel.Controls.Add(btnChat);
                        panel.Controls.Add(btnUnfriend);
                        panel.ContextMenuStrip = cms;

                        // Add the panel to the form
                        FriendPannel.Controls.Add(panel);
                    }
                }
            }
            else
            {
                Label lblNoFriends = new Label();
                lblNoFriends.Text = "No friends";
                lblNoFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblNoFriends.AutoSize = true;
                lblNoFriends.ForeColor = Color.Black;
                FriendPannel.Controls.Add(lblNoFriends);
            }
        }
        private async void LoadInRequest(string us)
        {
            Infriend.Controls.Clear();
            string yeucau = "LoadInRequest~" + us;
            string ketqua = await Task.Run(() => Result.Instance.Request(yeucau));

            if (!string.IsNullOrEmpty(ketqua) && !ketqua.Equals("User not found in friends collection."))
            {
                // Split the result into individual friend requests
                string[] requests = ketqua.Split(';');

                // Create UI elements for each friend request
                foreach (string request in requests)
                {
                    // Assume request format is "DisplayName (Username)"
                    string[] parts = request.Split('(', ')');
                    if (parts.Length >= 2)
                    {
                        string displayName = parts[0].Trim();
                        string username = parts[1].Trim();

                        // Create a label for the friend request
                        Label lblRequest = new Label();
                        lblRequest.Text = $"{displayName} ({username})";
                        lblRequest.AutoSize = true;
                        lblRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblRequest.Margin = new Padding(3);
                        lblRequest.ForeColor = Color.Black;
                        toolTipGroup.SetToolTip(lblRequest, "Nhấn chuột phải để xem thông tin");

                        // Create a button to accept the friend request
                        Button btnAccept = new Button();
                        btnAccept.Text = "Accept";
                        btnAccept.Tag = username; // Store the username in the button's Tag property
                        btnAccept.AutoSize = true;
                        btnAccept.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                        btnAccept.Size = new Size(50, 50);
                        btnAccept.Click += (s, e) => AcceptFriendRequest(username);
                        btnAccept.ForeColor = Color.White;

                        // Create a button to deny the friend request
                        Button btnDeny = new Button();
                        btnDeny.Text = "Deny";
                        btnDeny.Tag = username; // Store the username in the button's Tag property
                        btnDeny.AutoSize = true;
                        btnDeny.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                        btnDeny.Size = new Size(50, 50);
                        btnDeny.Click += (s, e) => DenyFriendRequest(username);
                        btnDeny.ForeColor = Color.White;

                        ContextMenuStrip cms = new ContextMenuStrip();
                        cms.Items.Add("Xem thông tin");
                        cms.Items[0].Click += (s, e) =>
                        {
                            FormInfo a = new FormInfo(username, 0);
                            a.Show();
                        };

                        // Add the controls to a panel or other container
                        FlowLayoutPanel panel = new FlowLayoutPanel();
                        panel.AutoSize = true;
                        panel.Controls.Add(lblRequest);
                        panel.Controls.Add(btnAccept);
                        panel.Controls.Add(btnDeny);
                        panel.ContextMenuStrip = cms;

                        // Add the panel to the form
                        Infriend.Controls.Add(panel);
                    }
                }
            }
            else
            {
                Label lblNoRequests = new Label();
                lblNoRequests.Text = "No friend requests";
                lblNoRequests.AutoSize = true;
                lblNoRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblNoRequests.ForeColor = Color.Black;
                Infriend.Controls.Add(lblNoRequests);
            }
        }
        private async void LoadSendRequest(string us)
        {
            Outfriend.Controls.Clear();
            string yeucau = "LoadSendRequest~" + us;
            string ketqua = await Task.Run(() => Result.Instance.Request(yeucau));

           
            if (!string.IsNullOrEmpty(ketqua) && !ketqua.Equals("User not found in friends collection."))
            {
                // Split the result into individual friend requests
                string[] requests = ketqua.Split(';');

                // Create UI elements for each friend request
                foreach (string request in requests)
                {
                    // Assume request format is "DisplayName (Username)"
                    string[] parts = request.Split('(', ')');
                    if (parts.Length >= 2)
                    {
                        string displayName = parts[0].Trim();
                        string username = parts[1].Trim();

                        // Create a label for the friend request
                        Label lblRequest = new Label();
                        lblRequest.Text = $"{displayName} ({username})";
                        lblRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblRequest.AutoSize = true;
                        lblRequest.Margin = new Padding(3);
                        lblRequest.ForeColor = Color.Black;
                        toolTipGroup.SetToolTip(lblRequest, "Nhấn chuột phải để xem thông tin");

                        // Create a button to unsend the friend request
                        Button btnUnsend = new Button();
                        btnUnsend.Text = "Unsend";
                        btnUnsend.Tag = username; // Store the username in the button's Tag property
                        btnUnsend.AutoSize = true;
                        btnUnsend.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                        btnUnsend.Size = new Size(50, 50);
                        btnUnsend.Click += (s, e) => ConfirmUnsendRequest(username);
                        btnUnsend.ForeColor = Color.White;

                        ContextMenuStrip cms = new ContextMenuStrip();
                        cms.Items.Add("Xem thông tin");
                        cms.Items[0].Click += (s, e) =>
                        {
                            FormInfo a = new FormInfo(username, 0);
                            a.Show();
                        };

                        // Add the controls to a panel or other container
                        FlowLayoutPanel panel = new FlowLayoutPanel();
                        panel.AutoSize = true;
                        panel.Controls.Add(lblRequest);
                        panel.Controls.Add(btnUnsend);
                        panel.ContextMenuStrip = cms;

                        // Add the panel to the form
                        Outfriend.Controls.Add(panel);
                    }
                }
            }
            else
            {
                Label lblNoSentRequests = new Label();
                lblNoSentRequests.Text = "No sent friend requests";
                lblNoSentRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblNoSentRequests.AutoSize = true;
                lblNoSentRequests.ForeColor = Color.Black;
                Outfriend.Controls.Add(lblNoSentRequests);
            }
        }

        private void OpenChatForm(string username)
        {
            // Implement the logic to open a chat form with the given username
            MessageBox.Show($"Open chat with {username}");
        }

        // Method to confirm and unfriend
        private async void ConfirmUnfriend(string username)
        {
            var confirmResult = MessageBox.Show($"Are you sure you want to unfriend {username}?", "Confirm Unfriend", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string yeucau = $"UnFriendRequest~{Username}~{username}";
                string ketqua = await Task.Run(() => Result.Instance.Request(yeucau));
                if (ketqua == "Success")
                {
                    MessageBox.Show($"Unfriended {username}");
                    LoadFriend(Username);
                }
                else
                {
                    MessageBox.Show("Failed unfriend request");
                }
            }
        }

        private async void AcceptFriendRequest(string username)
        {
            // Implement the logic to accept the friend request
            string yeucau = $"AcceptFriendRequest~{Username}~{username}";
            string ketqua = await Task.Run(() => Result.Instance.Request(yeucau));

            if (ketqua == "Success")
            {
                MessageBox.Show($"Accepted friend request from {username}");
                // Optionally refresh the friend request list
                LoadInRequest(Username);
                LoadFriend(Username);
            }
            else
            {
                MessageBox.Show("Failed to accept friend request");
            }
        }

        private async void DenyFriendRequest(string username)
        {
            // Implement the logic to deny the friend request
            string yeucau = $"DenyFriendRequest~{Username}~{username}";
            string ketqua = await Task.Run(() => Result.Instance.Request(yeucau));

            if (ketqua == "Success")
            {
                MessageBox.Show($"Denied friend request from {username}");
                // Optionally refresh the friend request list
                LoadInRequest(Username);
            }
            else
            {
                MessageBox.Show("Failed to deny friend request");
            }
        }

        // Method to confirm and unsend friend request
        private void ConfirmUnsendRequest(string username)
        {
            var confirmResult = MessageBox.Show($"Are you sure you want to unsend the friend request to {username}?", "Confirm Unsend", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                UnsendFriendRequest(username);
            }
        }

        // Method to unsend friend request
        private async void UnsendFriendRequest(string username)
        {
            // Implement the logic to unsend the friend request
            string yeucau = $"UnsendFriendRequest~{Username}~{username}";
            string ketqua = await Task.Run(() => Result.Instance.Request(yeucau));

            if (ketqua == "Success")
            {
                MessageBox.Show($"Unsent friend request to {username}");
                // Optionally refresh the friend request sent list
                LoadSendRequest(Username);
            }
            else
            {
                MessageBox.Show("Failed to unsend friend request");
            }
        }
        private void btTimBan_Click(object sender, EventArgs e)
        {
            Forms.FormFriendSearch searchform = new Forms.FormFriendSearch(Username);
            searchform.Show();
        }

        private void Infriend_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Outfriend_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
