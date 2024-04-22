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
            this.lbStt = new System.Windows.Forms.Label();
            this.flowLayoutNhomChat = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.tbTenNhom = new System.Windows.Forms.TextBox();
            this.lbTennhom = new System.Windows.Forms.Label();
            this.btTaoNhom = new System.Windows.Forms.Button();
            this.btSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbStt
            // 
            this.lbStt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbStt.AutoSize = true;
            this.lbStt.Location = new System.Drawing.Point(713, 92);
            this.lbStt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStt.Name = "lbStt";
            this.lbStt.Size = new System.Drawing.Size(125, 16);
            this.lbStt.TabIndex = 37;
            this.lbStt.Text = "(Bạn chưa có nhóm)";
            // 
            // flowLayoutNhomChat
            // 
            this.flowLayoutNhomChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutNhomChat.AutoScroll = true;
            this.flowLayoutNhomChat.BackColor = System.Drawing.Color.White;
            this.flowLayoutNhomChat.Location = new System.Drawing.Point(-7, 133);
            this.flowLayoutNhomChat.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutNhomChat.Name = "flowLayoutNhomChat";
            this.flowLayoutNhomChat.Size = new System.Drawing.Size(1199, 448);
            this.flowLayoutNhomChat.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(505, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 29);
            this.label4.TabIndex = 35;
            this.label4.Text = "Danh sách nhóm";
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMatKhau.Location = new System.Drawing.Point(1045, 74);
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
            this.lbMatKhau.Location = new System.Drawing.Point(968, 81);
            this.lbMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(61, 16);
            this.lbMatKhau.TabIndex = 34;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // tbTenNhom
            // 
            this.tbTenNhom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTenNhom.Location = new System.Drawing.Point(1045, 42);
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
            this.lbTennhom.Location = new System.Drawing.Point(964, 46);
            this.lbTennhom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTennhom.Name = "lbTennhom";
            this.lbTennhom.Size = new System.Drawing.Size(67, 16);
            this.lbTennhom.TabIndex = 33;
            this.lbTennhom.Text = "Tên nhóm";
            // 
            // btTaoNhom
            // 
            this.btTaoNhom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTaoNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaoNhom.Location = new System.Drawing.Point(13, 42);
            this.btTaoNhom.Margin = new System.Windows.Forms.Padding(4);
            this.btTaoNhom.Name = "btTaoNhom";
            this.btTaoNhom.Size = new System.Drawing.Size(121, 49);
            this.btTaoNhom.TabIndex = 32;
            this.btTaoNhom.Text = "Tạo nhóm";
            this.btTaoNhom.UseVisualStyleBackColor = true;
            // 
            // btSearch
            // 
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.Location = new System.Drawing.Point(168, 42);
            this.btSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(121, 49);
            this.btSearch.TabIndex = 31;
            this.btSearch.Text = "Tìm nhóm";
            this.btSearch.UseVisualStyleBackColor = true;
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 623);
            this.Controls.Add(this.lbStt);
            this.Controls.Add(this.flowLayoutNhomChat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.tbTenNhom);
            this.Controls.Add(this.lbTennhom);
            this.Controls.Add(this.btTaoNhom);
            this.Controls.Add(this.btSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChat";
            this.Text = "FormChat";
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
        private System.Windows.Forms.Button btTaoNhom;
        private System.Windows.Forms.Button btSearch;
    }
}