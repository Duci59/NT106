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
            this.SuspendLayout();
            // 
            // lb_forgotps
            // 
            this.lb_forgotps.AutoSize = false;
            this.lb_forgotps.BackColor = System.Drawing.Color.Transparent;
            this.lb_forgotps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_forgotps.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lb_forgotps.Location = new System.Drawing.Point(45, 459);
            this.lb_forgotps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_forgotps.Name = "lb_forgotps";
            this.lb_forgotps.Size = new System.Drawing.Size(116, 20);
            this.lb_forgotps.TabIndex = 25;
            this.lb_forgotps.Text = "Forgot password?";
            // 
            // lb_register
            // 
            this.lb_register.AutoSize = false;
            this.lb_register.BackColor = System.Drawing.Color.Transparent;
            this.lb_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_register.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lb_register.Location = new System.Drawing.Point(45, 410);
            this.lb_register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_register.Name = "lb_register";
            this.lb_register.Size = new System.Drawing.Size(152, 21);
            this.lb_register.TabIndex = 24;
            this.lb_register.Text = "Don\'t have an account?";
            // 
            // l_forgot
            // 
            this.l_forgot.AutoSize = true;
            this.l_forgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.l_forgot.Location = new System.Drawing.Point(210, 463);
            this.l_forgot.Name = "l_forgot";
            this.l_forgot.Size = new System.Drawing.Size(130, 20);
            this.l_forgot.TabIndex = 23;
            this.l_forgot.TabStop = true;
            this.l_forgot.Text = "Reset password";
            this.l_forgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.l_forgot_LinkClicked);
            // 
            // l_register
            // 
            this.l_register.AutoSize = true;
            this.l_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.l_register.Location = new System.Drawing.Point(210, 410);
            this.l_register.Name = "l_register";
            this.l_register.Size = new System.Drawing.Size(84, 20);
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
            this.bt_login.Location = new System.Drawing.Point(45, 329);
            this.bt_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(384, 46);
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
            this.lb_welcome.Location = new System.Drawing.Point(125, 58);
            this.lb_welcome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(255, 70);
            this.lb_welcome.TabIndex = 20;
            this.lb_welcome.Text = "Chào mừng ";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = false;
            this.lb_pass.BackColor = System.Drawing.Color.Transparent;
            this.lb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_pass.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lb_pass.Location = new System.Drawing.Point(45, 248);
            this.lb_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(152, 42);
            this.lb_pass.TabIndex = 19;
            this.lb_pass.Text = "Password";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = false;
            this.lb_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_name.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lb_name.Location = new System.Drawing.Point(45, 167);
            this.lb_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(152, 30);
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
            this.btnMinisize.Location = new System.Drawing.Point(339, 13);
            this.btnMinisize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.Size = new System.Drawing.Size(40, 37);
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
            this.btnMaxsize.Location = new System.Drawing.Point(380, 13);
            this.btnMaxsize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaxsize.Name = "btnMaxsize";
            this.btnMaxsize.Size = new System.Drawing.Size(40, 37);
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
            this.btnClose.Location = new System.Drawing.Point(422, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 37);
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
            this.tb_name.Location = new System.Drawing.Point(213, 164);
            this.tb_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_name.Name = "tb_name";
            this.tb_name.PasswordChar = '\0';
            this.tb_name.PlaceholderText = "Enter Username";
            this.tb_name.SelectedText = "";
            this.tb_name.Size = new System.Drawing.Size(207, 42);
            this.tb_name.TabIndex = 29;
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
            this.tb_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_pass.Location = new System.Drawing.Point(213, 248);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '\0';
            this.tb_pass.PlaceholderText = "Enter Password";
            this.tb_pass.SelectedText = "";
            this.tb_pass.Size = new System.Drawing.Size(207, 42);
            this.tb_pass.TabIndex = 30;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(475, 563);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
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
    }
}