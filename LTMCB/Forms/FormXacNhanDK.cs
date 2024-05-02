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
    public partial class FormXacNhanDK : Form
    {
        string sCode;//Mã xác thực email (random 4 chữ số)
        int nCountDown = 61; // Set thời gian chờ là 61 => khi bắt đầu đếm ngược sẽ đếm từ 60
        int nTimeLate = 61;//Thời gian hiệu lực của code
        private readonly Timer aTimerDelayButton;
        private Timer aTimerCountDown;
        public FormXacNhanDK()
        {
            InitializeComponent();
            tbCode.Focus();
            timeCountdownCode.Start();
            aTimerDelayButton = new Timer();
            aTimerCountDown = new Timer();
            aTimerDelayButton.Tick += aTimerDelayButton_Tick;
            aTimerCountDown.Tick += aTimerCountDown_Tick;
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
            //SendCode();
            tbCode.Text = "";
            tbCode.Focus();
            DelayButton(62000);// Set thời gian là 62s để chạy cùng với thời gian đếm ngược (61-0)
            WaitButton();
            timeCountdownCode.Start();
        }

        void DelayButton(int nInterval)
        {
            aTimerDelayButton.Interval = nInterval;
            aTimerDelayButton.Start();
            btSendAgain.Enabled = false;
        }



        private void btConfirm_Click(object sender, EventArgs e)
        {

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
