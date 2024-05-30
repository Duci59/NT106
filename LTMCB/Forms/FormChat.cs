using Guna.UI2.WinForms;
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
    public partial class FormChat : Form
    {
        #region Field
        private string Username;
        private string sTenNhom;
        private readonly string Key;
        private string result;
        private int soluongGroup = 0;
        List<string> lsGroup = new List<string>();
        #endregion
        public FormChat(string us, string k)
        {
            Key = k;
            Username = us;
            InitializeComponent();
            this.MakeDraggable();
            this.DoubleBuffered = true;
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label4.ForeColor = ThemeColor.SecondaryColor;
            this.BackColor = Color.LightGray;
            ContextMenuStrip cms = new ContextMenuStrip();
            cms.Items.Add("Tạo nhóm");
            cms.Items[0].Click += btTaoNhomm_Click;
            cms.Items.Add("Tìm nhóm");
            cms.Items[1].Click += btTimNhom_Click;
            flowLayoutNhomChat.ContextMenuStrip = cms;
        }


        private void LoadingGroup()
        {
            flowLayoutNhomChat.Controls.Clear();
            LoadGroup(Username);
        }

        private void LoadGroup(string us)
        {
            string yeucau = "LoadGroup~" + us;
            string ketqua = Result.Instance.Request(yeucau);

            if (!String.IsNullOrEmpty(ketqua) && !ketqua.Equals("[NULL]"))
            {
                List<String> groupDataList = ketqua.Split('^').ToList();
                lsGroup.Clear(); // Xóa danh sách nhóm hiện có

                foreach (String item in groupDataList)
                {
                    string[] groupInfo = item.Split('~');

                    // Kiểm tra nếu thông tin nhóm không đầy đủ, bỏ qua và không tạo nút
                    if (groupInfo.Length < 2)
                        continue;

                    string tennhom = groupInfo[0];
                    string role = groupInfo.Length >= 3 ? groupInfo[2] : "";

                    // Tạo button mới cho mỗi nhóm
                    Button btn = new Button() { Width = 100, Height = 100 };
                    flowLayoutNhomChat.Controls.Add(btn); // Thêm button vào flowlayout

                    ContextMenuStrip cms = new ContextMenuStrip(); // Tạo ContextMenuStrip mới
                    btn.Tag = item; // Gán tag cho button
                    btn.MouseUp += Btn_MouseClick;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;

                    Guna2Elipse elip = new Guna2Elipse();
                    elip.BorderRadius = 30;
                    elip.SetElipse(btn);

                  
                    if (role == "truongnhom")
                    {
                        btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135))))); ;
                        btn.Text = tennhom + "\n\r(Nhóm của bạn)";
                        cms.Items.Add("Xóa nhóm");
                        cms.Items[0].Click += DelGroup_Click;
                        btn.ContextMenuStrip = cms;
                        toolTipGroup.SetToolTip(btn, "Nhấn chuột phải để chọn xóa nhóm");
                    }
                    else
                    {
                        btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(107)))), ((int)(((byte)(135))))); ;
                        btn.Text = tennhom;
                    }

                    btn.Click += (s, e) => {
                        Forms.Chat chatPage = new Forms.Chat(tennhom, Username);
                        chatPage.Show();
                    };

                    lsGroup.Add(tennhom);
                }

                soluongGroup = lsGroup.Count;
                lbStt.Text = "";
            }
            else
            {
                // Nếu không có nhóm nào được tải, thiết lập số lượng nhóm là 0
                soluongGroup = 0;
            }
        }


        private void DelGroup_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Nhóm sau khi xóa sẽ không thể phục hồi", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Yêu cầu xóa: DelGr ~ tên nhóm
                string yeucau = "DelGr~" + sTenNhom;
                _ = Result.Instance.Request(yeucau);
                LoadingGroup();
            }
            else
            {
                return;
            }
        }

        private void Btn_MouseClick(object sender, MouseEventArgs e)
        {
            string namegr = ((sender as Button).Tag as string).Split('~')[0];//Lấy tên nhóm
           
            if (e.Button == MouseButtons.Left)//Chuột trái là truy cập vào nhóm
            {
                
            }
            else if (e.Button == MouseButtons.Right) //Chuột phải là xóa hoặc rời nhóm
            {
                sTenNhom = namegr;
            }
        }//Mở nhóm




        private void flowLayoutNhomChat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormChat_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadingGroup();
        }

        private int previousGroupCount = 0;


        private void toolTipGroup_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btTaoNhomm_Click(object sender, EventArgs e)
        {
            string groupname = tbTenNhom.Text.Trim();
            string grouppass = tbMatKhau.Text.Trim();
            if (groupname == "" || grouppass == "")
            {
                MessageBox.Show("Bạn không được để trống tên và mật khẩu nhóm.");
                tbTenNhom.Focus();
            }
            else if (groupname.Contains("~") || groupname.Contains("^"))
            {
                MessageBox.Show("Tên nhóm chứa ký tự cấm sử dụng");
                tbTenNhom.Focus();
            }
            else
            {
                string yeucau = "TaoNhom~" + Username +
                    "~" + groupname +
                    "~" + grouppass.MaHoa();
                string ketqua = Result.Instance.Request(yeucau);
                if (ketqua == "DTT")
                {
                    MessageBox.Show("Nhóm đã tồn tại.");
                    tbTenNhom.Text = "";
                    tbMatKhau.Text = "";
                    tbTenNhom.Focus();
                    return;
                }
                else if (ketqua == "TC")
                {
                    MessageBox.Show("Tạo thành công.");
                    tbTenNhom.Text = "";
                    tbMatKhau.Text = "";

                    // Sau khi tạo thành công, cập nhật lại danh sách nhóm
                    LoadingGroup();
                }
                else
                {
                    MessageBox.Show("Mất kết nối, vui lòng thử lại");
                    return;
                }
            }
        }

        private void btTimNhom_Click(object sender, EventArgs e)
        {

        }
    }
}
