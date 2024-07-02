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
    public partial class ResetPass : Form
    {
        string yeuCau, ketQua, Email;
        public ResetPass()
        {
            InitializeComponent();
            this.MakeDraggable();
        }

        private void ResetPass_Load(object sender, EventArgs e)
        {
        }

        public ResetPass(string email)
        {
            InitializeComponent();
            this.MakeDraggable();
            Email = email;
        }

        private void HienLoi(string errormess, Control control)
        {
            lb_errormes.Text = errormess;
            lb_errormes.Visible = true;
            control.Focus();
        }

        private void tbNLMK_TextChanged(object sender, EventArgs e)
        {

        }

        private async void bt_login_Click(object sender, EventArgs e)
        {
            if (tbMK.Text != tbNLMK.Text)
            {
                HienLoi("Mật khẩu không giống nhau", tbNLMK);
                tbNLMK.Text = "";
                return;
            }
            yeuCau = "RestPass~" + Email + '~' + (tbMK.Text).MaHoa();
            ketQua = await Task.Run(()=> Result.Instance.Request(yeuCau));
            if (String.IsNullOrEmpty(ketQua))
            {
                MessageBox.Show("Máy chủ không phản hồi");
            }
            else if (ketQua == "OK")
            {
                lb_errormes.Text = "";
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
