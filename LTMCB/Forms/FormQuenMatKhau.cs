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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        private async void ntTimkiem_Click(object sender, EventArgs e)
        {
            //CheckTK ~ email
            string yeuCau = "CheckEmail~" + tbFind.Text;
            string ketQua = await Task.Run(()=> Result.Instance.Request(yeuCau));

            if (string.IsNullOrEmpty(ketQua))
            {
                MessageBox.Show("Máy chủ không phản hồi");
            }
            else if (ketQua == "Email exist")
            {
                this.Hide();
                Forms.FormXacNhanDK otpreset = new FormXacNhanDK(tbFind.Text);
                otpreset.ShowDialog();

            }
            else if (ketQua == "Email doesn't")
            {
                errorlb.Text = "Email không tồn tại";
                errorlb.Visible = true;
            }
            else
            {
                MessageBox.Show("Error");
            }
            
        }
    }
}
