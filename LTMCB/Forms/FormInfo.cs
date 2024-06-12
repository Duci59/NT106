using LTMCB.env;
using LTMCB.MaHoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
                tbusername.Text = ketqua.Split('~')[1].GiaiMa();
                tbdisplayname.Text = ketqua.Split('~')[2].GiaiMa();
                tbemail.Text = ketqua.Split('~')[3].GiaiMa();
                tbtype.Text = ketqua.Split('~')[4].GiaiMa();
                string avatarBase64 = ketqua.Split('~')[5].GiaiMa();
                byte[] b = Convert.FromBase64String(avatarBase64);
                MemoryStream ms = new MemoryStream();
                ms.Write(b, 0, Convert.ToInt32(b.Length));

                Bitmap bm = new Bitmap(ms, false);
                ms.Dispose();
                Bitmap resizedImage = new Bitmap(151, 131);
                using (Graphics g = Graphics.FromImage(resizedImage))
                {
                    g.DrawImage(bm, 0, 0, 151, 131);
                }
                pbAvt.Image = resizedImage;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnChangeAvt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn hình đại diện";
            ofd.Filter = "Image files(*.jpg) | *.jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);
                pbAvt.Image = img.GetThumbnailImage(151, 131, null, new IntPtr());
                if (MessageBox.Show("Bạn có muốn thay đổi hình đại diện không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MemoryStream ms = new MemoryStream();
                    pbAvt.Image.Save(ms, ImageFormat.Png);
                    byte[] imageBytes = ms.ToArray();
                    string output = Convert.ToBase64String(imageBytes);

                    string yeucau = "ResetAvatar~" + userName.MaHoa() + "~" + output.MaHoa();
                    string ketqua = await Task.Run(() => Result.Instance.Request(yeucau));
                }
            }
        }
    }
}
