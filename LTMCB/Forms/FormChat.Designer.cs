namespace LTMCB.Forms
{
    partial class FormChat
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
            this.flowLayoutNhomChat = new System.Windows.Forms.FlowLayoutPanel();
            this.lbStt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.tbTenNhom = new System.Windows.Forms.TextBox();
            this.lbTennhom = new System.Windows.Forms.Label();
            this.toolTipGroup = new System.Windows.Forms.ToolTip(this.components);
            this.timerLoadGr = new System.Windows.Forms.Timer(this.components);
            this.btTaoNhomm = new Guna.UI2.WinForms.Guna2Button();
            this.btTimNhom = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this.flowLayoutNhomChat;
            // 
            // flowLayoutNhomChat
            // 
            this.flowLayoutNhomChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutNhomChat.AutoScroll = true;
            this.flowLayoutNhomChat.BackColor = System.Drawing.Color.White;
            this.flowLayoutNhomChat.Location = new System.Drawing.Point(-3, 133);
            this.flowLayoutNhomChat.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutNhomChat.Name = "flowLayoutNhomChat";
            this.flowLayoutNhomChat.Size = new System.Drawing.Size(849, 310);
            this.flowLayoutNhomChat.TabIndex = 36;
            this.flowLayoutNhomChat.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutNhomChat_Paint);
            // 
            // lbStt
            // 
            this.lbStt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbStt.AutoSize = true;
            this.lbStt.ForeColor = System.Drawing.Color.White;
            this.lbStt.Location = new System.Drawing.Point(485, 113);
            this.lbStt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStt.Name = "lbStt";
            this.lbStt.Size = new System.Drawing.Size(125, 16);
            this.lbStt.TabIndex = 37;
            this.lbStt.Text = "(Bạn chưa có nhóm)";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(272, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "Danh sách nhóm";
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMatKhau.Location = new System.Drawing.Point(685, 70);
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.tbMatKhau.MaxLength = 30;
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.PasswordChar = '*';
            this.tbMatKhau.Size = new System.Drawing.Size(132, 22);
            this.tbMatKhau.TabIndex = 30;
            this.tbMatKhau.UseSystemPasswordChar = true;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.ForeColor = System.Drawing.Color.White;
            this.lbMatKhau.Location = new System.Drawing.Point(608, 77);
            this.lbMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(61, 16);
            this.lbMatKhau.TabIndex = 34;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // tbTenNhom
            // 
            this.tbTenNhom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTenNhom.Location = new System.Drawing.Point(685, 38);
            this.tbTenNhom.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenNhom.MaxLength = 40;
            this.tbTenNhom.Name = "tbTenNhom";
            this.tbTenNhom.Size = new System.Drawing.Size(132, 22);
            this.tbTenNhom.TabIndex = 29;
            // 
            // lbTennhom
            // 
            this.lbTennhom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTennhom.AutoSize = true;
            this.lbTennhom.ForeColor = System.Drawing.Color.White;
            this.lbTennhom.Location = new System.Drawing.Point(604, 42);
            this.lbTennhom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTennhom.Name = "lbTennhom";
            this.lbTennhom.Size = new System.Drawing.Size(67, 16);
            this.lbTennhom.TabIndex = 33;
            this.lbTennhom.Text = "Tên nhóm";
            // 
            // toolTipGroup
            // 
            this.toolTipGroup.IsBalloon = true;
            this.toolTipGroup.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipGroup.ToolTipTitle = "Gợi ý";
            this.toolTipGroup.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipGroup_Popup);
            // 
            // btTaoNhomm
            // 
            this.btTaoNhomm.BorderRadius = 12;
            this.btTaoNhomm.BorderThickness = 1;
            this.btTaoNhomm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btTaoNhomm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btTaoNhomm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btTaoNhomm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btTaoNhomm.FillColor = System.Drawing.Color.SteelBlue;
            this.btTaoNhomm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btTaoNhomm.ForeColor = System.Drawing.Color.Black;
            this.btTaoNhomm.Location = new System.Drawing.Point(20, 43);
            this.btTaoNhomm.Name = "btTaoNhomm";
            this.btTaoNhomm.Size = new System.Drawing.Size(104, 50);
            this.btTaoNhomm.TabIndex = 38;
            this.btTaoNhomm.Text = "Tạo nhóm";
            this.btTaoNhomm.Click += new System.EventHandler(this.btTaoNhomm_Click);
            // 
            // btTimNhom
            // 
            this.btTimNhom.BorderRadius = 12;
            this.btTimNhom.BorderThickness = 1;
            this.btTimNhom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btTimNhom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btTimNhom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btTimNhom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btTimNhom.FillColor = System.Drawing.Color.SteelBlue;
            this.btTimNhom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btTimNhom.ForeColor = System.Drawing.Color.Black;
            this.btTimNhom.Location = new System.Drawing.Point(154, 43);
            this.btTimNhom.Name = "btTimNhom";
            this.btTimNhom.Size = new System.Drawing.Size(104, 50);
            this.btTimNhom.TabIndex = 39;
            this.btTimNhom.Text = "Tìm nhóm";
            this.btTimNhom.Click += new System.EventHandler(this.btTimNhom_Click);
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(846, 485);
            this.Controls.Add(this.btTimNhom);
            this.Controls.Add(this.btTaoNhomm);
            this.Controls.Add(this.lbStt);
            this.Controls.Add(this.flowLayoutNhomChat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.tbTenNhom);
            this.Controls.Add(this.lbTennhom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChat";
            this.Text = "Chat nhóm";
            this.Load += new System.EventHandler(this.FormChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lbStt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutNhomChat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMatKhau;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.TextBox tbTenNhom;
        private System.Windows.Forms.Label lbTennhom;
        private System.Windows.Forms.ToolTip toolTipGroup;
        private System.Windows.Forms.Timer timerLoadGr;
        private Guna.UI2.WinForms.Guna2Button btTaoNhomm;
        private Guna.UI2.WinForms.Guna2Button btTimNhom;
    }
}