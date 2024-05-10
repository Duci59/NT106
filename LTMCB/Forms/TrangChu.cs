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
    public partial class TrangChu : Form
    {
        private int panelresetopen = 0;
        private string username;
        public TrangChu(string tusername)
        {
            InitializeComponent();
            this.MakeDraggable();
            username = tusername;
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

        private void btEditDisplayname_Click(object sender, EventArgs e)
        {
            if (tbDisplayname.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên cần thay đổi", "Thông báo");
                return;
            }
            string yeuCau = "ResetDisplayName~" + username + '~' + tbDisplayname.Text;
            string ketQua = Result.Instance.Request(yeuCau);
            if (String.IsNullOrEmpty(ketQua))
            {
                MessageBox.Show("Máy chủ không phản hồi");
            }
            else if (ketQua == "OK")
            {
                MessageBox.Show("Đổi tên hiển thị thành công");
                this.Close();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
