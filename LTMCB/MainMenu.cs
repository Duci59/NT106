﻿using LTMCB.env;
using LTMCB.MaHoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTMCB
{
    public partial class MainMenu : Form
    {
        string sHello;

        readonly string Key;
        readonly string Username;
        public readonly string Displayname;
        readonly string email;
        private readonly string type;

        private Form activeForm;

        public MainMenu(string username, string displayname, string utype, string mail)
        {
            InitializeComponent();
            Username = username;
            Displayname = displayname;
            type = utype;
            email = mail;
            lblTitle.Text = "Chào " + displayname;
             
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.TrangChu(Username, Displayname, email), sender);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormChat(Username, Key), sender);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.QLFile(), sender);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.GopY(), sender);
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaxsize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private async void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            panelDesktop.Controls.Clear();
            string yeucau = "GetInfoAccount~" + Username.MaHoa();
            string ketqua = await Task.Run(() => Result.Instance.Request(yeucau));
            lblTitle.Text = "Chào " + ketqua.Split('~')[2];
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Forms.Login login = new Forms.Login();
            login.Show();
        }
        #region dragation
        Point offset = Point.Empty;
        bool isDragging = false;
        private void guna2Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newLocation = this.PointToScreen(new Point(e.X, e.Y));
                newLocation.Offset(-offset.X, -offset.Y);
                this.Location = newLocation;
            }
        }

        private void guna2Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void guna2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                offset = new Point(e.X, e.Y);
                isDragging = true;
            }
        }
        #endregion

        private void infobtn_Click(object sender, EventArgs e)
        {
            Forms.FormInfo finfo = new Forms.FormInfo(Username);
            finfo.Show();
        }
    }
}
