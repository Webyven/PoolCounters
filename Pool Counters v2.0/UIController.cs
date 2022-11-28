using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Counters_v2._0
{
    public static class UIController
    {
        public static void UpdateTitleGradients(this ITitleable form)
        {
            if (Properties.Settings.Default.applyToAllGradients)
            {
                form.titleBar.FillColor = Properties.Settings.Default.firstGradientColor;
                form.titleBar.FillColor2 = Properties.Settings.Default.secGradientColor;
                form.titleBar.GradientMode = Properties.Settings.Default.gradientMode;
            }
            else
            {
                form.titleBar.FillColor = Color.FromArgb(25, 25, 25);
                form.titleBar.FillColor2 = Color.FromArgb(12, 12, 12);
                form.titleBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            }
        }

        public static void UpdatePoolGradient(this ITitleable form)
        {
            form.titleBar.FillColor = Properties.Settings.Default.firstGradientColor;
            form.titleBar.FillColor2 = Properties.Settings.Default.secGradientColor;
            form.titleBar.GradientMode = Properties.Settings.Default.gradientMode;
        }
    }

    public interface ITitleable
    {
        Guna.UI2.WinForms.Guna2GradientPanel titleBar { get; }
    }
}
