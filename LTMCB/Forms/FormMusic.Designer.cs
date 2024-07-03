namespace LTMCB.Forms
{
    partial class FormMusic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMusic));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbSong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSinger1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnPlayMusic = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnPauseMusic = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnUnmute = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnMute = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnReload = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbSong
            // 
            this.lbSong.BackColor = System.Drawing.Color.Transparent;
            this.lbSong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSong.Location = new System.Drawing.Point(12, 452);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(124, 27);
            this.lbSong.TabIndex = 1;
            this.lbSong.Text = "Tên bài hát:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 435);
            this.panel1.TabIndex = 2;
            // 
            // lbSinger1
            // 
            this.lbSinger1.BackColor = System.Drawing.Color.Transparent;
            this.lbSinger1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSinger1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSinger1.Location = new System.Drawing.Point(12, 498);
            this.lbSinger1.Name = "lbSinger1";
            this.lbSinger1.Size = new System.Drawing.Size(56, 21);
            this.lbSinger1.TabIndex = 3;
            this.lbSinger1.Text = "Tác giả:";
            // 
            // btnPlayMusic
            // 
            this.btnPlayMusic.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPlayMusic.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPlayMusic.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayMusic.Image")));
            this.btnPlayMusic.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPlayMusic.ImageRotate = 0F;
            this.btnPlayMusic.ImageSize = new System.Drawing.Size(60, 60);
            this.btnPlayMusic.Location = new System.Drawing.Point(401, 452);
            this.btnPlayMusic.Name = "btnPlayMusic";
            this.btnPlayMusic.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPlayMusic.Size = new System.Drawing.Size(74, 74);
            this.btnPlayMusic.TabIndex = 4;
            this.btnPlayMusic.Click += new System.EventHandler(this.btnPlayMusic_Click);
            // 
            // btnPauseMusic
            // 
            this.btnPauseMusic.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPauseMusic.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPauseMusic.Image = ((System.Drawing.Image)(resources.GetObject("btnPauseMusic.Image")));
            this.btnPauseMusic.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPauseMusic.ImageRotate = 0F;
            this.btnPauseMusic.ImageSize = new System.Drawing.Size(60, 60);
            this.btnPauseMusic.Location = new System.Drawing.Point(401, 452);
            this.btnPauseMusic.Name = "btnPauseMusic";
            this.btnPauseMusic.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPauseMusic.Size = new System.Drawing.Size(74, 74);
            this.btnPauseMusic.TabIndex = 5;
            this.btnPauseMusic.Visible = false;
            this.btnPauseMusic.Click += new System.EventHandler(this.btnPauseMusic_Click);
            // 
            // btnBack
            // 
            this.btnBack.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBack.HoverState.ImageSize = new System.Drawing.Size(60, 60);
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnBack.ImageRotate = 0F;
            this.btnBack.ImageSize = new System.Drawing.Size(50, 50);
            this.btnBack.Location = new System.Drawing.Point(356, 459);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnBack.Size = new System.Drawing.Size(39, 61);
            this.btnBack.TabIndex = 6;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNext.HoverState.ImageSize = new System.Drawing.Size(60, 60);
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnNext.ImageRotate = 0F;
            this.btnNext.ImageSize = new System.Drawing.Size(50, 50);
            this.btnNext.Location = new System.Drawing.Point(481, 459);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnNext.Size = new System.Drawing.Size(39, 61);
            this.btnNext.TabIndex = 7;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnUnmute
            // 
            this.btnUnmute.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUnmute.HoverState.ImageSize = new System.Drawing.Size(35, 38);
            this.btnUnmute.Image = ((System.Drawing.Image)(resources.GetObject("btnUnmute.Image")));
            this.btnUnmute.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnUnmute.ImageRotate = 0F;
            this.btnUnmute.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUnmute.Location = new System.Drawing.Point(560, 472);
            this.btnUnmute.Name = "btnUnmute";
            this.btnUnmute.PressedState.ImageSize = new System.Drawing.Size(35, 38);
            this.btnUnmute.Size = new System.Drawing.Size(35, 38);
            this.btnUnmute.TabIndex = 8;
            this.btnUnmute.Visible = false;
            this.btnUnmute.Click += new System.EventHandler(this.btnUnmute_Click);
            // 
            // btnMute
            // 
            this.btnMute.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMute.HoverState.ImageSize = new System.Drawing.Size(35, 38);
            this.btnMute.Image = ((System.Drawing.Image)(resources.GetObject("btnMute.Image")));
            this.btnMute.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMute.ImageRotate = 0F;
            this.btnMute.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMute.Location = new System.Drawing.Point(560, 472);
            this.btnMute.Name = "btnMute";
            this.btnMute.PressedState.ImageSize = new System.Drawing.Size(35, 38);
            this.btnMute.Size = new System.Drawing.Size(35, 38);
            this.btnMute.TabIndex = 9;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // btnReload
            // 
            this.btnReload.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnReload.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnReload.ImageRotate = 0F;
            this.btnReload.ImageSize = new System.Drawing.Size(45, 45);
            this.btnReload.Location = new System.Drawing.Point(718, 459);
            this.btnReload.Name = "btnReload";
            this.btnReload.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnReload.Size = new System.Drawing.Size(57, 67);
            this.btnReload.TabIndex = 10;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // FormMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(846, 557);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnUnmute);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPauseMusic);
            this.Controls.Add(this.btnPlayMusic);
            this.Controls.Add(this.lbSinger1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbSong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMusic";
            this.Text = "Nghe nhạc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMusic_FormClosing);
            this.Load += new System.EventHandler(this.FormMusic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbSong;
        private Guna.UI2.WinForms.Guna2ImageButton btnPlayMusic;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbSinger1;
        private Guna.UI2.WinForms.Guna2ImageButton btnNext;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2ImageButton btnPauseMusic;
        private Guna.UI2.WinForms.Guna2ImageButton btnUnmute;
        private Guna.UI2.WinForms.Guna2ImageButton btnMute;
        private Guna.UI2.WinForms.Guna2ImageButton btnReload;
    }
}