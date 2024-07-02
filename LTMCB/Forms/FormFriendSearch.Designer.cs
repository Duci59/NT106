namespace LTMCB.Forms
{
    partial class FormFriendSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFriendSearch));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.toolTipGroup = new System.Windows.Forms.ToolTip(this.components);
            this.timerLoadGr = new System.Windows.Forms.Timer(this.components);
            this.FriendSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClose = new System.Windows.Forms.Button();
            this.bt_TimBan = new Guna.UI2.WinForms.Guna2Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.lb_Timban = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            // 
            // toolTipGroup
            // 
            this.toolTipGroup.IsBalloon = true;
            this.toolTipGroup.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipGroup.ToolTipTitle = "Gợi ý";
            // 
            // FriendSearch
            // 
            this.FriendSearch.BackColor = System.Drawing.Color.SlateGray;
            this.FriendSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FriendSearch.Location = new System.Drawing.Point(0, 122);
            this.FriendSearch.Name = "FriendSearch";
            this.FriendSearch.Size = new System.Drawing.Size(1015, 461);
            this.FriendSearch.TabIndex = 46;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.btnClose.Location = new System.Drawing.Point(972, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 47;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bt_TimBan
            // 
            this.bt_TimBan.BorderThickness = 1;
            this.bt_TimBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_TimBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_TimBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_TimBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_TimBan.FillColor = System.Drawing.Color.SteelBlue;
            this.bt_TimBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_TimBan.ForeColor = System.Drawing.Color.Black;
            this.bt_TimBan.Location = new System.Drawing.Point(807, 68);
            this.bt_TimBan.Margin = new System.Windows.Forms.Padding(4);
            this.bt_TimBan.Name = "bt_TimBan";
            this.bt_TimBan.Size = new System.Drawing.Size(180, 32);
            this.bt_TimBan.TabIndex = 44;
            this.bt_TimBan.Text = "Tìm kiếm";
            this.bt_TimBan.Click += new System.EventHandler(this.btTimBan_Click);
            // 
            // tb_search
            // 
            this.tb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search.Location = new System.Drawing.Point(28, 68);
            this.tb_search.Margin = new System.Windows.Forms.Padding(5);
            this.tb_search.MaxLength = 40;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(728, 26);
            this.tb_search.TabIndex = 45;
            // 
            // lb_Timban
            // 
            this.lb_Timban.AutoSize = true;
            this.lb_Timban.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Timban.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.lb_Timban.Location = new System.Drawing.Point(387, 13);
            this.lb_Timban.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Timban.Name = "lb_Timban";
            this.lb_Timban.Size = new System.Drawing.Size(231, 36);
            this.lb_Timban.TabIndex = 36;
            this.lb_Timban.Text = "Tìm kiếm bạn bè";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.bntClose);
            this.panel1.Controls.Add(this.lb_Timban);
            this.panel1.Controls.Add(this.tb_search);
            this.panel1.Controls.Add(this.bt_TimBan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 122);
            this.panel1.TabIndex = 48;
            // 
            // bntClose
            // 
            this.bntClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntClose.BackgroundImage")));
            this.bntClose.FlatAppearance.BorderSize = 0;
            this.bntClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntClose.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(179)))), ((int)(((byte)(132)))));
            this.bntClose.Location = new System.Drawing.Point(972, 13);
            this.bntClose.Margin = new System.Windows.Forms.Padding(4);
            this.bntClose.Name = "bntClose";
            this.bntClose.Size = new System.Drawing.Size(30, 30);
            this.bntClose.TabIndex = 49;
            this.bntClose.UseVisualStyleBackColor = true;
            this.bntClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormFriendSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1015, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.FriendSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFriendSearch";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ToolTip toolTipGroup;
        private System.Windows.Forms.Timer timerLoadGr;
        private System.Windows.Forms.FlowLayoutPanel FriendSearch;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI2.WinForms.Guna2Button bt_TimBan;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label lb_Timban;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntClose;
    }
}