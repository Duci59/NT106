using LTMCB.env;
using LTMCB.MaHoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LTMCB.Forms
{
    public partial class FormXacNhanDK : Form
    {
        System.Threading.Thread loadingcode;
        string sCode;//Mã xác thực email (random 4 chữ số)
        int nCountDown = 61; // Set thời gian chờ là 61 => khi bắt đầu đếm ngược sẽ đếm từ 60
        int nTimeLate = 61;//Thời gian hiệu lực của code
        private readonly Timer aTimerDelayButton;
        private Timer aTimerCountDown;
        public int nCheckdk = 0;
        public int which = 0;

        private string Username = "";
        private string DisplayName = "";
        private string Email = "" ;
        private string Password = "" ;
        private string Usertype = "";

        public FormXacNhanDK()
        {
            InitializeComponent();
            this.MakeDraggable();
        }

        public FormXacNhanDK(string username, string displayName, string email, string password, string usertype)
        {
            InitializeComponent();
            this.MakeDraggable();
            tbCode.Focus();
            timeCountdownCode.Start();
            aTimerDelayButton = new Timer();
            aTimerCountDown = new Timer();
            aTimerDelayButton.Tick += aTimerDelayButton_Tick;
            aTimerCountDown.Tick += aTimerCountDown_Tick;
            Username = username;
            DisplayName = displayName;
            Email = email;
            Password = password;
            Usertype = usertype;
            SendCode();
        }

        public FormXacNhanDK(string email)
        {
            InitializeComponent();
            this.MakeDraggable();
            tbCode.Focus();
            timeCountdownCode.Start();
            aTimerDelayButton = new Timer();
            aTimerCountDown = new Timer();
            aTimerDelayButton.Tick += aTimerDelayButton_Tick;
            aTimerCountDown.Tick += aTimerCountDown_Tick;
            Email = email;
            which = 1;
            SendCode();
        }


        private void aTimerDelayButton_Tick(object sender, EventArgs e)
        {
            btSendAgain.Enabled = true;
            aTimerDelayButton.Stop();
        }

        private void aTimerCountDown_Tick(object sender, EventArgs e)
        {
            nCountDown--;
            lbDemNguoc.Text = "Thử lại sau: " + nCountDown.ToString();
            if (nCountDown == -1) // Set là -1 để label chạy được đến 0 rồi mới kết thúc
            {
                lbDemNguoc.Text = "";
                aTimerCountDown.Stop();
                nCountDown = 61; // Đặt lại thời gian đếm ngược
            }
        }//Đếm ngược thời gian chờ button

        void WaitButton()
        {
            aTimerCountDown.Interval = 1000;
            aTimerCountDown.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSendAgain_Click(object sender, EventArgs e)
        {
            nTimeLate = 61;
            btSendAgain.Enabled = false;
            SendCode();
            tbCode.Text = "";
            tbCode.Focus();
            DelayButton(62000);// Set thời gian là 62s để chạy cùng với thời gian đếm ngược (61-0)
            WaitButton();
            timeCountdownCode.Start();
        }

        private void LoadingCode()
        {
            sCode = Result.Instance.Request("SendMail~" + Email);
            if (string.IsNullOrEmpty(sCode))
                MessageBox.Show("Máy chủ không phản hồi");
            loadingcode.Abort();
        }

        private void SendCode()
        {
            loadingcode = new System.Threading.Thread(LoadingCode);
            loadingcode.IsBackground = true;
            loadingcode.Start();
        }

        void DelayButton(int nInterval)
        {
            aTimerDelayButton.Interval = nInterval;
            aTimerDelayButton.Start();
            btSendAgain.Enabled = false;
        }



        private async void btConfirm_Click(object sender, EventArgs e)
        {
            string yeuCau="", ketQua="";
            
            if (sCode != tbCode.Text)
            {
                lb_error.Text = "Mã xác thực không đúng.";
                return;
            }
                
           
            switch (which)
            {
                case 0:
                    yeuCau = "DangKy~" + Username.MaHoa() + "~" + DisplayName.MaHoa() + "~" + Password.MaHoa() + "~" + Email.MaHoa() + "~" + Usertype.MaHoa();
                    ketQua = await Task.Run(()=> Result.Instance.Request(yeuCau));

                    if (String.IsNullOrEmpty(ketQua))
                    {
                        MessageBox.Show("Máy chủ không phản hồi");
                    }
                    else if (ketQua == "OK")
                    {
                        DialogResult dialogResult = MessageBox.Show("Đăng ký thành công. Đăng nhập ngay?", "Thông báo", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.Close();
                            nCheckdk = 1;
                            Login login = new Login();
                            login.Show();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            return;
                        }
                    }
                    else if (ketQua == "User or email already exit")
                    {
                        MessageBox.Show("Người dùng hoặc email đã tồn tại");
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                break;
                case 1:
                    this.Hide();
                    Forms.ResetPass reset = new ResetPass(Email);
                    reset.ShowDialog();
                    break;
                default: 
                    MessageBox.Show("Error");
                    break;
            }
        }

        private void FormXacNhanDK_Load(object sender, EventArgs e)
        {
            lbDemNguoc.Text = "";
            lbTimeLate.Text = "";
        }

        private void timeCountdownCode_Tick(object sender, EventArgs e)
        {
            nTimeLate--;
            lbTimeLate.Text = "Mã còn hiệu lực trong: " + nTimeLate.ToString() + "s";
            if (nTimeLate == -1) // Set là -1 để label chạy được đến 0 rồi mới kết thúc
            {
                sCode = "code het hieu luc";//Chuyển mã Code sang số không thể nhập đúng được(max lenght của tb set là 5 nên k thể nhập 11111111)
                lbTimeLate.Text = "Mã hết hạn";
                timeCountdownCode.Stop();
                nTimeLate = 61; // Đặt lại thời gian đếm ngược
            }
        }
    }
}
