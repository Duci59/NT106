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
    public partial class FormDangKy : Form
    {
        public int CheckDK = 0;// check để tự đăng nhập
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void HienLoi (string errormess, Control control)
        {
            errorlb.Text = errormess;
            errorlb.Visible = true;
            control.Focus();
        }

        private bool IsValidEmail (string email) 
        { 
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email; 
            }
            catch 
            {
                return false;
            }
        }

        private void Dangkybtn_Click(object sender, EventArgs e)
        {

            if (tbTDN.Text.Trim()== "" || tbTHT.Text.Trim() == "" || tbMK.Text.Trim() == "")
            {
                if (tbTDN.Text.Trim() == "")
                    HienLoi("Nhập đủ thông tin!",tbTDN);
                else if (tbTHT.Text.Trim() == "")
                    HienLoi("Nhập đủ thông tin!", tbTHT);
                else if (tbMK.Text.Trim() == "")
                    HienLoi("Nhập đủ thông tin!", tbMK);
                else
                    HienLoi("Nhập đủ thông tin!", null);
            }
            else if (tbTDN.Text.Contains("~") || tbTDN.Text.Contains("^") || tbTDN.Text.Contains(" "))
            {
                HienLoi("Tên đăng nhập không chứa các kí tự ^, ~, .", tbTDN);
                tbTDN.Text = "";
            }
            else if (tbMK.Text != tbNLMK.Text)
            {
                HienLoi("Mật khẩu không giống nhau", tbNLMK);
                tbNLMK.Text = "";
            }

            else if (!IsValidEmail(tbDK.Text.Trim()))
            {
                HienLoi("Địa chỉ Email không hợp lệ", tbDK);
            }
            else
            {
                errorlb.Visible = false;
            }
        }
    }
    
}
