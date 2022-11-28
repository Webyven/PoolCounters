using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Counters_v2._0
{
    public partial class fHelp : Form, ITitleable
    {
        Guna2GradientPanel ITitleable.titleBar => this.titleBar;

        public fHelp()
        {
            InitializeComponent();

            lblVersion.Text = "v" + Application.ProductVersion;

            this.UpdateTitleGradients();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(tabControl.SelectedIndex != tabControl.TabCount)
                tabControl.SelectedIndex++;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(tabControl.SelectedIndex != 0)
                tabControl.SelectedIndex--;
        }

        private void btnResources_Click(object sender, EventArgs e)
        {
            Process.Start(DEFAULT_PATHS.RESOURCES);
        }

        private void btnBuildsFolder_Click(object sender, EventArgs e)
        {
            Process.Start(DEFAULT_PATHS.RESOURCES_BUILDS);
        }

        private void btnChampionsFolder_Click(object sender, EventArgs e)
        {
            Process.Start(DEFAULT_PATHS.RESOURCES_CHAMPIONS);
        }
    }
}
