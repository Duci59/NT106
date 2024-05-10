namespace LTMCB.Forms
{
    partial class TrangChu
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
            this.btEditDisplayname = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDisplayname = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btBaoVe = new System.Windows.Forms.Button();
            this.btDoiPass = new System.Windows.Forms.Button();
            this.pnBgTop = new Guna.UI2.WinForms.Guna2Panel();
            this.panelDoiPass = new System.Windows.Forms.Panel();
            this.btConfirmChangePass = new System.Windows.Forms.Button();
            this.tbNewPass2 = new System.Windows.Forms.TextBox();
            this.tbNewPass = new System.Windows.Forms.TextBox();
            this.tbOldPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnBgTop.SuspendLayout();
            this.panelDoiPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // btEditDisplayname
            // 
            this.btEditDisplayname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditDisplayname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditDisplayname.Location = new System.Drawing.Point(41, 136);
            this.btEditDisplayname.Margin = new System.Windows.Forms.Padding(4);
            this.btEditDisplayname.Name = "btEditDisplayname";
            this.btEditDisplayname.Size = new System.Drawing.Size(121, 49);
            this.btEditDisplayname.TabIndex = 32;
            this.btEditDisplayname.Text = "Sửa";
            this.btEditDisplayname.UseVisualStyleBackColor = true;
            this.btEditDisplayname.Click += new System.EventHandler(this.btEditDisplayname_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 29);
            this.label6.TabIndex = 38;
            this.label6.Text = "Tên hiển thị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 29);
            this.label5.TabIndex = 39;
            this.label5.Text = "Mã khóa của bạn";
            // 
            // tbDisplayname
            // 
            this.tbDisplayname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDisplayname.Location = new System.Drawing.Point(41, 82);
            this.tbDisplayname.Margin = new System.Windows.Forms.Padding(4);
            this.tbDisplayname.MaxLength = 20;
            this.tbDisplayname.Name = "tbDisplayname";
            this.tbDisplayname.Size = new System.Drawing.Size(209, 26);
            this.tbDisplayname.TabIndex = 31;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(395, 47);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(85, 29);
            this.labelStatus.TabIndex = 37;
            this.labelStatus.Text = "Status";
            // 
            // tbKey
            // 
            this.tbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKey.Location = new System.Drawing.Point(41, 252);
            this.tbKey.Margin = new System.Windows.Forms.Padding(4);
            this.tbKey.MaxLength = 100;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(209, 26);
            this.tbKey.TabIndex = 33;
            // 
            // btSua
            // 
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Location = new System.Drawing.Point(41, 289);
            this.btSua.Margin = new System.Windows.Forms.Padding(4);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(121, 49);
            this.btSua.TabIndex = 34;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btBaoVe
            // 
            this.btBaoVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBaoVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBaoVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaoVe.Location = new System.Drawing.Point(372, 125);
            this.btBaoVe.Margin = new System.Windows.Forms.Padding(4);
            this.btBaoVe.Name = "btBaoVe";
            this.btBaoVe.Size = new System.Drawing.Size(136, 49);
            this.btBaoVe.TabIndex = 35;
            this.btBaoVe.Text = "Tắt";
            this.btBaoVe.UseVisualStyleBackColor = true;
            // 
            // btDoiPass
            // 
            this.btDoiPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDoiPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDoiPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoiPass.Location = new System.Drawing.Point(545, 125);
            this.btDoiPass.Margin = new System.Windows.Forms.Padding(4);
            this.btDoiPass.Name = "btDoiPass";
            this.btDoiPass.Size = new System.Drawing.Size(136, 49);
            this.btDoiPass.TabIndex = 36;
            this.btDoiPass.Text = "Đổi mật khẩu";
            this.btDoiPass.UseVisualStyleBackColor = true;
            this.btDoiPass.Click += new System.EventHandler(this.btDoiPass_Click);
            // 
            // pnBgTop
            // 
            this.pnBgTop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBgTop.BackColor = System.Drawing.Color.White;
            this.pnBgTop.BorderRadius = 30;
            this.pnBgTop.Controls.Add(this.panelDoiPass);
            this.pnBgTop.Controls.Add(this.btDoiPass);
            this.pnBgTop.Controls.Add(this.btBaoVe);
            this.pnBgTop.Controls.Add(this.labelStatus);
            this.pnBgTop.Controls.Add(this.label5);
            this.pnBgTop.Controls.Add(this.btSua);
            this.pnBgTop.Controls.Add(this.tbKey);
            this.pnBgTop.Controls.Add(this.btEditDisplayname);
            this.pnBgTop.Controls.Add(this.label6);
            this.pnBgTop.Controls.Add(this.tbDisplayname);
            this.pnBgTop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.pnBgTop.Location = new System.Drawing.Point(13, 1);
            this.pnBgTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnBgTop.Name = "pnBgTop";
            this.pnBgTop.Size = new System.Drawing.Size(808, 423);
            this.pnBgTop.TabIndex = 42;
            // 
            // panelDoiPass
            // 
            this.panelDoiPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDoiPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panelDoiPass.Controls.Add(this.btConfirmChangePass);
            this.panelDoiPass.Controls.Add(this.tbNewPass2);
            this.panelDoiPass.Controls.Add(this.tbNewPass);
            this.panelDoiPass.Controls.Add(this.tbOldPass);
            this.panelDoiPass.Controls.Add(this.label4);
            this.panelDoiPass.Controls.Add(this.label3);
            this.panelDoiPass.Controls.Add(this.label2);
            this.panelDoiPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDoiPass.Location = new System.Drawing.Point(353, 182);
            this.panelDoiPass.Margin = new System.Windows.Forms.Padding(4);
            this.panelDoiPass.Name = "panelDoiPass";
            this.panelDoiPass.Size = new System.Drawing.Size(349, 165);
            this.panelDoiPass.TabIndex = 40;
            this.panelDoiPass.Visible = false;
            // 
            // btConfirmChangePass
            // 
            this.btConfirmChangePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btConfirmChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmChangePass.Location = new System.Drawing.Point(125, 113);
            this.btConfirmChangePass.Margin = new System.Windows.Forms.Padding(4);
            this.btConfirmChangePass.Name = "btConfirmChangePass";
            this.btConfirmChangePass.Size = new System.Drawing.Size(124, 44);
            this.btConfirmChangePass.TabIndex = 16;
            this.btConfirmChangePass.Text = "Xác nhận";
            this.btConfirmChangePass.UseVisualStyleBackColor = true;
            // 
            // tbNewPass2
            // 
            this.tbNewPass2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbNewPass2.Location = new System.Drawing.Point(125, 76);
            this.tbNewPass2.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewPass2.Name = "tbNewPass2";
            this.tbNewPass2.PasswordChar = '•';
            this.tbNewPass2.Size = new System.Drawing.Size(163, 26);
            this.tbNewPass2.TabIndex = 4;
            this.tbNewPass2.UseSystemPasswordChar = true;
            // 
            // tbNewPass
            // 
            this.tbNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbNewPass.Location = new System.Drawing.Point(125, 41);
            this.tbNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.PasswordChar = '•';
            this.tbNewPass.Size = new System.Drawing.Size(163, 26);
            this.tbNewPass.TabIndex = 3;
            this.tbNewPass.UseSystemPasswordChar = true;
            // 
            // tbOldPass
            // 
            this.tbOldPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbOldPass.Location = new System.Drawing.Point(125, 5);
            this.tbOldPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbOldPass.Name = "tbOldPass";
            this.tbOldPass.PasswordChar = '•';
            this.tbOldPass.Size = new System.Drawing.Size(163, 26);
            this.tbOldPass.TabIndex = 2;
            this.tbOldPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập lại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(846, 485);
            this.Controls.Add(this.pnBgTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrangChu";
            this.Text = "Trang Chủ";
            this.pnBgTop.ResumeLayout(false);
            this.pnBgTop.PerformLayout();
            this.panelDoiPass.ResumeLayout(false);
            this.panelDoiPass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btEditDisplayname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbDisplayname;
        private System.Windows.Forms.Label labelStatus;
        public System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btBaoVe;
        private System.Windows.Forms.Button btDoiPass;
        private Guna.UI2.WinForms.Guna2Panel pnBgTop;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panelDoiPass;
        private System.Windows.Forms.Button btConfirmChangePass;
        private System.Windows.Forms.TextBox tbNewPass2;
        private System.Windows.Forms.TextBox tbNewPass;
        private System.Windows.Forms.TextBox tbOldPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}