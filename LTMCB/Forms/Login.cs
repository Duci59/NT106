using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using LTMCB.env;

namespace LTMCB.Forms
{
    public partial class Login : Form
    {
        private int CheckDK = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty(tb_pass.Text))
            {
                MessageBox.Show("Please enter both username and password.");
            }
            else
            {
                string username = tb_name.Text.Trim();
                string password = tb_pass.Text.Trim();
                string yeuCau = "DangNhap~" + username + "~" + password;
                string ketQua = Result.Instance.Request(yeuCau);
                if (String.IsNullOrEmpty(ketQua))
                {
                    MessageBox.Show("Máy chủ không phản hồi");
                }
                else if (ketQua == "Login successfully")
                {
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    MainMenu menu = new MainMenu();
                    menu.Show();
                }
                else if (ketQua == "Password didn't match")
                {
                    MessageBox.Show("Mật khẩu không khớp");
                }
                else if (ketQua == "User doesn't exist")
                {
                    MessageBox.Show("Người dùng không tốn tại");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn đóng ứng dụng?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btnMaxsize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void l_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Forms.FormDangKy dki = new FormDangKy();
            dki.ShowDialog();
            CheckDK = dki.CheckDK;
            if (CheckDK == 0)
            {
                this.Show();
            }
        }

        private void l_forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Forms.FormQuenMatKhau qmk = new FormQuenMatKhau();
            qmk.ShowDialog();
            this.Show();
        }

        private void showpassbtn_Click(object sender, EventArgs e)
        {
            if (tb_pass.PasswordChar == '●')
            {
                hidepassbtn.BringToFront();
                tb_pass.PasswordChar = '\0';
            }
        }

        private void hidepassbtn_Click_1(object sender, EventArgs e)
        {
            if (tb_pass.PasswordChar == '\0')
            {
                showpassbtn.BringToFront();
                tb_pass.PasswordChar = '●';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
