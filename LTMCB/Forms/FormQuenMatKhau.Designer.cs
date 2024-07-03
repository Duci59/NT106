namespace LTMCB.Forms
{
    partial class FormQuenMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuenMatKhau));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbFind = new System.Windows.Forms.RichTextBox();
            this.ntTimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.btHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(563, 382);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(8, 8);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(130, 213);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(226, 40);
            this.guna2HtmlLabel1.TabIndex = 26;
            this.guna2HtmlLabel1.Text = "Quên mật khẩu";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.SteelBlue;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(67, 281);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(368, 27);
            this.guna2HtmlLabel2.TabIndex = 27;
            this.guna2HtmlLabel2.Text = "Nhập email để tìm kiếm tài khoản của bạn.";
            // 
            // tbFind
            // 
            this.tbFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tbFind.ForeColor = System.Drawing.SystemColors.Info;
            this.tbFind.Location = new System.Drawing.Point(77, 314);
            this.tbFind.Multiline = false;
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(348, 32);
            this.tbFind.TabIndex = 29;
            this.tbFind.Text = "";
            // 
            // ntTimkiem
            // 
            this.ntTimkiem.BorderRadius = 10;
            this.ntTimkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ntTimkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ntTimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ntTimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ntTimkiem.FillColor = System.Drawing.Color.SteelBlue;
            this.ntTimkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ntTimkiem.ForeColor = System.Drawing.Color.Black;
            this.ntTimkiem.Location = new System.Drawing.Point(324, 448);
            this.ntTimkiem.Name = "ntTimkiem";
            this.ntTimkiem.Size = new System.Drawing.Size(84, 43);
            this.ntTimkiem.TabIndex = 30;
            this.ntTimkiem.Text = "Tiếp";
            this.ntTimkiem.Click += new System.EventHandler(this.ntTimkiem_Click);
            // 
            // btHuy
            // 
            this.btHuy.BorderRadius = 10;
            this.btHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btHuy.FillColor = System.Drawing.Color.SteelBlue;
            this.btHuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btHuy.ForeColor = System.Drawing.Color.Black;
            this.btHuy.Location = new System.Drawing.Point(60, 448);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(87, 43);
            this.btHuy.TabIndex = 31;
            this.btHuy.Text = "Hủy";
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.btnClose.Location = new System.Drawing.Point(417, 24);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 32;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorlb
            // 
            this.errorlb.BackColor = System.Drawing.Color.Transparent;
            this.errorlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.errorlb.ForeColor = System.Drawing.Color.Red;
            this.errorlb.Location = new System.Drawing.Point(60, 409);
            this.errorlb.Name = "errorlb";
            this.errorlb.Size = new System.Drawing.Size(84, 20);
            this.errorlb.TabIndex = 41;
            this.errorlb.Text = "display error";
            this.errorlb.Visible = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(47, 352);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(400, 1);
            this.guna2Panel1.TabIndex = 43;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.BackgroundImage")));
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(184, 42);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(100, 100);
            this.guna2PictureBox1.TabIndex = 44;
            this.guna2PictureBox1.TabStop = false;
            // 
            // FormQuenMatKhau
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(475, 563);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.errorlb);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.ntTimkiem);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuenMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btHuy;
        private Guna.UI2.WinForms.Guna2Button ntTimkiem;
        private System.Windows.Forms.RichTextBox tbFind;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel errorlb;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}