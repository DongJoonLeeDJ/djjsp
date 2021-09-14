using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice1
{
    public partial class WindowsForm : Form
    {
        public WindowsForm()
        {
            InitializeComponent();
            Windows os = new Windows();
            label_connectionTime.Text = os.mConnectionTime;
            os.mPrint();
        }
    }
}
