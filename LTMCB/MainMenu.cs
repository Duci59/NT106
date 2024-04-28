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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Forms.TrangChu trangChu = new Forms.TrangChu();
            trangChu.TopLevel = false;
            panelDesktop.Controls.Add(trangChu);    
            trangChu.BringToFront();
            trangChu.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Forms.FormChat chu = new Forms.FormChat();
            chu.TopLevel = false;
            panelDesktop.Controls.Add(chu);
            chu.BringToFront();
            chu.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Forms.QLFile qLFile = new Forms.QLFile();
            qLFile.TopLevel = false;
            panelDesktop.Controls.Add((qLFile));
            qLFile.BringToFront();
            qLFile.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Forms.GopY gopY = new Forms.GopY();
            gopY.TopLevel = false;
            panelDesktop.Controls.Add((gopY));
            gopY.BringToFront();
            gopY.Show();
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

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Forms.QLFile qLFile = new Forms.QLFile();
            qLFile.Show();
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {

        }
    }
}
