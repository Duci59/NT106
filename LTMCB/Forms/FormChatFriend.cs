using Guna.UI2.WinForms;
using LTMCB.env;
using LTMCB.MaHoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Collections.Concurrent;
using Org.BouncyCastle.Asn1.Cms;

namespace LTMCB.Forms
{
    public partial class FormChatFriend : Form
    {
        #region Fields
        private Thread listenThread;
        private bool listening = true;

        private bool active = false;
        private string idmsg;
        private string result_tinnhanMoi, result_tinnhanThuHoi, result_slMem, result_tinnhancu;
        private Stack<Guna2Button> stackMess = new Stack<Guna2Button>();
        private Guna2Button gunabutton;
        Guna2Panel pnChangePass;
        Guna2TextBox tbChangePass;
        private readonly string username;
        private readonly string otheruser;

        int y_max;
        private string nguoinhancuoi = "";
        readonly List<string> listUsMember = new List<string>();
        int y;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        public FormChatFriend(string Username, string Otheruser)
        {
            InitializeComponent();
            this.MakeDraggable();
            username = Username;
            otheruser = Otheruser;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            Control.CheckForIllegalCrossThreadCalls = false;


            listenThread = new Thread(ListenForMessages);
            listenThread.IsBackground = true;
            listenThread.Start();
            this.FormClosing += FormChatClient_FormClosing;
            LoadFriendDisplay();
        }

        private void FormChatClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            listening = false; // Dừng vòng lặp trong ListenForMessages
            if (listenThread != null && listenThread.IsAlive)
            {
                listenThread.Join(); // Chờ thread hoàn thành
            }
        }

        private async void FormChatClient_Load_1(object sender, EventArgs e)
        {
            // Thiết lập các thành phần giao diện cơ bản
            InitializeComponents();
            
            // Tải dữ liệu mà không làm gián đoạn giao diện người dùng
            await Task.Run(async () =>
            {
                await LoadOldMessAsync();
            });

            // Hiển thị form sau khi đã tải xong tất cả dữ liệu
            this.Show();
            
        }

        private void InitializeComponents()
        {
            // Các cài đặt thành phần giao diện
            pnChangePass = new Guna2Panel
            {
                Height = 0,
                Width = 140,
                FillColor = Color.AliceBlue,
                BackColor = Color.FromArgb(61, 61, 86),
                BorderRadius = 10,
                Anchor = (AnchorStyles.Top | AnchorStyles.Right)
            };

            tbChangePass = new Guna2TextBox
            {
                Height = 20,
                Width = 100,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                ForeColor = Color.Black,
                FillColor = Color.AliceBlue,
                Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material,
                BackColor = Color.FromArgb(61, 61, 86),
                BorderRadius = 10,
                Anchor = (AnchorStyles.Top | AnchorStyles.Right)
            };

            // Các cài đặt sự kiện và tooltips
            tbNoiDung.Focus();
            tbNoiDung.GotFocus += TbNoiDung_GotFocus;
            tbNoiDung.LostFocus += TbNoiDung_LostFocus;
            pnLichSu.ControlAdded += PnLichSu_ControlAdded;
        }


        private void PnLichSu_ControlAdded(object sender, ControlEventArgs e)
        {
            pnLichSu.ScrollControlIntoView(e.Control); //Tự động sroll xuống dưới cùng của tin nhắn
        }
        private void TbNoiDung_LostFocus(object sender, EventArgs e)
        {
            if (tbNoiDung.Text.Length > 0)
                lbStt.Visible = false;
            else
                lbStt.Visible = true;
        }
        private void TbNoiDung_GotFocus(object sender, EventArgs e)
        {
            lbStt.Visible = false;
        }

      

        private void lbStt_Click(object sender, EventArgs e)
        {
            tbNoiDung.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private async Task LoadOldMessAsync()
        {
            string yeucau = "OldFriendMess~" + username + "~" + otheruser;
            string result_tinnhancu = await Task.Run(() => Result.Instance.Request(yeucau));

            if (!string.IsNullOrEmpty(result_tinnhancu) && result_tinnhancu != "NULL")
            {
                List<String> dsTinNhanCu = result_tinnhancu.Split('^').ToList();
                List<Guna2Button> buttons = new List<Guna2Button>();

                foreach (var item in dsTinNhanCu)
                {
                    buttons.Add(new Guna2Button() { AutoSize = true, Tag = item });
                }

                // Thêm các button vào panel
                this.Invoke((Action)(() =>
                {
                    foreach (Guna2Button btn in buttons)
                    {
                        string[] tagParts = btn.Tag.ToString().Split('~');
                        string usgui = tagParts[3];
                        string usnhan = tagParts[4];

                        AddMess(btn, usgui, usnhan);

                        if (tagParts[6] == "Thu Hồi")
                        {
                            DelMess(btn);
                        }
                    }

                    pnLichSu.VerticalScroll.Value = pnLichSu.VerticalScroll.Maximum;
                    nguoinhancuoi = dsTinNhanCu.Last().Split('~')[3];
                }));
            }
        }



        private void ListenForMessages()
        {
            while (listening)
            {
                try
                {

                    // Kiểm tra tin nhắn mới
                    result_tinnhanThuHoi = Result.Instance.Request("NewMessFriendDel~" + username + "~" + otheruser);
                    if (String.IsNullOrEmpty(result_tinnhanThuHoi))
                    {
                        MessageBox.Show("Mất kết nối máy chủ");
                        listening = false;
                    }
                    else if (result_tinnhanThuHoi == "NotInGr")
                    {
                        this.Close();
                        MessageBox.Show("Nhóm đã bị xóa");
                        listening = false;
                    }
                    else
                    {
                        if (result_tinnhanThuHoi != "NULL")
                        {
                            List<String> dsTinNhan_Del = result_tinnhanThuHoi.Split('^').ToList();
                            this.Invoke(new Action(() =>
                            {
                                foreach (Control btns in pnLichSu.Controls)
                                {
                                    if (btns.GetType() == typeof(Guna2Button))
                                    {
                                        Guna2Button btn = (Guna2Button)btns;
                                        if (dsTinNhan_Del.Contains((btn.Tag as string).Split('~')[5]))
                                        {
                                            DelMess(btn);
                                        }
                                    }
                                }
                            }));
                        }
                    }

                    // Kiểm tra tin nhắn mới
                    result_tinnhanMoi = Result.Instance.Request("NewMessFriend~" + username + "~" + otheruser);

                    if (!string.IsNullOrEmpty(result_tinnhanMoi) && result_tinnhanMoi != "NULL"
                        && result_tinnhanMoi != "NotInGr")
                    {
                        List<String> dsTinNhan = result_tinnhanMoi.Split('^').ToList();
                        for (int i = 0; i < dsTinNhan.Count; i++)
                        {
                            this.Invoke(new Action(() =>
                            {
                                pnLichSu.VerticalScroll.Value = pnLichSu.VerticalScroll.Maximum;
                                Guna2Button btn = new Guna2Button() { AutoSize = true };
                                btn.Tag = dsTinNhan[i];
                                AddMess(btn, dsTinNhan[i].Split('~')[3], dsTinNhan[i].Split('~')[4]);
                                nguoinhancuoi = dsTinNhan[i].Split('~')[3];
                                if ((btn.Tag as string).Split('~')[6] == "Thu Hồi")
                                {
                                    DelMess(btn);
                                }
                            }));
                        }
                        nguoinhancuoi = dsTinNhan[dsTinNhan.Count - 1].Split('~')[3];
                    }
                }
                catch (Exception ex)
                {
                    //Handle exceptions
                    Console.WriteLine("Exception: " + ex.Message);
                }

                // Thời gian chờ giữa các lần kiểm tra
                Thread.Sleep(500); // 0.5 giây
            }
        }




        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Yc Gửi tin nhắn = [SendMTFriend] ~ username ~ otheruser ~ noidung
            if (tbNoiDung.Text.Trim() == "")
            {
                return;
            }
            else
            {
                string yeucau = "SendMTFriend~" + username + "~" +
                    otheruser + "~" + tbNoiDung.Text;
                string ketqua = Result.Instance.Request(yeucau);
                //"[DONE] ~ last_id;
                //------------------------
                Guna2Button btn = new Guna2Button() { AutoSize = true };
                if (string.IsNullOrEmpty(ketqua))//Tin nhắn không được gửi đi
                {
                    Bitmap warning = SystemIcons.Warning.ToBitmap();
                    btn.Image = warning;
                    btn.Tag = "null~" + tbNoiDung.Text + "~" + DateTime.Now;
                }
                else
                {
                    btn.Tag = "Bạn~" + tbNoiDung.Text + "~" + DateTime.Now + "~ ~ ~" + ketqua.Split('~')[1];
                }
                AddMess(btn);
                nguoinhancuoi = "you";
                pnLichSu.VerticalScroll.Value = pnLichSu.VerticalScroll.Maximum;//Sroll Max
                pnLichSu.Controls.Add(btn);
                tbNoiDung.Text = "";
                tbNoiDung.Focus();
            }
        }

        private void Btn_MouseClick(object sender, MouseEventArgs e)
        {
            y_max = pnLichSu.Height + 5;
            if (e.Button == MouseButtons.Left)//Ẩn tin nhắn
            {
                if ((sender as Guna2Button).Text == ((sender as Guna2Button).Tag as string).Split('~')[2])
                    active = true;
                else
                    active = false;

                if (active)
                    active = false;
                else
                {
                    active = true;
                }
                MsgButton(active, (sender as Guna2Button));
            }
            else if (e.Button == MouseButtons.Right) //Chuột phải là tùy chọn thu hồi tin nhắn
            {
                gunabutton = (Guna2Button)sender;
            }
        }//action Click mess

        private void Lb_stt_Click(object sender, EventArgs e)
        {
            pnLichSu.Controls.Clear();
            stackMess.Clear();
            LoadMess("full"); //Tải toàn bộ tin nhắn
        }

        private void DelMess_Click(object sender, EventArgs e)
        {

            idmsg = (gunabutton.Tag as string).Split('~')[5];


            DialogResult result = MessageBox.Show(
                $"Bạn có muốn thu hồi tin nhắn này",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Kiểm tra kết quả của hộp thoại xác nhận
            if (result == DialogResult.Yes)
            {
                // Gửi yêu cầu xóa tin nhắn tới máy chủ
                string kq = Result.Instance.Request("DellFriendMess~" + idmsg);

                // Kiểm tra kết quả trả về từ máy chủ
                if (!string.IsNullOrEmpty(kq) && kq == "DONE")
                    DelMess(gunabutton);
                else
                    MessageBox.Show("Đã có lỗi xảy ra từ máy chủ");
            }
        }

        public void LoadMess(string stt)
        {
            //Yc Gửi tin nhắn = [CheckMIGroup] ~ username ~ groupname
            //Trả lời : tên hiển thị + nội dung + time + username người gửi + username người yc + id_mess
            string ketqua;
            ketqua = Result.Instance.Request("CheckMIFriend~" + username + "~" + otheruser + "~" + stt);

            y_max = pnLichSu.Height + 5;
            if (ketqua != "NULL" && !string.IsNullOrEmpty(ketqua))
            {
                pnLichSu.Text = "";
                List<String> dsTinNhan = ketqua.Split('^').ToList();
                // dsTinNhan[0].Split('~')[4] -username cuả bản thân ở dạng mã hóa
                for (int i = 0; i < dsTinNhan.Count; i++)
                {
                    pnLichSu.VerticalScroll.Value = pnLichSu.VerticalScroll.Maximum;
                    //dsTinNhan[i].Split('~')[2]; - thời gian gửi
                    //dsTinNhan[i].Split('~')[3] -username người gửi ở dạng mã hóa
                    Guna2Button btn = new Guna2Button() { AutoSize = true };
                    btn.Tag = dsTinNhan[i];
                    if (i > 0)
                    {
                        nguoinhancuoi = dsTinNhan[i - 1].Split('~')[3];
                    }
                    else // chưa có người nhắn
                    {
                        nguoinhancuoi = "you";
                    }
                    AddMess(btn, dsTinNhan[i].Split('~')[3], dsTinNhan[0].Split('~')[4]);
                    if ((btn.Tag as string).Split('~')[6] == "Đã Bị Thu Hồi")
                    {
                        DelMess(btn);
                    }
                }
                nguoinhancuoi = dsTinNhan[dsTinNhan.Count - 1].Split('~')[3];
                if (dsTinNhan.Count == 8)
                {
                    Label lb_stt = new Label
                    {
                        Text = "Tải thêm tin",
                        Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Underline, GraphicsUnit.Point, ((byte)(0))), // gạch chân
                        Anchor = (AnchorStyles.Top),
                        ForeColor = Color.White,
                        Location = new Point(250, 0)
                    };
                    pnLichSu.Controls.Add(lb_stt);
                    lb_stt.Click += Lb_stt_Click;
                }
                if (nguoinhancuoi == dsTinNhan[0].Split('~')[4])
                {
                    nguoinhancuoi = "you";
                }
            }
            else
            {
                return;
            }
        }//Tải tin nhắn


        private void DelMess(Guna2Button btn)
        {
            btn.FillColor = Color.Gray;
            btn.MouseUp -= Btn_MouseClick;
            ContextMenuStrip cms = new ContextMenuStrip();
            btn.ContextMenuStrip = cms;
            btn.ContextMenuStrip.Dispose();
            btn.Text = "Tin nhắn đã bị thu hồi";
            int x;
            if (btn.Location.X != 5)
            {
                if (y + btn.Height >= y_max)
                {
                    x = pnLichSu.Width - btn.Size.Width - 20;
                }
                else
                    x = pnLichSu.Width - btn.Width - 5;
            }
            else
                x = 5;
            btn.Location = new Point(x, btn.Location.Y);
            btn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Italic, GraphicsUnit.Point, ((byte)(0)));
        }

        private void timerDellMess_Tick(object sender, EventArgs e)
        {
            foreach (Control btns in pnLichSu.Controls)
            {
                if (btns.GetType() == typeof(Guna2Button))
                {
                    Guna2Button btn = (Guna2Button)btns;
                    var timeCountdownDellMess = DateTime.Now - DateTime.Parse((btn.Tag as string).Split('~')[2]);
                    if (timeCountdownDellMess.Minutes >= 3 && btn.Location.X != 5)
                    {
                        ContextMenuStrip cms = new ContextMenuStrip();
                        btn.ContextMenuStrip = cms;
                        btn.ContextMenuStrip.Dispose();
                    }
                }
            }
        }

        private Label CauHinhMsgBt(ref Guna2Button btn)
        {
            //Cấu hình button
            ToolTip time = new ToolTip();
            string status;
            if ((btn.Tag as string).Split('~')[0] == "null")
            {
                status = "Gửi thất bại";
            }
            else
                status = $"Được gửi vào lúc: {(btn.Tag as string).Split('~')[2]}";
            time.SetToolTip(btn, status);
            btn.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            btn.BorderRadius = 10;
            btn.Text = ((btn.Tag as string).Split('~')[1]);
            Label lb = new Label() { AutoSize = true };
            lb.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lb.ForeColor = Color.Black;
            lb.Text = (btn.Tag as string).Split('~')[0];//Tên hiển thị
            return lb;
        }




        private void MsgButton(bool status, Guna2Button btn)
        {
            Label lbTime = new Label();
            int x = 5;

            btn.Invoke((MethodInvoker)delegate
            {
                if (status) //Hiển thị thời gian
                {
                    btn.Text = (btn.Tag as string).Split('~')[2];
                }
                else // Đóng hiển thị thời gian
                {
                    btn.Text = (btn.Tag as string).Split('~')[1];
                }
                if (btn.Location.X != 5 && y + btn.Height >= y_max)
                {
                    x = pnLichSu.Width - btn.Size.Width - 20;
                }
                else if (btn.Location.X != 5 && y + btn.Height < y_max)
                {
                    x = pnLichSu.Width - btn.Size.Width - 5;
                }
                btn.Location = new Point(x, btn.Location.Y);
            });
        }


        private void AddMess(Guna2Button btn, string usgui = "you", string usnhan = "you")
        {
            Label lb = CauHinhMsgBt(ref btn);
            //int x = pnLichSu.Width - btn.Size.Width - 20;
            y_max = pnLichSu.Height + 5;
            int y_lb;//Tọa độ Y lable
            int x = pnLichSu.Width - btn.Size.Width - 5;
            if (stackMess.Count == 0 && usgui != usnhan) //Xử lý y đầu tiên, nếu tin nhắn đầu tiên là của bản thân thì y=0
                y = btn.Height;
            //Tin nhắn đầu không phải của bản thân
            else if (stackMess.Count == 0 && usgui == usnhan)
            {
                y = 25;
            }
            else //stackMess khác 0
            {
                if (nguoinhancuoi == usgui)
                    y = (stackMess.Peek()).Location.Y + btn.Height + 5; //Không chèn lb
                                                                        //Đệm 1: y=0, đệm 2: y = y(1)+28 +5 = 33, đệm 3: y = y(3)+ 28 +5 = 46..
                else
                    y = (stackMess.Peek()).Location.Y + btn.Height + lb.Height;//Chèn lb
            }
            if (y + btn.Height - lb.Height > y_max)
            {
                y = y_max;
                x = pnLichSu.Width - btn.Size.Width - 20;
                y_lb = y_max;
            }
            else
            {
                y_lb = y - btn.Height + 10;//Tọa độ Y lable
            }
            if (usgui != usnhan) // Bên trái khung chat
            {
                if (nguoinhancuoi == usgui)//So sánh người nhắn trước đó và người ngắn cuối
                {
                    //cùng một người thì không cần hiện lb
                    btn.CustomizableEdges.BottomLeft = false;
                    btn.Location = new Point(5, y);
                }
                else //Hiện lb
                {
                    btn.CustomizableEdges.BottomLeft = false;
                    btn.Location = new Point(5, y);
                    lb.Location = new Point(5, y_lb);
                    pnLichSu.Controls.Add(lb);
                }
            }
            else //Tin nhắn của bản thân
            {
                btn.Location = new Point(x, y);
                btn.CustomizableEdges.BottomRight = false;
                btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
                ContextMenuStrip cms = new ContextMenuStrip();
                if ((btn.Tag as string).Split('~')[0] != "null")
                {
                    cms.Items.Add("Thu Hồi");
                    cms.Items[0].Click += DelMess_Click;
                    btn.ContextMenuStrip = cms;
                }
            }
            btn.MouseUp += Btn_MouseClick;
            pnLichSu.Controls.Add(btn);
            stackMess.Push(btn);
        }

        public void LoadFriendDisplay()
        {
            string yeucau = "LoadDisplayFriendName~" + otheruser;
            string ketqua = Result.Instance.Request(yeucau);
            if (ketqua != "NULL" && !string.IsNullOrEmpty(ketqua))
            {
                lbfriendname.Text = "Đang trò chuyện với " + ketqua;  
            }
            else
            {
                lbfriendname.Text = "Đang trò chuyện với " + otheruser;
            }
        }
    }
}
