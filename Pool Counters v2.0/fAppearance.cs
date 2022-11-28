using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Counters_v2._0
{
    public partial class fAppearance : Form, ITitleable
    {
        Color firstColorBackup;
        Color secondColorBackup;
        LinearGradientMode modeBackup;
        bool applyToAllGradientsBackup;

        Guna2GradientPanel ITitleable.titleBar => this.titleBar;

        public fAppearance()
        {
            InitializeComponent();

            firstColorBackup = Properties.Settings.Default.firstGradientColor;
            secondColorBackup = Properties.Settings.Default.secGradientColor;
            modeBackup = Properties.Settings.Default.gradientMode;
            applyToAllGradientsBackup = Properties.Settings.Default.applyToAllGradients;

            Properties.Settings.Default.PropertyChanged += (object s, PropertyChangedEventArgs e) => { this.UpdateTitleGradients(); };

            this.UpdateTitleGradients();
        }

        private void btnFirstColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = btnFirstColor.FillColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
                SetFirstColor(colorDialog.Color);
        }

        private void btnSecondColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = btnSecondColor.FillColor;

            if (colorDialog.ShowDialog() == DialogResult.OK)
                SetSecondColor(colorDialog.Color);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if(((Guna2GradientButton)sender).DialogResult == DialogResult.Cancel)
            {
                Properties.Settings.Default.firstGradientColor = firstColorBackup;
                Properties.Settings.Default.secGradientColor = secondColorBackup;
                Properties.Settings.Default.gradientMode = modeBackup;
                Properties.Settings.Default.applyToAllGradients = applyToAllGradientsBackup;
            }

            this.DialogResult = ((Guna2GradientButton)sender).DialogResult;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(btnFirstColor.FillColor == firstColorBackup && btnSecondColor.FillColor == secondColorBackup && cbApplyGradients.Checked == applyToAllGradientsBackup)
            {
                SetFirstColor(Color.FromArgb(25, 25, 25));
                SetSecondColor(Color.FromArgb(12, 12, 12));
                SetGradient(LinearGradientMode.Horizontal);
                SetGradientApplication(false);
            }
            else
            {
                SetFirstColor(firstColorBackup);
                SetSecondColor(secondColorBackup);
                SetGradient(modeBackup);
                SetGradientApplication(applyToAllGradientsBackup);
            }
        }

        private void SetFirstColor(Color color)
        {
            btnFirstColor.FillColor = PreviewGradientPanel.FillColor = Properties.Settings.Default.firstGradientColor = color;
        }

        private void SetSecondColor(Color color)
        {
            btnSecondColor.FillColor = PreviewGradientPanel.FillColor2 = Properties.Settings.Default.secGradientColor = color;
        }

        private void SetGradient(LinearGradientMode mode)
        {
            PreviewGradientPanel.GradientMode = Properties.Settings.Default.gradientMode = mode;
        }

        private void SetGradientApplication(bool value)
        {
            this.cbApplyGradients.Checked = Properties.Settings.Default.applyToAllGradients = value;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int actualMode = (int)PreviewGradientPanel.GradientMode;

            if (actualMode == 3)
                actualMode = 0;
            else
                actualMode++;

            SetGradient((LinearGradientMode)actualMode);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int actualMode = (int)PreviewGradientPanel.GradientMode;

            if (actualMode == 0)
                actualMode = 3;
            else
                actualMode--;

            SetGradient((LinearGradientMode)actualMode);
        }

        private void cbApplyGradients_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.applyToAllGradients = this.cbApplyGradients.Checked;
        }
    }
}
