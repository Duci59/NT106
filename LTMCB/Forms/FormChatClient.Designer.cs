namespace LTMCB.Forms
{
    partial class FormChatClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChatClient));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnLichSu = new System.Windows.Forms.Panel();
            this.lbgroupname = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tbMatKhauGr = new Guna.UI2.WinForms.Guna2TextBox();
            this.invitebutton = new Guna.UI2.WinForms.Guna2Button();
            this.btChangePassGr = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridViewsMember = new System.Windows.Forms.DataGridView();
            this.identifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dc = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.tbNoiDung = new Guna.UI2.WinForms.Guna2TextBox();
            this.timerDellMess = new System.Windows.Forms.Timer(this.components);
            this.toolTipChangePass = new System.Windows.Forms.ToolTip(this.components);
            this.lbStt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewsMember)).BeginInit();
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
            this.pnLichSu.BackColor = System.Drawing.Color.White;
            this.pnLichSu.Location = new System.Drawing.Point(13, 122);
            this.pnLichSu.Margin = new System.Windows.Forms.Padding(4);
            this.pnLichSu.Name = "pnLichSu";
            this.pnLichSu.Size = new System.Drawing.Size(643, 447);
            this.pnLichSu.TabIndex = 3;
            // 
            // lbgroupname
            // 
            this.lbgroupname.BackColor = System.Drawing.Color.Transparent;
            this.lbgroupname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbgroupname.ForeColor = System.Drawing.Color.White;
            this.lbgroupname.Location = new System.Drawing.Point(15, 26);
            this.lbgroupname.Name = "lbgroupname";
            this.lbgroupname.Size = new System.Drawing.Size(71, 31);
            this.lbgroupname.TabIndex = 4;
            this.lbgroupname.Text = "Nhóm";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(15, 75);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(133, 26);
            this.guna2HtmlLabel2.TabIndex = 5;
            this.guna2HtmlLabel2.Text = " Mật khẩu nhóm";
            // 
            // tbMatKhauGr
            // 
            this.tbMatKhauGr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMatKhauGr.DefaultText = "";
            this.tbMatKhauGr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMatKhauGr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMatKhauGr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMatKhauGr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMatKhauGr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMatKhauGr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbMatKhauGr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMatKhauGr.Location = new System.Drawing.Point(154, 77);
            this.tbMatKhauGr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMatKhauGr.Name = "tbMatKhauGr";
            this.tbMatKhauGr.PasswordChar = '\0';
            this.tbMatKhauGr.PlaceholderText = "";
            this.tbMatKhauGr.SelectedText = "";
            this.tbMatKhauGr.Size = new System.Drawing.Size(226, 24);
            this.tbMatKhauGr.TabIndex = 6;
            // 
            // invitebutton
            // 
            this.invitebutton.BorderRadius = 12;
            this.invitebutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.invitebutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.invitebutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.invitebutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.invitebutton.FillColor = System.Drawing.Color.SteelBlue;
            this.invitebutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.invitebutton.ForeColor = System.Drawing.Color.White;
            this.invitebutton.Location = new System.Drawing.Point(397, 70);
            this.invitebutton.Name = "invitebutton";
            this.invitebutton.Size = new System.Drawing.Size(105, 40);
            this.invitebutton.TabIndex = 8;
            this.invitebutton.Text = "Mời";
            this.invitebutton.Click += new System.EventHandler(this.invitebutton_Click);
            // 
            // btChangePassGr
            // 
            this.btChangePassGr.BorderRadius = 12;
            this.btChangePassGr.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btChangePassGr.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btChangePassGr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btChangePassGr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btChangePassGr.FillColor = System.Drawing.Color.SteelBlue;
            this.btChangePassGr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btChangePassGr.ForeColor = System.Drawing.Color.White;
            this.btChangePassGr.Location = new System.Drawing.Point(520, 70);
            this.btChangePassGr.Name = "btChangePassGr";
            this.btChangePassGr.Size = new System.Drawing.Size(106, 40);
            this.btChangePassGr.TabIndex = 9;
            this.btChangePassGr.Text = "Đổi pass";
            // 
            // DataGridViewsMember
            // 
            this.DataGridViewsMember.AllowUserToAddRows = false;
            this.DataGridViewsMember.AllowUserToDeleteRows = false;
            this.DataGridViewsMember.AllowUserToResizeColumns = false;
            this.DataGridViewsMember.AllowUserToResizeRows = false;
            this.DataGridViewsMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewsMember.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewsMember.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewsMember.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DataGridViewsMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewsMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewsMember.ColumnHeadersHeight = 24;
            this.DataGridViewsMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewsMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.identifier,
            this.name,
            this.dc});
            this.DataGridViewsMember.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridViewsMember.EnableHeadersVisualStyles = false;
            this.DataGridViewsMember.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(86)))));
            this.DataGridViewsMember.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DataGridViewsMember.Location = new System.Drawing.Point(665, 59);
            this.DataGridViewsMember.Margin = new System.Windows.Forms.Padding(5);
            this.DataGridViewsMember.MultiSelect = false;
            this.DataGridViewsMember.Name = "DataGridViewsMember";
            this.DataGridViewsMember.ReadOnly = true;
            this.DataGridViewsMember.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DataGridViewsMember.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewsMember.RowHeadersVisible = false;
            this.DataGridViewsMember.RowHeadersWidth = 40;
            this.DataGridViewsMember.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewsMember.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewsMember.RowTemplate.Height = 24;
            this.DataGridViewsMember.RowTemplate.ReadOnly = true;
            this.DataGridViewsMember.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewsMember.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewsMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewsMember.ShowCellErrors = false;
            this.DataGridViewsMember.ShowCellToolTips = false;
            this.DataGridViewsMember.ShowEditingIcon = false;
            this.DataGridViewsMember.ShowRowErrors = false;
            this.DataGridViewsMember.Size = new System.Drawing.Size(265, 580);
            this.DataGridViewsMember.TabIndex = 32;
            this.DataGridViewsMember.TabStop = false;
            this.DataGridViewsMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewsMember_CellClick);
            // 
            // identifier
            // 
            this.identifier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.identifier.DefaultCellStyle = dataGridViewCellStyle2;
            this.identifier.HeaderText = "ID";
            this.identifier.MaxInputLength = 20;
            this.identifier.MinimumWidth = 20;
            this.identifier.Name = "identifier";
            this.identifier.ReadOnly = true;
            this.identifier.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.identifier.Width = 70;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.name.DefaultCellStyle = dataGridViewCellStyle3;
            this.name.HeaderText = "Name";
            this.name.MaxInputLength = 20;
            this.name.MinimumWidth = 20;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dc
            // 
            this.dc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dc.DefaultCellStyle = dataGridViewCellStyle4;
            this.dc.HeaderText = "Disconnect";
            this.dc.MinimumWidth = 20;
            this.dc.Name = "dc";
            this.dc.ReadOnly = true;
            this.dc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dc.Text = "Kick";
            this.dc.UseColumnTextForButtonValue = true;
            this.dc.Width = 80;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(13, 585);
            this.guna2ImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(76, 54);
            this.guna2ImageButton1.TabIndex = 57;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(541, 585);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(115, 53);
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
            this.tbNoiDung.Location = new System.Drawing.Point(87, 586);
            this.tbNoiDung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNoiDung.Name = "tbNoiDung";
            this.tbNoiDung.PasswordChar = '\0';
            this.tbNoiDung.PlaceholderText = "";
            this.tbNoiDung.SelectedText = "";
            this.tbNoiDung.Size = new System.Drawing.Size(425, 53);
            this.tbNoiDung.TabIndex = 55;
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
            this.lbStt.Location = new System.Drawing.Point(96, 605);
            this.lbStt.Name = "lbStt";
            this.lbStt.Size = new System.Drawing.Size(97, 16);
            this.lbStt.TabIndex = 61;
            this.lbStt.Text = "Nhập tin nhắn...";
            this.lbStt.Click += new System.EventHandler(this.lbStt_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(900, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 70;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(944, 662);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbStt);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.tbNoiDung);
            this.Controls.Add(this.DataGridViewsMember);
            this.Controls.Add(this.btChangePassGr);
            this.Controls.Add(this.invitebutton);
            this.Controls.Add(this.tbMatKhauGr);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.lbgroupname);
            this.Controls.Add(this.pnLichSu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChatClient";
            this.Text = "FormAdGroup";
            this.Load += new System.EventHandler(this.FormChatClient_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewsMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel pnLichSu;
        private Guna.UI2.WinForms.Guna2TextBox tbMatKhauGr;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbgroupname;
        private Guna.UI2.WinForms.Guna2Button invitebutton;
        private Guna.UI2.WinForms.Guna2Button btChangePassGr;
        private System.Windows.Forms.DataGridView DataGridViewsMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewButtonColumn dc;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox tbNoiDung;
        private System.Windows.Forms.Timer timerDellMess;
        private System.Windows.Forms.ToolTip toolTipChangePass;
        private System.Windows.Forms.Label lbStt;
        private System.Windows.Forms.Button button1;
    }
}