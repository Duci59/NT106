namespace LTMCB.Forms
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbTenNhom = new System.Windows.Forms.Label();
            this.btnMinisize = new System.Windows.Forms.Button();
            this.btnMaxsize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbNoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnLichSu = new System.Windows.Forms.Panel();
            this.lbStt = new System.Windows.Forms.Label();
            this.timerDellMess = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbTenNhom
            // 
            this.lbTenNhom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTenNhom.AutoSize = true;
            this.lbTenNhom.BackColor = System.Drawing.Color.Transparent;
            this.lbTenNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbTenNhom.Location = new System.Drawing.Point(44, 18);
            this.lbTenNhom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenNhom.Name = "lbTenNhom";
            this.lbTenNhom.Size = new System.Drawing.Size(78, 29);
            this.lbTenNhom.TabIndex = 44;
            this.lbTenNhom.Text = "Nhóm";
            // 
            // btnMinisize
            // 
            this.btnMinisize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinisize.FlatAppearance.BorderSize = 0;
            this.btnMinisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinisize.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinisize.ForeColor = System.Drawing.Color.White;
            this.btnMinisize.Location = new System.Drawing.Point(741, 14);
            this.btnMinisize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.Size = new System.Drawing.Size(40, 37);
            this.btnMinisize.TabIndex = 51;
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
            this.btnMaxsize.Location = new System.Drawing.Point(782, 14);
            this.btnMaxsize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaxsize.Name = "btnMaxsize";
            this.btnMaxsize.Size = new System.Drawing.Size(40, 37);
            this.btnMaxsize.TabIndex = 50;
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
            this.btnClose.Location = new System.Drawing.Point(824, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 37);
            this.btnClose.TabIndex = 49;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbNoiDung
            // 
            this.tbNoiDung.BackColor = System.Drawing.Color.White;
            this.tbNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNoiDung.DefaultText = "";
            this.tbNoiDung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNoiDung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNoiDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNoiDung.Location = new System.Drawing.Point(113, 414);
            this.tbNoiDung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNoiDung.Name = "tbNoiDung";
            this.tbNoiDung.PasswordChar = '\0';
            this.tbNoiDung.PlaceholderText = "";
            this.tbNoiDung.SelectedText = "";
            this.tbNoiDung.Size = new System.Drawing.Size(571, 53);
            this.tbNoiDung.TabIndex = 52;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(692, 413);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(115, 53);
            this.guna2Button1.TabIndex = 53;
            this.guna2Button1.Text = "Gửi";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(32, 413);
            this.guna2ImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(84, 54);
            this.guna2ImageButton1.TabIndex = 54;
            // 
            // pnLichSu
            // 
            this.pnLichSu.AutoScroll = true;
            this.pnLichSu.BackColor = System.Drawing.Color.White;
            this.pnLichSu.Location = new System.Drawing.Point(49, 65);
            this.pnLichSu.Name = "pnLichSu";
            this.pnLichSu.Size = new System.Drawing.Size(778, 314);
            this.pnLichSu.TabIndex = 55;
            // 
            // lbStt
            // 
            this.lbStt.AutoSize = true;
            this.lbStt.BackColor = System.Drawing.Color.White;
            this.lbStt.Location = new System.Drawing.Point(123, 434);
            this.lbStt.Name = "lbStt";
            this.lbStt.Size = new System.Drawing.Size(97, 16);
            this.lbStt.TabIndex = 56;
            this.lbStt.Text = "Nhập tin nhắn...";
            this.lbStt.Click += new System.EventHandler(this.lbStt_Click);
            // 
            // timerDellMess
            // 
            this.timerDellMess.Enabled = true;
            this.timerDellMess.Interval = 1000;
            this.timerDellMess.Tick += new System.EventHandler(this.timerDellMess_Tick);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(888, 505);
            this.Controls.Add(this.lbStt);
            this.Controls.Add(this.pnLichSu);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.tbNoiDung);
            this.Controls.Add(this.btnMinisize);
            this.Controls.Add(this.btnMaxsize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbTenNhom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Button btnMinisize;
        private System.Windows.Forms.Button btnMaxsize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbTenNhom;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox tbNoiDung;
        private System.Windows.Forms.Panel pnLichSu;
        private System.Windows.Forms.Label lbStt;
        private System.Windows.Forms.Timer timerDellMess;
    }
}