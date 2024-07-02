namespace LTMCB.Forms
{
    partial class FormXacNhanDK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXacNhanDK));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.btConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.btSendAgain = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.timeCountdownCode = new System.Windows.Forms.Timer(this.components);
            this.lbDemNguoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbTimeLate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_error = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(174, 205);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(208, 31);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Nhập mã xác thực";
            // 
            // tbCode
            // 
            this.tbCode.BorderRadius = 12;
            this.tbCode.BorderThickness = 0;
            this.tbCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCode.DefaultText = "";
            this.tbCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCode.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.tbCode.ForeColor = System.Drawing.SystemColors.Info;
            this.tbCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCode.Location = new System.Drawing.Point(206, 252);
            this.tbCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCode.Name = "tbCode";
            this.tbCode.PasswordChar = '\0';
            this.tbCode.PlaceholderText = "";
            this.tbCode.SelectedText = "";
            this.tbCode.Size = new System.Drawing.Size(154, 50);
            this.tbCode.TabIndex = 30;
            // 
            // btConfirm
            // 
            this.btConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btConfirm.BorderRadius = 8;
            this.btConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btConfirm.FillColor = System.Drawing.Color.SteelBlue;
            this.btConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btConfirm.ForeColor = System.Drawing.Color.Black;
            this.btConfirm.Location = new System.Drawing.Point(137, 355);
            this.btConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(108, 43);
            this.btConfirm.TabIndex = 31;
            this.btConfirm.Text = "Xác nhận";
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // btSendAgain
            // 
            this.btSendAgain.BackColor = System.Drawing.Color.Transparent;
            this.btSendAgain.BorderRadius = 8;
            this.btSendAgain.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSendAgain.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSendAgain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSendAgain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSendAgain.FillColor = System.Drawing.Color.SteelBlue;
            this.btSendAgain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btSendAgain.ForeColor = System.Drawing.Color.Black;
            this.btSendAgain.Location = new System.Drawing.Point(319, 355);
            this.btSendAgain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSendAgain.Name = "btSendAgain";
            this.btSendAgain.Size = new System.Drawing.Size(108, 43);
            this.btSendAgain.TabIndex = 32;
            this.btSendAgain.Text = "Gửi lại";
            this.btSendAgain.Click += new System.EventHandler(this.btSendAgain_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.btnClose.Location = new System.Drawing.Point(505, 16);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.TabIndex = 33;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timeCountdownCode
            // 
            this.timeCountdownCode.Interval = 1000;
            this.timeCountdownCode.Tick += new System.EventHandler(this.timeCountdownCode_Tick);
            // 
            // lbDemNguoc
            // 
            this.lbDemNguoc.BackColor = System.Drawing.Color.Transparent;
            this.lbDemNguoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDemNguoc.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbDemNguoc.Location = new System.Drawing.Point(137, 468);
            this.lbDemNguoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbDemNguoc.Name = "lbDemNguoc";
            this.lbDemNguoc.Size = new System.Drawing.Size(153, 27);
            this.lbDemNguoc.TabIndex = 34;
            this.lbDemNguoc.Text = "Label đếm ngược";
            // 
            // lbTimeLate
            // 
            this.lbTimeLate.BackColor = System.Drawing.Color.Transparent;
            this.lbTimeLate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeLate.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbTimeLate.Location = new System.Drawing.Point(295, 419);
            this.lbTimeLate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbTimeLate.Name = "lbTimeLate";
            this.lbTimeLate.Size = new System.Drawing.Size(153, 27);
            this.lbTimeLate.TabIndex = 35;
            this.lbTimeLate.Text = "Label đếm ngược";
            // 
            // lb_error
            // 
            this.lb_error.BackColor = System.Drawing.Color.Transparent;
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(137, 318);
            this.lb_error.Margin = new System.Windows.Forms.Padding(2);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(36, 22);
            this.lb_error.TabIndex = 36;
            this.lb_error.Text = "error";
            this.lb_error.Visible = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.BackgroundImage")));
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(227, 41);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(120, 120);
            this.guna2PictureBox1.TabIndex = 38;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(154, 311);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(258, 1);
            this.guna2Panel1.TabIndex = 39;
            // 
            // FormXacNhanDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(570, 676);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.lbDemNguoc);
            this.Controls.Add(this.lbTimeLate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btSendAgain);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.tbCode);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormXacNhanDK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormXacNhanDK";
            this.Load += new System.EventHandler(this.FormXacNhanDK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox tbCode;
        private Guna.UI2.WinForms.Guna2Button btSendAgain;
        private Guna.UI2.WinForms.Guna2Button btConfirm;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbDemNguoc;
        private System.Windows.Forms.Timer timeCountdownCode;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbTimeLate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_error;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}