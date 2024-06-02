namespace LTMCB.Forms
{
    partial class FormDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangKy));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTDN = new System.Windows.Forms.TextBox();
            this.tbTHT = new System.Windows.Forms.TextBox();
            this.tbMK = new System.Windows.Forms.TextBox();
            this.tbNLMK = new System.Windows.Forms.TextBox();
            this.tbDK = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.Dangkybtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.errorlb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(53, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hiển thị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(53, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(53, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(53, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên đăng nhập";
            // 
            // tbTDN
            // 
            this.tbTDN.Location = new System.Drawing.Point(261, 104);
            this.tbTDN.Name = "tbTDN";
            this.tbTDN.Size = new System.Drawing.Size(169, 22);
            this.tbTDN.TabIndex = 5;
            this.tbTDN.TextChanged += new System.EventHandler(this.tbTDN_TextChanged);
            // 
            // tbTHT
            // 
            this.tbTHT.Location = new System.Drawing.Point(261, 173);
            this.tbTHT.Name = "tbTHT";
            this.tbTHT.Size = new System.Drawing.Size(169, 22);
            this.tbTHT.TabIndex = 6;
            // 
            // tbMK
            // 
            this.tbMK.Location = new System.Drawing.Point(261, 241);
            this.tbMK.Name = "tbMK";
            this.tbMK.PasswordChar = '●';
            this.tbMK.Size = new System.Drawing.Size(169, 22);
            this.tbMK.TabIndex = 7;
            // 
            // tbNLMK
            // 
            this.tbNLMK.Location = new System.Drawing.Point(261, 311);
            this.tbNLMK.Name = "tbNLMK";
            this.tbNLMK.PasswordChar = '●';
            this.tbNLMK.Size = new System.Drawing.Size(169, 22);
            this.tbNLMK.TabIndex = 8;
            // 
            // tbDK
            // 
            this.tbDK.Location = new System.Drawing.Point(261, 377);
            this.tbDK.Name = "tbDK";
            this.tbDK.Size = new System.Drawing.Size(169, 22);
            this.tbDK.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.btnClose.Location = new System.Drawing.Point(422, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 37);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Dangkybtn
            // 
            this.Dangkybtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Dangkybtn.HoverState.ImageSize = new System.Drawing.Size(150, 70);
            this.Dangkybtn.Image = ((System.Drawing.Image)(resources.GetObject("Dangkybtn.Image")));
            this.Dangkybtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.Dangkybtn.ImageRotate = 0F;
            this.Dangkybtn.ImageSize = new System.Drawing.Size(150, 70);
            this.Dangkybtn.Location = new System.Drawing.Point(141, 462);
            this.Dangkybtn.Name = "Dangkybtn";
            this.Dangkybtn.PressedState.ImageSize = new System.Drawing.Size(150, 70);
            this.Dangkybtn.Size = new System.Drawing.Size(161, 65);
            this.Dangkybtn.TabIndex = 38;
            this.Dangkybtn.Click += new System.EventHandler(this.Dangkybtn_Click);
            // 
            // errorlb
            // 
            this.errorlb.BackColor = System.Drawing.Color.Transparent;
            this.errorlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.errorlb.ForeColor = System.Drawing.Color.Red;
            this.errorlb.Location = new System.Drawing.Point(58, 423);
            this.errorlb.Name = "errorlb";
            this.errorlb.Size = new System.Drawing.Size(84, 20);
            this.errorlb.TabIndex = 40;
            this.errorlb.Text = "display error";
            this.errorlb.Visible = false;
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(475, 563);
            this.Controls.Add(this.errorlb);
            this.Controls.Add(this.Dangkybtn);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbDK);
            this.Controls.Add(this.tbNLMK);
            this.Controls.Add(this.tbMK);
            this.Controls.Add(this.tbTHT);
            this.Controls.Add(this.tbTDN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DarkMagenta;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangKy";
            this.Load += new System.EventHandler(this.FormDangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDK;
        private System.Windows.Forms.TextBox tbNLMK;
        private System.Windows.Forms.TextBox tbMK;
        private System.Windows.Forms.TextBox tbTHT;
        private System.Windows.Forms.TextBox tbTDN;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI2.WinForms.Guna2ImageButton Dangkybtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel errorlb;
    }
}

