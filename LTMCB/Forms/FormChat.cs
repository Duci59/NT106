﻿using Guna.UI2.WinForms;
using LTMCB.env;
using LTMCB.MaHoa;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            _ = LoadGroupAsync(Username); // Bắt đầu phương thức không đồng bộ
        }

        private async Task LoadGroupAsync(string us)
        {
            string yeucau = "LoadGroup~" + us;
            string ketqua = await Task.Run(() => Result.Instance.Request(yeucau)); // Sử dụng Task.Run để gọi phương thức đồng bộ một cách không đồng bộ

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
                    elip.BorderRadius = 20;
                    elip.SetElipse(btn);

                    if (role == "truongnhom")
                    {
                        btn.BackColor = Color.LightSkyBlue;
                        btn.Text = tennhom + "\n\r(Nhóm của bạn)";
                        btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        cms.Items.Add("Xóa nhóm");
                        cms.Items[0].Click += DelGroup_Click;
                        btn.ContextMenuStrip = cms;
                        toolTipGroup.SetToolTip(btn, "Nhấn chuột phải để chọn xóa nhóm");
                    }
                    else
                    {
                        btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        btn.BackColor = Color.LightSkyBlue;
                        btn.Text = tennhom;
                        cms.Items.Add("Rời nhóm");
                        cms.Items[0].Click += LeaveGroup_Click;
                        btn.ContextMenuStrip = cms;
                        toolTipGroup.SetToolTip(btn, "Nhấn chuột phải để chọn rời nhóm");
                    }


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

        private async void DelGroup_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Nhóm sau khi xóa sẽ không thể phục hồi", "Cảnh báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Yêu cầu xóa: DelGr ~ tên nhóm
                string yeucau = "DelGr~" + sTenNhom;
                _ = Task.Run(() => Result.Instance.Request(yeucau)); // Thực hiện yêu cầu xóa nhóm không đồng bộ
                LoadingGroup();
            }
            else
            {
                return;
            }
        }

        private async void LeaveGroup_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn rời khỏi nhóm?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string yeucau = "LeaveGroup~" + Username + "~" + sTenNhom;
                string ketqua = await Task.Run(() => Result.Instance.Request(yeucau)); // Thực hiện yêu cầu rời nhóm không đồng bộ và chờ kết quả
                if (ketqua == "Left group successfully")
                {
                    MessageBox.Show("Rời nhóm thành công");
                    LoadingGroup(); // Cập nhật lại danh sách nhóm sau khi rời nhóm thành công
                }
                else if (ketqua == "Failed to leave group")
                {
                    MessageBox.Show("Rời nhóm thất bại");
                }
                else
                {
                    MessageBox.Show("Mất kết nối, vui lòng thử lại");
                }
            }
            else
            {
                return;
            }
        }


        private void Btn_MouseClick(object sender, MouseEventArgs e)
        {
            string namegr = ((sender as Button).Tag as string).Split('~')[0]; // Lấy tên nhóm
            string chucvu = ((sender as Button).Tag as string).Split('~')[2];
            if (e.Button == MouseButtons.Left) // Chuột trái là truy cập vào nhóm
            {
                if (chucvu == "truongnhom")
                {
                    string passnhom = ((sender as Button).Tag as string).Split('~')[3];
                    FormChatClient groupAd = new FormChatClient(namegr, Username, passnhom, Key);
                    groupAd.Show();
                }
                else
                {
                    Chat groupMem = new Chat(namegr, Username);
                    groupMem.Show();
                }
            }
            else if (e.Button == MouseButtons.Right) // Chuột phải là xóa hoặc rời nhóm
            {
                sTenNhom = namegr;
            }
        } // Mở nhóm

        private void flowLayoutNhomChat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormChat_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadingGroup();
        }

        private void toolTipGroup_Popup(object sender, PopupEventArgs e)
        {

        }

        private async void btTaoNhomm_Click(object sender, EventArgs e)
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
                string ketqua = await Task.Run(() => Result.Instance.Request(yeucau)); // Thực hiện yêu cầu tạo nhóm không đồng bộ và chờ kết quả
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

        private async void btTimNhom_Click(object sender, EventArgs e)
        {
            string groupname = tbTenNhom.Text.Trim();
            string password = tbMatKhau.Text.Trim();
            if (groupname == "" || password == "")
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
                string yeucau = "ThamGiaNhom~" + Username + "~" + groupname + "~" + password.MaHoa();
                string ketqua = await Task.Run(() => Result.Instance.Request(yeucau)); // Thực hiện yêu cầu tham gia nhóm không đồng bộ và chờ kết quả
                if (ketqua == "Joined successfully")
                {
                    MessageBox.Show("Gia nhập thành công");
                    tbTenNhom.Text = "";
                    tbMatKhau.Text = "";

                    // Sau khi tạo thành công, cập nhật lại danh sách nhóm
                    LoadingGroup();
                }
                else if (ketqua == "Invalid group name or password")
                {
                    MessageBox.Show("Nhóm không tồn tại hoặc nhập sai mật khẩu!");
                }
                else
                {
                    MessageBox.Show("Mất kết nối, vui lòng thử lại");
                    return;
                }
            }
        }
    }
}
