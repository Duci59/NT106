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
            this.bt_login = new Guna.UI2.WinForms.Guna2Button();
            this.lb_welcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_pass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnMinisize = new System.Windows.Forms.Button();
            this.btnMaxsize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tb_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.hidepassbtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.showpassbtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lb_error = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // lb_forgotps
            // 
            this.lb_forgotps.AutoSize = false;
            this.lb_forgotps.BackColor = System.Drawing.Color.Transparent;
            this.lb_forgotps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_forgotps.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lb_forgotps.Location = new System.Drawing.Point(54, 551);
            this.lb_forgotps.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lb_forgotps.Name = "lb_forgotps";
            this.lb_forgotps.Size = new System.Drawing.Size(182, 29);
            this.lb_forgotps.TabIndex = 25;
            this.lb_forgotps.Text = "Forgot password?";
            // 
            // lb_register
            // 
            this.lb_register.AutoSize = false;
            this.lb_register.BackColor = System.Drawing.Color.Transparent;
            this.lb_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_register.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lb_register.Location = new System.Drawing.Point(54, 492);
            this.lb_register.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lb_register.Name = "lb_register";
            this.lb_register.Size = new System.Drawing.Size(222, 24);
            this.lb_register.TabIndex = 24;
            this.lb_register.Text = "Don\'t have an account?";
            // 
            // l_forgot
            // 
            this.l_forgot.AutoSize = true;
            this.l_forgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.l_forgot.Location = new System.Drawing.Point(283, 556);
            this.l_forgot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_forgot.Name = "l_forgot";
            this.l_forgot.Size = new System.Drawing.Size(151, 25);
            this.l_forgot.TabIndex = 23;
            this.l_forgot.TabStop = true;
            this.l_forgot.Text = "Reset password";
            this.l_forgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l_forgot_LinkClicked);
            // 
            // l_register
            // 
            this.l_register.AutoSize = true;
            this.l_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.l_register.Location = new System.Drawing.Point(283, 492);
            this.l_register.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_register.Name = "l_register";
            this.l_register.Size = new System.Drawing.Size(99, 25);
            this.l_register.TabIndex = 22;
            this.l_register.TabStop = true;
            this.l_register.Text = "Click here";
            this.l_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l_register_LinkClicked);
            // 
            // bt_login
            // 
            this.bt_login.BorderRadius = 10;
            this.bt_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.bt_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_login.ForeColor = System.Drawing.Color.White;
            this.bt_login.Location = new System.Drawing.Point(54, 395);
            this.bt_login.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(461, 55);
            this.bt_login.TabIndex = 21;
            this.bt_login.Text = "LOGIN";
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = false;
            this.lb_welcome.BackColor = System.Drawing.Color.Transparent;
            this.lb_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_welcome.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lb_welcome.Location = new System.Drawing.Point(150, 70);
            this.lb_welcome.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(306, 84);
            this.lb_welcome.TabIndex = 20;
            this.lb_welcome.Text = "Chào mừng ";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = false;
            this.lb_pass.BackColor = System.Drawing.Color.Transparent;
            this.lb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_pass.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lb_pass.Location = new System.Drawing.Point(54, 298);
            this.lb_pass.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(182, 50);
            this.lb_pass.TabIndex = 19;
            this.lb_pass.Text = "Password";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = false;
            this.lb_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_name.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lb_name.Location = new System.Drawing.Point(54, 200);
            this.lb_name.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(182, 36);
            this.lb_name.TabIndex = 18;
            this.lb_name.Text = "Username";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnMinisize
            // 
            this.btnMinisize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinisize.FlatAppearance.BorderSize = 0;
            this.btnMinisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinisize.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinisize.ForeColor = System.Drawing.Color.White;
            this.btnMinisize.Location = new System.Drawing.Point(407, 16);
            this.btnMinisize.Margin = new System.Windows.Forms.Padding(5);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.Size = new System.Drawing.Size(48, 44);
            this.btnMinisize.TabIndex = 28;
            this.btnMinisize.Text = "O";
            this.btnMinisize.UseVisualStyleBackColor = true;
            this.btnMinisize.Click += new System.EventHandler(this.btnMinisize_Click);
            // 
            // btnMaxsize
            // 
            this.btnMaxsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxsize.FlatAppearance.BorderSize = 0;
            this.btnMaxsize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxsize.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxsize.ForeColor = System.Drawing.Color.White;
            this.btnMaxsize.Location = new System.Drawing.Point(456, 16);
            this.btnMaxsize.Margin = new System.Windows.Forms.Padding(5);
            this.btnMaxsize.Name = "btnMaxsize";
            this.btnMaxsize.Size = new System.Drawing.Size(48, 44);
            this.btnMaxsize.TabIndex = 27;
            this.btnMaxsize.Text = "O";
            this.btnMaxsize.UseVisualStyleBackColor = true;
            this.btnMaxsize.Click += new System.EventHandler(this.btnMaxsize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(506, 16);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 44);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.tb_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_name.Location = new System.Drawing.Point(256, 197);
            this.tb_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_name.Name = "tb_name";
            this.tb_name.PasswordChar = '\0';
            this.tb_name.PlaceholderText = "Enter Username";
            this.tb_name.SelectedText = "";
            this.tb_name.Size = new System.Drawing.Size(248, 50);
            this.tb_name.TabIndex = 29;
            // 
            // tb_pass
            // 
            this.tb_pass.BackColor = System.Drawing.Color.Transparent;
            this.tb_pass.BorderRadius = 12;
            this.tb_pass.BorderThickness = 0;
            this.tb_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_pass.DefaultText = "";
            this.tb_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_pass.Location = new System.Drawing.Point(256, 298);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '●';
            this.tb_pass.PlaceholderText = "Enter Password";
            this.tb_pass.SelectedText = "";
            this.tb_pass.Size = new System.Drawing.Size(248, 50);
            this.tb_pass.TabIndex = 30;
            // 
            // hidepassbtn
            // 
            this.hidepassbtn.BackColor = System.Drawing.Color.White;
            this.hidepassbtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.hidepassbtn.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.hidepassbtn.Image = ((System.Drawing.Image)(resources.GetObject("hidepassbtn.Image")));
            this.hidepassbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.hidepassbtn.ImageRotate = 0F;
            this.hidepassbtn.ImageSize = new System.Drawing.Size(32, 32);
            this.hidepassbtn.Location = new System.Drawing.Point(452, 307);
            this.hidepassbtn.Margin = new System.Windows.Forms.Padding(4);
            this.hidepassbtn.Name = "hidepassbtn";
            this.hidepassbtn.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.hidepassbtn.Size = new System.Drawing.Size(38, 32);
            this.hidepassbtn.TabIndex = 34;
            this.hidepassbtn.Click += new System.EventHandler(this.hidepassbtn_Click_1);
            // 
            // showpassbtn
            // 
            this.showpassbtn.BackColor = System.Drawing.Color.White;
            this.showpassbtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.showpassbtn.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.showpassbtn.Image = ((System.Drawing.Image)(resources.GetObject("showpassbtn.Image")));
            this.showpassbtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.showpassbtn.ImageRotate = 0F;
            this.showpassbtn.ImageSize = new System.Drawing.Size(32, 32);
            this.showpassbtn.Location = new System.Drawing.Point(452, 307);
            this.showpassbtn.Margin = new System.Windows.Forms.Padding(4);
            this.showpassbtn.Name = "showpassbtn";
            this.showpassbtn.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.showpassbtn.Size = new System.Drawing.Size(38, 32);
            this.showpassbtn.TabIndex = 35;
            this.showpassbtn.Click += new System.EventHandler(this.showpassbtn_Click);
            // 
            // lb_error
            // 
            this.lb_error.BackColor = System.Drawing.Color.Transparent;
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(54, 353);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(75, 22);
            this.lb_error.TabIndex = 36;
            this.lb_error.Text = "mes_error";
            this.lb_error.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(570, 676);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.showpassbtn);
            this.Controls.Add(this.hidepassbtn);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.btnMinisize);
            this.Controls.Add(this.btnMaxsize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lb_forgotps);
            this.Controls.Add(this.lb_register);
            this.Controls.Add(this.l_forgot);
            this.Controls.Add(this.l_register);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.lb_welcome);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lb_forgotps;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_register;
        private System.Windows.Forms.LinkLabel l_forgot;
        private System.Windows.Forms.LinkLabel l_register;
        private Guna.UI2.WinForms.Guna2Button bt_login;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_welcome;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_pass;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_name;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Button btnMinisize;
        private System.Windows.Forms.Button btnMaxsize;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI2.WinForms.Guna2TextBox tb_pass;
        private Guna.UI2.WinForms.Guna2TextBox tb_name;
        private Guna.UI2.WinForms.Guna2ImageButton showpassbtn;
        private Guna.UI2.WinForms.Guna2ImageButton hidepassbtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_error;
    }
}