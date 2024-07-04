namespace LTMCB.Forms
{
    partial class FormChatFriend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChatFriend));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnLichSu = new System.Windows.Forms.Panel();
            this.lbfriendname = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.tbNoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnMinisize = new System.Windows.Forms.Button();
            this.btnMaxsize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.timerDellMess = new System.Windows.Forms.Timer(this.components);
            this.toolTipChangePass = new System.Windows.Forms.ToolTip(this.components);
            this.lbStt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // pnLichSu
            // 
            this.pnLichSu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnLichSu.AutoScroll = true;
            this.pnLichSu.BackColor = System.Drawing.Color.SlateGray;
            this.pnLichSu.Location = new System.Drawing.Point(16, 146);
            this.pnLichSu.Margin = new System.Windows.Forms.Padding(5);
            this.pnLichSu.Name = "pnLichSu";
            this.pnLichSu.Size = new System.Drawing.Size(1103, 536);
            this.pnLichSu.TabIndex = 3;
            // 
            // lbfriendname
            // 
            this.lbfriendname.BackColor = System.Drawing.Color.Transparent;
            this.lbfriendname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbfriendname.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.lbfriendname.Location = new System.Drawing.Point(369, 58);
            this.lbfriendname.Margin = new System.Windows.Forms.Padding(4);
            this.lbfriendname.Name = "lbfriendname";
            this.lbfriendname.Size = new System.Drawing.Size(222, 38);
            this.lbfriendname.TabIndex = 4;
            this.lbfriendname.Text = "Đang trò chuyện ";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(16, 702);
            this.guna2ImageButton1.Margin = new System.Windows.Forms.Padding(5);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(91, 65);
            this.guna2ImageButton1.TabIndex = 57;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(981, 703);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(138, 64);
            this.guna2Button1.TabIndex = 56;
            this.guna2Button1.Text = "Gửi";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // tbNoiDung
            // 
            this.tbNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNoiDung.DefaultText = "";
            this.tbNoiDung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNoiDung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNoiDung.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbNoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNoiDung.Location = new System.Drawing.Point(104, 703);
            this.tbNoiDung.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbNoiDung.Name = "tbNoiDung";
            this.tbNoiDung.PasswordChar = '\0';
            this.tbNoiDung.PlaceholderText = "";
            this.tbNoiDung.SelectedText = "";
            this.tbNoiDung.Size = new System.Drawing.Size(867, 64);
            this.tbNoiDung.TabIndex = 55;
            // 
            // btnMinisize
            // 
            this.btnMinisize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinisize.FlatAppearance.BorderSize = 0;
            this.btnMinisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinisize.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinisize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.btnMinisize.Location = new System.Drawing.Point(956, 16);
            this.btnMinisize.Margin = new System.Windows.Forms.Padding(5);
            this.btnMinisize.Name = "btnMinisize";
            this.btnMinisize.Size = new System.Drawing.Size(48, 44);
            this.btnMinisize.TabIndex = 60;
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
            this.btnMaxsize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.btnMaxsize.Location = new System.Drawing.Point(1006, 16);
            this.btnMaxsize.Margin = new System.Windows.Forms.Padding(5);
            this.btnMaxsize.Name = "btnMaxsize";
            this.btnMaxsize.Size = new System.Drawing.Size(48, 44);
            this.btnMaxsize.TabIndex = 59;
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
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.btnClose.Location = new System.Drawing.Point(1056, 16);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 44);
            this.btnClose.TabIndex = 58;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timerDellMess
            // 
            this.timerDellMess.Enabled = true;
            this.timerDellMess.Interval = 1000;
            this.timerDellMess.Tick += new System.EventHandler(this.timerDellMess_Tick);
            // 
            // toolTipChangePass
            // 
            this.toolTipChangePass.AutomaticDelay = 200;
            this.toolTipChangePass.AutoPopDelay = 9000;
            this.toolTipChangePass.InitialDelay = 200;
            this.toolTipChangePass.ReshowDelay = 40;
            this.toolTipChangePass.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipChangePass.ToolTipTitle = "Hướng dẫn";
            // 
            // lbStt
            // 
            this.lbStt.AutoSize = true;
            this.lbStt.BackColor = System.Drawing.Color.White;
            this.lbStt.Location = new System.Drawing.Point(115, 726);
            this.lbStt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStt.Name = "lbStt";
            this.lbStt.Size = new System.Drawing.Size(120, 20);
            this.lbStt.TabIndex = 61;
            this.lbStt.Text = "Nhập tin nhắn...";
            this.lbStt.Click += new System.EventHandler(this.lbStt_Click);
            // 
            // FormChatFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1133, 794);
            this.Controls.Add(this.lbStt);
            this.Controls.Add(this.btnMinisize);
            this.Controls.Add(this.btnMaxsize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.tbNoiDung);
            this.Controls.Add(this.lbfriendname);
            this.Controls.Add(this.pnLichSu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormChatFriend";
            this.Text = "FormAdGroup";
            this.Load += new System.EventHandler(this.FormChatClient_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel pnLichSu;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbfriendname;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox tbNoiDung;
        private System.Windows.Forms.Button btnMinisize;
        private System.Windows.Forms.Button btnMaxsize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timerDellMess;
        private System.Windows.Forms.ToolTip toolTipChangePass;
        private System.Windows.Forms.Label lbStt;
    }
}