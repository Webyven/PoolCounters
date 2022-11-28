using Guna.UI2.WinForms;
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
    public partial class PickOne : Form
    {
        public PickOne()
        {
            InitializeComponent();
        }

        private void PickOne_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
                btnSoloQ.PerformClick();

            if (e.KeyCode == Keys.F)
                btnTEA.PerformClick();

            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void btnSoloQ_MouseEnter(object sender, EventArgs e)
        {
            ((Guna2Button)sender).BackgroundImage = Properties.Resources.CounterControlBackground;
        }

        private void btnSoloQ_MouseLeave(object sender, EventArgs e)
        {
            ((Guna2Button)sender).BackgroundImage = null;
        }
    }
}
