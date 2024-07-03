namespace LTMCB.Forms
{
    partial class FormFriend
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.toolTipGroup = new System.Windows.Forms.ToolTip(this.components);
            this.timerLoadGr = new System.Windows.Forms.Timer(this.components);
            this.btTimBan = new Guna.UI2.WinForms.Guna2Button();
            this.Outfriend = new System.Windows.Forms.FlowLayoutPanel();
            this.Infriend = new System.Windows.Forms.FlowLayoutPanel();
            this.FriendPannel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            // 
            // toolTipGroup
            // 
            this.toolTipGroup.IsBalloon = true;
            this.toolTipGroup.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipGroup.ToolTipTitle = "Gợi ý";
            // 
            // btTimBan
            // 
            this.btTimBan.BorderThickness = 1;
            this.btTimBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btTimBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btTimBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btTimBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btTimBan.FillColor = System.Drawing.Color.SteelBlue;
            this.btTimBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btTimBan.ForeColor = System.Drawing.Color.Black;
            this.btTimBan.Location = new System.Drawing.Point(0, 456);
            this.btTimBan.Name = "btTimBan";
            this.btTimBan.Size = new System.Drawing.Size(846, 49);
            this.btTimBan.TabIndex = 50;
            this.btTimBan.Text = "Tìm kiếm người dùng";
            this.btTimBan.Click += new System.EventHandler(this.btTimBan_Click);
            // 
            // Outfriend
            // 
            this.Outfriend.BackColor = System.Drawing.Color.SlateGray;
            this.Outfriend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Outfriend.Location = new System.Drawing.Point(501, 232);
            this.Outfriend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Outfriend.Name = "Outfriend";
            this.Outfriend.Size = new System.Drawing.Size(345, 202);
            this.Outfriend.TabIndex = 52;
            // 
            // Infriend
            // 
            this.Infriend.BackColor = System.Drawing.Color.SlateGray;
            this.Infriend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Infriend.Location = new System.Drawing.Point(501, 22);
            this.Infriend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Infriend.Name = "Infriend";
            this.Infriend.Size = new System.Drawing.Size(345, 206);
            this.Infriend.TabIndex = 53;
            // 
            // FriendPannel
            // 
            this.FriendPannel.BackColor = System.Drawing.Color.SlateGray;
            this.FriendPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FriendPannel.Location = new System.Drawing.Point(0, 22);
            this.FriendPannel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FriendPannel.Name = "FriendPannel";
            this.FriendPannel.Size = new System.Drawing.Size(495, 412);
            this.FriendPannel.TabIndex = 51;
            // 
            // FormFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(846, 557);
            this.Controls.Add(this.btTimBan);
            this.Controls.Add(this.Outfriend);
            this.Controls.Add(this.Infriend);
            this.Controls.Add(this.FriendPannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFriend";
            this.Text = "Thông tin bạn bè";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ToolTip toolTipGroup;
        private System.Windows.Forms.Timer timerLoadGr;
        private Guna.UI2.WinForms.Guna2Button btTimBan;
        private System.Windows.Forms.FlowLayoutPanel Outfriend;
        private System.Windows.Forms.FlowLayoutPanel Infriend;
        private System.Windows.Forms.FlowLayoutPanel FriendPannel;
    }
}