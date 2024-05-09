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
    public partial class OTPResetPass : Form
    {
        public OTPResetPass()
        {
            InitializeComponent();
            this.MakeDraggable();
        }

        public OTPResetPass(string email)
        {
            InitializeComponent();
            this.MakeDraggable();
        }

        private void btGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            
            Forms.ResetPass resetPass = new Forms.ResetPass();
            resetPass.Show();
        }
    }
}
