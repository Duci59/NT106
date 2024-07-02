namespace LTMCB
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelDesktop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.btnMinisize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.bt_friend = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.infobtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.quanlybutton = new Guna.UI2.WinForms.Guna2Button();
            this.mahoabutton = new Guna.UI2.WinForms.Guna2Button();
            this.chatbutton = new Guna.UI2.WinForms.Guna2Button();
            this.homebutton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.guna2Panel1.Controls.Add(this.bt_friend);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.infobtn);
            this.guna2Panel1.Controls.Add(this.guna2Button4);
            this.guna2Panel1.Controls.Add(this.quanlybutton);
            this.guna2Panel1.Controls.Add(this.mahoabutton);
            this.guna2Panel1.Controls.Add(this.chatbutton);
            this.guna2Panel1.Controls.Add(this.homebutton);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(286, 674);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.guna2Panel2.Controls.Add(this.btnCloseChildForm);
            this.guna2Panel2.Controls.Add(this.btnLogout);
            this.guna2Panel2.Controls.Add(this.btnMinisize);
            this.guna2Panel2.Controls.Add(this.btnClose);
            this.guna2Panel2.Controls.Add(this.lblTitle);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(286, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(846, 104);
            this.guna2Panel2.TabIndex = 4;
            this.guna2Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel2_MouseDown);
            this.guna2Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2Panel2_MouseMove);
            this.guna2Panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2Panel2_MouseUp);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(722, 50);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 46);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblTitle.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.lblTitle.Location = new System.Drawing.Point(310, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(225, 56);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Hello World!";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.SlateGray;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.FillColor = System.Drawing.Color.Transparent;
            this.panelDesktop.ForeColor = System.Drawing.Color.Black;
            this.panelDesktop.Location = new System.Drawing.Point(286, 104);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(846, 570);
            this.panelDesktop.TabIndex = 5;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(91, 104);
            this.btnCloseChildForm.TabIndex = 8;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // btnMinisize
            // 
            this.btnMinisize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinisize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinisize.BackgroundImage")));
            this.btnMinisize.FlatAppearance.BorderSize = 0;
            this.btnMinisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinisize.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinisize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.btnMinisize.Location = new System.Drawing.Point(754, 5);
            this.btnMinisize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.Size = new System.Drawing.Size(30, 30);
            this.btnMinisize.TabIndex = 7;
            this.btnMinisize.UseVisualStyleBackColor = true;
            this.btnMinisize.Click += new System.EventHandler(this.btnMinisize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.btnClose.Location = new System.Drawing.Point(802, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bt_friend
            // 
            this.bt_friend.Animated = true;
            this.bt_friend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_friend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_friend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_friend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_friend.FillColor = System.Drawing.Color.SteelBlue;
            this.bt_friend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bt_friend.ForeColor = System.Drawing.Color.White;
            this.bt_friend.Image = global::LTMCB.Properties.Resources.image;
            this.bt_friend.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_friend.ImageSize = new System.Drawing.Size(40, 40);
            this.bt_friend.Location = new System.Drawing.Point(0, 268);
            this.bt_friend.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bt_friend.Name = "bt_friend";
            this.bt_friend.Size = new System.Drawing.Size(286, 84);
            this.bt_friend.TabIndex = 69;
            this.bt_friend.Text = "Bạn bè";
            this.bt_friend.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_friend.Click += new System.EventHandler(this.bt_friend_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.BackgroundImage")));
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(80, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(100, 100);
            this.guna2PictureBox1.TabIndex = 68;
            this.guna2PictureBox1.TabStop = false;
            // 
            // infobtn
            // 
            this.infobtn.BackColor = System.Drawing.Color.Transparent;
            this.infobtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.infobtn.HoverState.ImageSize = new System.Drawing.Size(80, 80);
            this.infobtn.Image = ((System.Drawing.Image)(resources.GetObject("infobtn.Image")));
            this.infobtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.infobtn.ImageRotate = 0F;
            this.infobtn.ImageSize = new System.Drawing.Size(80, 80);
            this.infobtn.IndicateFocus = true;
            this.infobtn.Location = new System.Drawing.Point(99, 599);
            this.infobtn.Name = "infobtn";
            this.infobtn.PressedState.ImageSize = new System.Drawing.Size(80, 80);
            this.infobtn.Size = new System.Drawing.Size(64, 72);
            this.infobtn.TabIndex = 9;
            this.infobtn.Click += new System.EventHandler(this.infobtn_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
            this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button4.Location = new System.Drawing.Point(0, 432);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(286, 84);
            this.guna2Button4.TabIndex = 6;
            this.guna2Button4.Text = "Góp ý, báo lỗi";
            this.guna2Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // quanlybutton
            // 
            this.quanlybutton.Animated = true;
            this.quanlybutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.quanlybutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.quanlybutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.quanlybutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.quanlybutton.FillColor = System.Drawing.Color.SteelBlue;
            this.quanlybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.quanlybutton.ForeColor = System.Drawing.Color.White;
            this.quanlybutton.Image = ((System.Drawing.Image)(resources.GetObject("quanlybutton.Image")));
            this.quanlybutton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.quanlybutton.ImageSize = new System.Drawing.Size(40, 40);
            this.quanlybutton.Location = new System.Drawing.Point(0, 509);
            this.quanlybutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.quanlybutton.Name = "quanlybutton";
            this.quanlybutton.Size = new System.Drawing.Size(286, 84);
            this.quanlybutton.TabIndex = 5;
            this.quanlybutton.Text = "Quản lý";
            this.quanlybutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.quanlybutton.Visible = false;
            this.quanlybutton.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // mahoabutton
            // 
            this.mahoabutton.Animated = true;
            this.mahoabutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.mahoabutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.mahoabutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.mahoabutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.mahoabutton.FillColor = System.Drawing.Color.SteelBlue;
            this.mahoabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.mahoabutton.ForeColor = System.Drawing.Color.White;
            this.mahoabutton.Image = ((System.Drawing.Image)(resources.GetObject("mahoabutton.Image")));
            this.mahoabutton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mahoabutton.ImageSize = new System.Drawing.Size(40, 40);
            this.mahoabutton.Location = new System.Drawing.Point(0, 352);
            this.mahoabutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mahoabutton.Name = "mahoabutton";
            this.mahoabutton.Size = new System.Drawing.Size(286, 84);
            this.mahoabutton.TabIndex = 4;
            this.mahoabutton.Text = "Mã hóa file";
            this.mahoabutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mahoabutton.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // chatbutton
            // 
            this.chatbutton.Animated = true;
            this.chatbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.chatbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.chatbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.chatbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.chatbutton.FillColor = System.Drawing.Color.SteelBlue;
            this.chatbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.chatbutton.ForeColor = System.Drawing.Color.White;
            this.chatbutton.Image = ((System.Drawing.Image)(resources.GetObject("chatbutton.Image")));
            this.chatbutton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.chatbutton.ImageSize = new System.Drawing.Size(40, 40);
            this.chatbutton.Location = new System.Drawing.Point(0, 184);
            this.chatbutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.chatbutton.Name = "chatbutton";
            this.chatbutton.Size = new System.Drawing.Size(286, 84);
            this.chatbutton.TabIndex = 2;
            this.chatbutton.Text = "Chat";
            this.chatbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.chatbutton.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // homebutton
            // 
            this.homebutton.Animated = true;
            this.homebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.homebutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homebutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homebutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homebutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homebutton.FillColor = System.Drawing.Color.SteelBlue;
            this.homebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.homebutton.ForeColor = System.Drawing.Color.White;
            this.homebutton.Image = ((System.Drawing.Image)(resources.GetObject("homebutton.Image")));
            this.homebutton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homebutton.ImageSize = new System.Drawing.Size(40, 40);
            this.homebutton.Location = new System.Drawing.Point(0, 104);
            this.homebutton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(286, 84);
            this.homebutton.TabIndex = 1;
            this.homebutton.Text = "Trang chủ";
            this.homebutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homebutton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 674);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button homebutton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button chatbutton;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button quanlybutton;
        private Guna.UI2.WinForms.Guna2Button mahoabutton;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        private System.Windows.Forms.Button btnMinisize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCloseChildForm;
        private Guna.UI2.WinForms.Guna2Panel panelDesktop;
        private Guna.UI2.WinForms.Guna2ImageButton infobtn;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button bt_friend;
    }
}

