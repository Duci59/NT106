namespace LTMCB.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lb_forgotps = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_register = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.l_forgot = new System.Windows.Forms.LinkLabel();
            this.l_register = new System.Windows.Forms.LinkLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_error = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tb_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt_login = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picpass1 = new System.Windows.Forms.PictureBox();
            this.picuser1 = new System.Windows.Forms.PictureBox();
            this.showpassbtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.hidepassbtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picuser1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_forgotps
            // 
            this.lb_forgotps.AutoSize = false;
            this.lb_forgotps.BackColor = System.Drawing.Color.Transparent;
            this.lb_forgotps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_forgotps.ForeColor = System.Drawing.Color.AliceBlue;
            this.lb_forgotps.Location = new System.Drawing.Point(79, 466);
            this.lb_forgotps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_forgotps.Name = "lb_forgotps";
            this.lb_forgotps.Size = new System.Drawing.Size(152, 24);
            this.lb_forgotps.TabIndex = 25;
            this.lb_forgotps.Text = "Quên mật khẩu ?\r\n";
            // 
            // lb_register
            // 
            this.lb_register.AutoSize = false;
            this.lb_register.BackColor = System.Drawing.Color.Transparent;
            this.lb_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_register.ForeColor = System.Drawing.Color.AliceBlue;
            this.lb_register.Location = new System.Drawing.Point(79, 413);
            this.lb_register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_register.Name = "lb_register";
            this.lb_register.Size = new System.Drawing.Size(185, 20);
            this.lb_register.TabIndex = 24;
            this.lb_register.Text = "Bạn chưa có tài khoản ?\r\n";
            // 
            // l_forgot
            // 
            this.l_forgot.AutoSize = true;
            this.l_forgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.l_forgot.LinkColor = System.Drawing.Color.SteelBlue;
            this.l_forgot.Location = new System.Drawing.Point(270, 466);
            this.l_forgot.Name = "l_forgot";
            this.l_forgot.Size = new System.Drawing.Size(112, 20);
            this.l_forgot.TabIndex = 23;
            this.l_forgot.TabStop = true;
            this.l_forgot.Text = "Đổi mật khẩu ";
            this.l_forgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l_forgot_LinkClicked);
            // 
            // l_register
            // 
            this.l_register.AutoSize = true;
            this.l_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.l_register.LinkColor = System.Drawing.Color.SteelBlue;
            this.l_register.Location = new System.Drawing.Point(270, 413);
            this.l_register.Name = "l_register";
            this.l_register.Size = new System.Drawing.Size(115, 20);
            this.l_register.TabIndex = 22;
            this.l_register.TabStop = true;
            this.l_register.Text = "Nhấn vào đây ";
            this.l_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l_register_LinkClicked);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(79, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 1);
            this.panel2.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(75, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 1);
            this.panel1.TabIndex = 50;
            // 
            // lb_error
            // 
            this.lb_error.BackColor = System.Drawing.Color.Transparent;
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(30, 296);
            this.lb_error.Margin = new System.Windows.Forms.Padding(2);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(64, 18);
            this.lb_error.TabIndex = 48;
            this.lb_error.Text = "mes_error";
            this.lb_error.Visible = false;
            // 
            // tb_pass
            // 
            this.tb_pass.BorderRadius = 12;
            this.tb_pass.BorderThickness = 0;
            this.tb_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_pass.DefaultText = "";
            this.tb_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_pass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tb_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_pass.Location = new System.Drawing.Point(110, 245);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '●';
            this.tb_pass.PlaceholderText = "Mật khẩu ";
            this.tb_pass.SelectedText = "";
            this.tb_pass.Size = new System.Drawing.Size(270, 33);
            this.tb_pass.TabIndex = 45;
            this.tb_pass.TabStop = false;
            this.tb_pass.Click += new System.EventHandler(this.tb_pass_Click);
            // 
            // tb_name
            // 
            this.tb_name.BorderRadius = 12;
            this.tb_name.BorderThickness = 0;
            this.tb_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_name.DefaultText = "";
            this.tb_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tb_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_name.Location = new System.Drawing.Point(110, 166);
            this.tb_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_name.Name = "tb_name";
            this.tb_name.PasswordChar = '\0';
            this.tb_name.PlaceholderText = "Tên người dùng ";
            this.tb_name.SelectedText = "";
            this.tb_name.Size = new System.Drawing.Size(277, 32);
            this.tb_name.TabIndex = 44;
            this.tb_name.TabStop = false;
            this.tb_name.Click += new System.EventHandler(this.tb_name_Click_1);
            // 
            // bt_login
            // 
            this.bt_login.BorderRadius = 10;
            this.bt_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_login.FillColor = System.Drawing.Color.SteelBlue;
            this.bt_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_login.ForeColor = System.Drawing.Color.Black;
            this.bt_login.Location = new System.Drawing.Point(75, 331);
            this.bt_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(318, 46);
            this.bt_login.TabIndex = 42;
            this.bt_login.Text = "Đăng Nhập";
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(180, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // picpass1
            // 
            this.picpass1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picpass1.BackgroundImage")));
            this.picpass1.Location = new System.Drawing.Point(75, 246);
            this.picpass1.Name = "picpass1";
            this.picpass1.Size = new System.Drawing.Size(32, 32);
            this.picpass1.TabIndex = 51;
            this.picpass1.TabStop = false;
            // 
            // picuser1
            // 
            this.picuser1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picuser1.BackgroundImage")));
            this.picuser1.Location = new System.Drawing.Point(75, 166);
            this.picuser1.Name = "picuser1";
            this.picuser1.Size = new System.Drawing.Size(32, 32);
            this.picuser1.TabIndex = 49;
            this.picuser1.TabStop = false;
            // 
            // showpassbtn
            // 
            this.showpassbtn.BackColor = System.Drawing.Color.Transparent;
            this.showpassbtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.showpassbtn.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.showpassbtn.Image = ((System.Drawing.Image)(resources.GetObject("showpassbtn.Image")));
            this.showpassbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.showpassbtn.ImageRotate = 0F;
            this.showpassbtn.ImageSize = new System.Drawing.Size(32, 32);
            this.showpassbtn.Location = new System.Drawing.Point(359, 254);
            this.showpassbtn.Name = "showpassbtn";
            this.showpassbtn.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.showpassbtn.Size = new System.Drawing.Size(32, 27);
            this.showpassbtn.TabIndex = 47;
            this.showpassbtn.Click += new System.EventHandler(this.showpassbtn_Click_1);
            // 
            // hidepassbtn
            // 
            this.hidepassbtn.BackColor = System.Drawing.Color.Transparent;
            this.hidepassbtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.hidepassbtn.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.hidepassbtn.Image = ((System.Drawing.Image)(resources.GetObject("hidepassbtn.Image")));
            this.hidepassbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.hidepassbtn.ImageRotate = 0F;
            this.hidepassbtn.ImageSize = new System.Drawing.Size(32, 32);
            this.hidepassbtn.Location = new System.Drawing.Point(359, 254);
            this.hidepassbtn.Name = "hidepassbtn";
            this.hidepassbtn.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.hidepassbtn.Size = new System.Drawing.Size(32, 27);
            this.hidepassbtn.TabIndex = 46;
            this.hidepassbtn.Click += new System.EventHandler(this.hidepassbtn_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.btnClose.Location = new System.Drawing.Point(417, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 43;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(475, 563);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picpass1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picuser1);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.showpassbtn);
            this.Controls.Add(this.hidepassbtn);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.lb_forgotps);
            this.Controls.Add(this.lb_register);
            this.Controls.Add(this.l_forgot);
            this.Controls.Add(this.l_register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picuser1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lb_forgotps;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_register;
        private System.Windows.Forms.LinkLabel l_forgot;
        private System.Windows.Forms.LinkLabel l_register;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picpass1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picuser1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_error;
        private Guna.UI2.WinForms.Guna2ImageButton showpassbtn;
        private Guna.UI2.WinForms.Guna2ImageButton hidepassbtn;
        private Guna.UI2.WinForms.Guna2TextBox tb_pass;
        private Guna.UI2.WinForms.Guna2TextBox tb_name;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI2.WinForms.Guna2Button bt_login;
    }
}