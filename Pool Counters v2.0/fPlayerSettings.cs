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
    public partial class fPlayerSettings : Form, ITitleable
    {
        private bool SoloQ;

        Guna2GradientPanel ITitleable.titleBar => this.titleBar;

        public fPlayerSettings(bool SoloQ)
        {
            InitializeComponent();

            this.SoloQ = SoloQ;

            string rolePath = SoloQ ? Properties.Settings.Default.playerRoleSolo : Properties.Settings.Default.playerRoleFlex;

            this.openFileDialog1.InitialDirectory = DEFAULT_PATHS.RESOURCES_POSITIONS;
            this.pctRole.Image = File.Exists(rolePath) ? Image.FromFile(rolePath) : Properties.Resources.Top;
            this.txtNickname.Text = Properties.Settings.Default.playerNickname;
            this.txtRealNickname.Text = Properties.Settings.Default.playerRealNickname;

            this.UpdateTitleGradients();
        }

        private void txtNickname_TextChanged(object sender, EventArgs e)
        {
            txtRealNickname.Text = txtNickname.Text;
        }

        private void pctRole_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (SoloQ)
                Properties.Settings.Default.playerRoleSolo = openFileDialog1.FileName;
            else
                Properties.Settings.Default.playerRoleFlex = openFileDialog1.FileName;

            this.pctRole.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.playerNickname = this.txtNickname.Text;
            Properties.Settings.Default.playerRealNickname = this.txtRealNickname.Text;
            Properties.Settings.Default.rolePadding = this.barPadding.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void barPadding_ValueChanged(object sender, EventArgs e)
        {
            this.pctRole.Padding = new Padding(this.barPadding.Value);
        }
    }
}
