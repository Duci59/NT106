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
    public partial class QLFile : Form
    {
        public QLFile()
        {
            InitializeComponent();
            this.MakeDraggable();
        }
    }
}
