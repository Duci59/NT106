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
    public partial class FormInfo : Form
    {
        public FormInfo(string username)
        {
            InitializeComponent();
            this.MakeDraggable();
            string yeucau = "GetInfoAccount~" + username;
            string ketqua = Result.Instance.Request(yeucau);
            if (String.IsNullOrEmpty(ketqua))
            {
                MessageBox.Show("Máy chủ không phản hồi.");
                return;
            }
            else
            {
                tbusername.Text = ketqua.Split('~')[1];
                tbdisplayname.Text = ketqua.Split('~')[2];
                tbemail.Text = ketqua.Split('~')[3];
                tbtype.Text = ketqua.Split('~')[4];
            }
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
