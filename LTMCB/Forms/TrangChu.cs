using LTMCB.env;
using LTMCB.MaHoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LTMCB.Forms
{
    public partial class TrangChu : Form
    {
        private int panelresetopen = 0;
        private string username, displayname, email;
        public TrangChu(string tusername, string Displayname, string Email)
        {
            InitializeComponent();
            this.MakeDraggable();
            username = tusername;
            displayname = Displayname;
            email = Email;
        }

        private void btDoiPass_Click(object sender, EventArgs e)
        {
            if (panelresetopen == 0)
            {
                panelDoiPass.Visible = true;
                panelresetopen = 1;
            }
                
            else
            {
                panelresetopen = 0;
                panelDoiPass.Visible = false;
            }
        }

        private async void btEditDisplayname_Click(object sender, EventArgs e)
        {
            if (tbDisplayname.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên cần thay đổi", "Thông báo");
                return;
            }
            else if (tbDisplayname.Text == displayname)
            {
                MessageBox.Show("Tên thay đổi không được trùng với tên cũ", "Thông báo");
                return;
            }
            string yeuCau = "ResetDisplayName~" + username.MaHoa() + '~' + tbDisplayname.Text;
            string ketQua = await Task.Run(()=> Result.Instance.Request(yeuCau));
            if (String.IsNullOrEmpty(ketQua))
            {
                MessageBox.Show("Máy chủ không phản hồi");
            }
            else if (ketQua == "OK")
            {
                MessageBox.Show("Đổi tên hiển thị thành công.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private async void btConfirmChangePass_Click(object sender, EventArgs e)
        {
            string yeuCau = "GetPasswordWithUserName~" + username;
            string ketQua = await Task.Run(() => Result.Instance.Request(yeuCau));
            if (String.IsNullOrEmpty(ketQua))
            {
                MessageBox.Show("Máy chủ không phản hồi");
            }   
            else if (ketQua ==(tbOldPass.Text).MaHoaMotChieu())
            {
                if (tbNewPass.Text != tbNewPass2.Text)
                {
                    MessageBox.Show("Mật khẩu không trùng khớp, thử lại");
                    tbNewPass2.Focus();
                    return;
                }
                yeuCau = "RestPass~" + email + '~' + (tbNewPass.Text).MaHoa();
                ketQua = await Task.Run(()=> Result.Instance.Request(yeuCau));
                if (String.IsNullOrEmpty(ketQua))
                {
                    MessageBox.Show("Máy chủ không phản hồi");
                }
                else if (ketQua == "OK")
                {
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu");
            }

        }
    }
}
