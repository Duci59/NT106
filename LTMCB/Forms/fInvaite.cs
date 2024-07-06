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
using System.Xml.Linq;

namespace LTMCB.Forms
{
    public partial class fInvaite : Form
    {
        string grname;
        public fInvaite(string gn)
        {
            grname = gn;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Trim() == "") MessageBox.Show("Vui lòng nhập usernam");
            //Yc = [MoiVaoNhom] ~ username ~ tên nhóm
            string kq = Result.Instance.Request("MoiVaoNhom ~" + tbUsername.Text + "~" + grname);
            if (kq == "TC")
            {
                MessageBox.Show("Mời thành công");
            }
            else
            {
                MessageBox.Show("Kiểm tra lại Username");
            }
        }

        private void fInvaite_Load(object sender, EventArgs e)
        {
            tbUsername.Focus();
            tbUsername.GotFocus += TbUsername_GotFocus;
            tbUsername.LostFocus += TbUsername_LostFocus;
        }

        private void TbUsername_LostFocus(object sender, EventArgs e)
        {
            if (tbUsername.Text.Length > 0)
                label1.Visible = false;
            else
                label1.Visible = true;
        }

        private void TbUsername_GotFocus(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
