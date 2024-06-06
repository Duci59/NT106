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

namespace LTMCB.Forms
{
    public partial class FormInfo : Form
    {
        string userName;
        public FormInfo(string username)
        {
            InitializeComponent();
            this.MakeDraggable();
            userName = username;
        }

        private async void FormInfo_Load(object sender, EventArgs e)
        {
            string yeucau = "GetInfoAccount~" + userName.MaHoa();
            string ketqua = await Task.Run(() => Result.Instance.Request(yeucau));
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
