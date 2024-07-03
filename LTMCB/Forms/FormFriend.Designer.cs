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
            this.lbfriendinfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btTimBan = new Guna.UI2.WinForms.Guna2Button();
            this.Outfriend = new System.Windows.Forms.FlowLayoutPanel();
            this.Infriend = new System.Windows.Forms.FlowLayoutPanel();
            this.FriendPannel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
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
            // lbfriendinfo
            // 
            this.lbfriendinfo.BackColor = System.Drawing.Color.Transparent;
            this.lbfriendinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbfriendinfo.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.lbfriendinfo.Location = new System.Drawing.Point(302, 10);
            this.lbfriendinfo.Margin = new System.Windows.Forms.Padding(4);
            this.lbfriendinfo.Name = "lbfriendinfo";
            this.lbfriendinfo.Size = new System.Drawing.Size(244, 38);
            this.lbfriendinfo.TabIndex = 45;
            this.lbfriendinfo.Text = "Thông tin bạn bè";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.lbfriendinfo);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 76);
            this.panel1.TabIndex = 54;
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
            this.btTimBan.Location = new System.Drawing.Point(0, 498);
            this.btTimBan.Margin = new System.Windows.Forms.Padding(4);
            this.btTimBan.Name = "btTimBan";
            this.btTimBan.Size = new System.Drawing.Size(835, 59);
            this.btTimBan.TabIndex = 50;
            this.btTimBan.Text = "Tìm kiếm người dùng";
            this.btTimBan.Click += new System.EventHandler(this.btTimBan_Click);
            // 
            // Outfriend
            // 
            this.Outfriend.BackColor = System.Drawing.Color.SlateGray;
            this.Outfriend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Outfriend.Location = new System.Drawing.Point(515, 285);
            this.Outfriend.Name = "Outfriend";
            this.Outfriend.Size = new System.Drawing.Size(320, 206);
            this.Outfriend.TabIndex = 52;
            // 
            // Infriend
            // 
            this.Infriend.BackColor = System.Drawing.Color.SlateGray;
            this.Infriend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Infriend.Location = new System.Drawing.Point(515, 81);
            this.Infriend.Name = "Infriend";
            this.Infriend.Size = new System.Drawing.Size(320, 198);
            this.Infriend.TabIndex = 53;
            // 
            // FriendPannel
            // 
            this.FriendPannel.BackColor = System.Drawing.Color.SlateGray;
            this.FriendPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FriendPannel.Location = new System.Drawing.Point(0, 81);
            this.FriendPannel.Name = "FriendPannel";
            this.FriendPannel.Size = new System.Drawing.Size(509, 410);
            this.FriendPannel.TabIndex = 51;
            // 
            // FormFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(98)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(839, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btTimBan);
            this.Controls.Add(this.Outfriend);
            this.Controls.Add(this.Infriend);
            this.Controls.Add(this.FriendPannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFriend";
            this.Text = "Bạn bè";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ToolTip toolTipGroup;
        private System.Windows.Forms.Timer timerLoadGr;
        private System.Windows.Forms.Label lbfriendinfo;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btTimBan;
        private System.Windows.Forms.FlowLayoutPanel Outfriend;
        private System.Windows.Forms.FlowLayoutPanel Infriend;
        private System.Windows.Forms.FlowLayoutPanel FriendPannel;
    }
}