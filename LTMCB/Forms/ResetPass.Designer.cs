namespace LTMCB.Forms
{
    partial class ResetPass
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
            this.tbNLMK = new System.Windows.Forms.TextBox();
            this.tbMK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btXacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lb_errormes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this;
            // 
            // tbNLMK
            // 
            this.tbNLMK.Location = new System.Drawing.Point(285, 329);
            this.tbNLMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNLMK.Name = "tbNLMK";
            this.tbNLMK.PasswordChar = '●';
            this.tbNLMK.Size = new System.Drawing.Size(190, 26);
            this.tbNLMK.TabIndex = 12;
            // 
            // tbMK
            // 
            this.tbMK.Location = new System.Drawing.Point(285, 241);
            this.tbMK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMK.Name = "tbMK";
            this.tbMK.PasswordChar = '●';
            this.tbMK.Size = new System.Drawing.Size(190, 26);
            this.tbMK.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(51, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(51, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mật khẩu mới";
            // 
            // btXacNhan
            // 
            this.btXacNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btXacNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btXacNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btXacNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btXacNhan.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btXacNhan.ForeColor = System.Drawing.Color.White;
            this.btXacNhan.Location = new System.Drawing.Point(56, 445);
            this.btXacNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(418, 54);
            this.btXacNhan.TabIndex = 31;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(475, 16);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 46);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lb_errormes
            // 
            this.lb_errormes.BackColor = System.Drawing.Color.Transparent;
            this.lb_errormes.ForeColor = System.Drawing.Color.Red;
            this.lb_errormes.Location = new System.Drawing.Point(56, 389);
            this.lb_errormes.Name = "lb_errormes";
            this.lb_errormes.Size = new System.Drawing.Size(36, 22);
            this.lb_errormes.TabIndex = 33;
            this.lb_errormes.Text = "error";
            this.lb_errormes.Visible = false;
            // 
            // ResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(182)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(534, 704);
            this.Controls.Add(this.lb_errormes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btXacNhan);
            this.Controls.Add(this.tbNLMK);
            this.Controls.Add(this.tbMK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ResetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResetPass";
            this.Load += new System.EventHandler(this.ResetPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TextBox tbNLMK;
        private System.Windows.Forms.TextBox tbMK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btXacNhan;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_errormes;
    }
}