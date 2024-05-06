namespace LTMCB.Forms
{
    partial class QLFile
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
            this.flowLayoutFileList = new System.Windows.Forms.FlowLayoutPanel();
            this.btChonFile = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaKhoa = new Guna.UI2.WinForms.Guna2TextBox();
            this.btTaiLen = new Guna.UI2.WinForms.Guna2Button();
            this.btGiaiMa = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // flowLayoutFileList
            // 
            this.flowLayoutFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutFileList.AutoScroll = true;
            this.flowLayoutFileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.flowLayoutFileList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.flowLayoutFileList.Location = new System.Drawing.Point(13, 85);
            this.flowLayoutFileList.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutFileList.Name = "flowLayoutFileList";
            this.flowLayoutFileList.Size = new System.Drawing.Size(820, 271);
            this.flowLayoutFileList.TabIndex = 54;
            // 
            // btChonFile
            // 
            this.btChonFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btChonFile.Animated = true;
            this.btChonFile.BackColor = System.Drawing.Color.Transparent;
            this.btChonFile.BorderColor = System.Drawing.Color.Transparent;
            this.btChonFile.BorderRadius = 10;
            this.btChonFile.BorderThickness = 2;
            this.btChonFile.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btChonFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btChonFile.ForeColor = System.Drawing.Color.White;
            this.btChonFile.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btChonFile.Location = new System.Drawing.Point(13, 378);
            this.btChonFile.Margin = new System.Windows.Forms.Padding(4);
            this.btChonFile.Name = "btChonFile";
            this.btChonFile.Size = new System.Drawing.Size(128, 48);
            this.btChonFile.TabIndex = 55;
            this.btChonFile.Text = "Chọn file";
            this.btChonFile.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(341, 387);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Mã khóa";
            // 
            // tbMaKhoa
            // 
            this.tbMaKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaKhoa.BorderRadius = 10;
            this.tbMaKhoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMaKhoa.DefaultText = "";
            this.tbMaKhoa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMaKhoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMaKhoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaKhoa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMaKhoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaKhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbMaKhoa.ForeColor = System.Drawing.Color.Black;
            this.tbMaKhoa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMaKhoa.Location = new System.Drawing.Point(437, 378);
            this.tbMaKhoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMaKhoa.MaxLength = 20;
            this.tbMaKhoa.Name = "tbMaKhoa";
            this.tbMaKhoa.PasswordChar = '\0';
            this.tbMaKhoa.PlaceholderText = "";
            this.tbMaKhoa.SelectedText = "";
            this.tbMaKhoa.Size = new System.Drawing.Size(183, 48);
            this.tbMaKhoa.TabIndex = 57;
            // 
            // btTaiLen
            // 
            this.btTaiLen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btTaiLen.Animated = true;
            this.btTaiLen.BackColor = System.Drawing.Color.Transparent;
            this.btTaiLen.BorderColor = System.Drawing.Color.White;
            this.btTaiLen.BorderRadius = 10;
            this.btTaiLen.BorderThickness = 2;
            this.btTaiLen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btTaiLen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btTaiLen.ForeColor = System.Drawing.Color.White;
            this.btTaiLen.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btTaiLen.Location = new System.Drawing.Point(692, 378);
            this.btTaiLen.Margin = new System.Windows.Forms.Padding(4);
            this.btTaiLen.Name = "btTaiLen";
            this.btTaiLen.Size = new System.Drawing.Size(131, 48);
            this.btTaiLen.TabIndex = 58;
            this.btTaiLen.Text = "Tải lên";
            this.btTaiLen.UseTransparentBackground = true;
            // 
            // btGiaiMa
            // 
            this.btGiaiMa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btGiaiMa.Animated = true;
            this.btGiaiMa.BackColor = System.Drawing.Color.Transparent;
            this.btGiaiMa.BorderRadius = 10;
            this.btGiaiMa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135)))));
            this.btGiaiMa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btGiaiMa.ForeColor = System.Drawing.Color.White;
            this.btGiaiMa.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btGiaiMa.Location = new System.Drawing.Point(692, 14);
            this.btGiaiMa.Margin = new System.Windows.Forms.Padding(4);
            this.btGiaiMa.Name = "btGiaiMa";
            this.btGiaiMa.Size = new System.Drawing.Size(131, 49);
            this.btGiaiMa.TabIndex = 53;
            this.btGiaiMa.Text = "Giải Mã File";
            this.btGiaiMa.UseTransparentBackground = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 57;
            this.label2.Text = "Danh sách file của bạn";
            // 
            // QLFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(846, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btGiaiMa);
            this.Controls.Add(this.btTaiLen);
            this.Controls.Add(this.tbMaKhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btChonFile);
            this.Controls.Add(this.flowLayoutFileList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLFile";
            this.Text = "Quản lý file";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutFileList;
        private Guna.UI2.WinForms.Guna2Button btChonFile;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btGiaiMa;
        private Guna.UI2.WinForms.Guna2Button btTaiLen;
        private Guna.UI2.WinForms.Guna2TextBox tbMaKhoa;
        private System.Windows.Forms.Label label1;
    }
}