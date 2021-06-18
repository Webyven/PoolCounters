using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Counters_v2._0
{
    public partial class ExtraInfo : Form
    {
        public bool pinned = false;

        public ExtraInfo()
        {
            InitializeComponent();
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            if (!pinned)
            {
                this.TopMost = true;
                this.btnPin.Image = Properties.Resources.unpinWhite;
                pinned = true;
            }
            else
            {
                this.TopMost = false;
                this.btnPin.Image = Properties.Resources.pinWhite;
                pinned = false;
            }
        }
    }
}
