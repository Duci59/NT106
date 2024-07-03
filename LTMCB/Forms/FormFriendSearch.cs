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
    public partial class FormFriendSearch : Form
    {
        #region Field
        string Username;
        public class UserInfo
        {
            public string DisplayName { get; set; }
            public string UserName { get; set; }
            public bool CheckFriend { get; set; }
            public bool FriendSent { get; set; }
        }
        #endregion

        #region dragation
        Point offset = Point.Empty;
        bool isDragging = false;
        private void pannel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.PointToScreen(new Point(e.X, e.Y));
                newLocation.Offset(-offset.X, -offset.Y);
                this.Location = newLocation;
            }
        }

        private void pannel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void pannel__MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                offset = new Point(e.X, e.Y);
                isDragging = true;
            }
        }
        #endregion

        public FormFriendSearch(string us)
        {
            Username = us;
            InitializeComponent();
            this.MakeDraggable();
            this.DoubleBuffered = true;
        }

        private async void btTimBan_Click(object sender, EventArgs e)
        {
            string search = tb_search.Text.ToLower();
            string yeucau = "FriendSearch~" + search + "~" + Username;
            string ketQua = await Task.Run(() => Result.Instance.Request(yeucau));

            if (String.IsNullOrEmpty(ketQua))
            {
                MessageBox.Show("Máy chủ không phản hồi");
            }
            else
            {

                DisplaySearchResults(ketQua);
            }
        }

        private void DisplaySearchResults(string jsonResult)
        {
            FriendSearch.FlowDirection = FlowDirection.TopDown; // Display items vertically
            try
            {
                FriendSearch.Controls.Clear();
                List<UserInfo> users = Newtonsoft.Json.JsonConvert.DeserializeObject<List<UserInfo>>(jsonResult);
                if (users == null || users.Count == 0)
                {
                    Label lblNoResult = new Label();
                    lblNoResult.Text = "No matching users found.";
                    lblNoResult.AutoSize = true;
                    FriendSearch.Controls.Add(lblNoResult);
                    return;
                }
                foreach (var user in users)
                {
                    TableLayoutPanel userTable = new TableLayoutPanel();
                    userTable.AutoSize = true;
                    userTable.ColumnCount = 3;
                    userTable.RowCount = 1;
                    userTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F)); // DisplayName
                    userTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F)); // @username
                    userTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F)); // Button/Label
                    userTable.Margin = new Padding(3);
                    userTable.Padding = new Padding(0);

                    Label lblDisplayName = new Label();
                    lblDisplayName.Text = user.DisplayName;
                    lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblDisplayName.AutoSize = true;
                    lblDisplayName.Anchor = AnchorStyles.Left;

                    Label lblUserName = new Label();
                    lblUserName.Text = $"@{user.UserName}";
                    lblUserName.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblUserName.AutoSize = true;
                    lblUserName.Anchor = AnchorStyles.Left;

                    Control statusControl;
                    if (user.CheckFriend)
                    {
                        Label lblStatus = new Label();
                        lblStatus.Text = "Already Friend";
                        lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblStatus.AutoSize = true;
                        lblStatus.Anchor = AnchorStyles.Right;
                        statusControl = lblStatus;
                    }
                    else if (user.FriendSent)
                    {
                        Label lblStatus = new Label();
                        lblStatus.Text = "Friend Request Sent";
                        lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblStatus.AutoSize = true;
                        lblStatus.Anchor = AnchorStyles.Right;
                        statusControl = lblStatus;
                    }
                    else
                    {
                        Button btnSendRequest = new Button();
                        btnSendRequest.Text = "Send Friend Request";
                        btnSendRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        btnSendRequest.BackColor = Color.SteelBlue;
                        btnSendRequest.Tag = user.UserName;
                        btnSendRequest.Anchor = AnchorStyles.Right;
                        // Adjust the size of the button
                        btnSendRequest.AutoSize = true; // Automatically adjust size based on text
                        btnSendRequest.AutoSizeMode = AutoSizeMode.GrowAndShrink; // Ensure the button grows and shrinks as needed

                        // Optionally, set a minimum size if you want a consistent size regardless of text length
                        btnSendRequest.MinimumSize = new Size(150, 50); // Set the minimum width and height

                        // Alternatively, manually set the size of the button
                        btnSendRequest.Size = new Size(200, 50); // Set a specific width and height
                        btnSendRequest.Click += async (s, e) =>
                        {
                            string result = await SendFriendRequest(user.UserName);
                            if (result == "Success")
                            {
                                btnSendRequest.Enabled = false;
                                btnSendRequest.Text = "Friend Request Sent";
                            }
                            else
                            {
                                MessageBox.Show("Failed to send friend request.");
                            }
                        };
                        statusControl = btnSendRequest;
                    }

                    userTable.Controls.Add(lblDisplayName, 0, 0);
                    userTable.Controls.Add(lblUserName, 1, 0);
                    userTable.Controls.Add(statusControl, 2, 0);

                    FriendSearch.Controls.Add(userTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying search results: " + ex.Message);
            }
        }



        private async Task<string> SendFriendRequest(string toUsername)
        {
            string yeucau = $"SendFriendRequest~{Username}~{toUsername}";
            return await Task.Run(() => Result.Instance.Request(yeucau));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
