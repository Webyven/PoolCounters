using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Counters_v2._0
{
    public partial class PoolForm : Form, ITitleable
    {
        public bool pinned = false;
        public int games;
        public bool SoloQ;
        private readonly Action RefreshSizes;

        const string pageOpGG = @"https://las.op.gg/summoner/userName=";
        const string pageLeagueOfGraphs = @"https://www.leagueofgraphs.com/es/summoner/las/";

        public Guna2GradientPanel titleBar => this.MainGradientPanel;

        public PoolForm(bool SoloQ, Action RefreshSizes)
        {
            InitializeComponent();

            this.SoloQ = SoloQ;
            this.RefreshSizes = RefreshSizes;
            this.guna2Elipse.BorderRadius = 15;

            LoadConfig();
        }

        private void LoadConfig()
        {
            string rolePath = SoloQ ? Properties.Settings.Default.playerRoleSolo : Properties.Settings.Default.playerRoleFlex;

            this.pctRole.Image = File.Exists(rolePath) ? Image.FromFile(rolePath) : Properties.Resources.Position_Grandmaster_Top;
            this.lblOpGg.Text = Properties.Settings.Default.playerNickname;
            this.pctRole.Padding = new Padding(Properties.Settings.Default.rolePadding);

            Properties.Settings.Default.PropertyChanged += (object s, PropertyChangedEventArgs e) => { this.UpdatePoolGradient(); };
            this.UpdatePoolGradient();
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

        private void opGGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.lastPageUsed = pageOpGG;
            InitPage(pageOpGG + Properties.Settings.Default.playerRealNickname);
        }

        private void leagueOfGraphsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.lastPageUsed = pageLeagueOfGraphs;
            InitPage(pageLeagueOfGraphs + Properties.Settings.Default.playerRealNickname);
        }

        private void InitPage(string pagePath)
        {
            System.Diagnostics.Process.Start(pagePath);
        }

        private void btnAppearance_Click(object sender, EventArgs e)
        {
            ExecuteSettingsForm(new fAppearance());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ExecuteSettingsForm(new fPlayerSettings(SoloQ));
        }

        private void ExecuteSettingsForm(Form form)
        {
            if(form.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Save();
                LoadConfig();
                RefreshSizes();
            }
        }

        private void lblOpGg_Click(object sender, MouseEventArgs e)
        {
            string lastPageUsed = string.IsNullOrEmpty(Properties.Settings.Default.lastPageUsed) ? pageOpGG : Properties.Settings.Default.lastPageUsed;

            if(e.Button == MouseButtons.Left)
                InitPage(lastPageUsed + Properties.Settings.Default.playerRealNickname);
        }

        private void PoolForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
