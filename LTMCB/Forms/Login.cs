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

namespace LTMCB.Forms
{
    public partial class Login : Form
    {
        IFirebaseClient client;
        public Login()
        {
            InitializeComponent();
            btnMaxsize.Enabled = false;
            try
            {
                IFirebaseConfig config = new FirebaseConfig
                {
                    AuthSecret = "2tMZTGQor4g76nxOQQt93sWgDMmaGgcGddStX13k", // Replace with your Firebase Auth Secret
                    BasePath = "https://chatandload-default-rtdb.firebaseio.com/" // Replace with your Firebase Database URL
                };

                client = new FireSharp.FirebaseClient(config);

                if (client != null)
                {
                    this.CenterToScreen();
                    
                    this.WindowState = FormWindowState.Normal;
                }
            }
            catch
            {
                MessageBox.Show("Connection Fail.");
            }

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_name.Text) || string.IsNullOrEmpty(tb_pass.Text))
            {
                MessageBox.Show("Please enter both username and password.");
            }
            else
            {
                //Looping to get the match data using foreach
                FirebaseResponse response = client.Get("Users/");
                Dictionary<string, register> result = response.ResultAs<Dictionary<string, register>>();

                foreach (var get in result)
                {
                    string userresult = get.Value.username;
                    string passresult = get.Value.password;

                    if (tb_name.Text == userresult)
                    {

                        if (tb_pass.Text == passresult)
                        {
                            MessageBox.Show("Đăng nhập thành công", "Thông Báo");
                            this.Hide();
                            MainMenu menu = new MainMenu(); 
                            menu.Show();
                        }

                    }
                }
            }
        }
        public class register
        {
            public string username { get; set; }
            public string password { get; set; }
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
            this.Show();
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
    }
}
