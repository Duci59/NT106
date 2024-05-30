using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using LTMCB.env;
using LTMCB.MaHoa;


namespace LTMCB.Forms
{
    public partial class Login : Form
    {
        private int CheckDK = 0;
        string username, password, usertype, displayName, email;
        public Login()
        {
            InitializeComponent();
            this.MakeDraggable();
            this.KeyPreview = true; // Cho phép form nhận sự kiện phím trước khi chuyển cho điều khiển có focus
            this.KeyDown += new KeyEventHandler(bt_login_KeyDown); // Đăng ký sự kiện KeyDown
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty(tb_pass.Text))
            {
                MessageBox.Show("Please enter both username and password.");
            }
            else
            {
                username = tb_name.Text.Trim();
                password = tb_pass.Text.Trim();
                string yeuCau = "DangNhap~" + username + "~" + password.MaHoa();
                string ketQua = Result.Instance.Request(yeuCau);
                if (String.IsNullOrEmpty(ketQua))
                {
                    MessageBox.Show("Máy chủ không phản hồi");
                }
                else if (ketQua.Contains("success"))
                {
                    displayName = (ketQua.Split('~')[2]).GiaiMa();
                    email = (ketQua.Split('~')[3]).GiaiMa();
                    usertype = (ketQua.Split('~')[4]).GiaiMa();
                    MessageBox.Show("Đăng nhập thành công");
                    this.Hide();
                    MainMenu menu = new MainMenu(username, displayName, usertype,email);
                    menu.Show();
                }
                else if (ketQua == "Password didn't match")
                {
                    lb_error.Text = "Mật khẩu không khớp";
                    lb_error.Visible = true;
                }
                else if (ketQua == "User doesn't exist")
                {
                    lb_error.Text = "Người dùng không tốn tại";
                    lb_error.Visible = true;
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

        private void bt_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_login_Click(sender, e);
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
