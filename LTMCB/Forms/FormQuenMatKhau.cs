using LTMCB.env;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTMCB.Forms
{
    public partial class FormQuenMatKhau : Form
    {
        public FormQuenMatKhau()
        {   
            InitializeComponent();
            this.MakeDraggable();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ntTimkiem_Click(object sender, EventArgs e)
        {
            //CheckTK ~ email
            string yeuCau = "CheckEmail~" + tbFind.Text;
            string ketQua = Result.Instance.Request(yeuCau);

            if (string.IsNullOrEmpty(ketQua))
            {
                MessageBox.Show("Máy chủ không phản hồi");
            }
            else if (ketQua == "OK")
            {

            }
            Forms.OTPResetPass oTPResetPass = new Forms.OTPResetPass();
            oTPResetPass.Show();
        }
    }
}
