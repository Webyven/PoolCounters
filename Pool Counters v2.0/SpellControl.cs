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
    public partial class SpellControl : UserControl
    {
        public Spell spell;
        TimeSpan actualTime = new TimeSpan(0);

        public SpellControl()
        {
            InitializeComponent();
        }

        private void SpellControl_LostFocus(object sender, EventArgs e)
        {
            this.pctSpell.Image = this.actualTime.TotalSeconds > 0 ? Properties.Resources.Opacity : null;
        }

        private void SpellControl_GotFocus(object sender, EventArgs e)
        {
            this.pctSpell.Image = Properties.Resources.CounterControlBackground;
        }

        public void SetSpell(Spell spell)
        {
            this.spell = spell;
            this.pctSpell.BackgroundImage = spell.Icon;
        }

        public void SpellControl_Click(object sender, EventArgs e)
        {
            this.actualTime = spell.DefaultCooldown;
            this.timer.Enabled = true;
            this.lblTimer.Visible = true;
            this.lblTimer.ForeColor = Color.White;
            this.guna2Panel1.ForeColor = Color.White;
            this.lblTimer.Text = FormatTime(actualTime);
            this.pctSpell.Image = Properties.Resources.Opacity;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.actualTime = this.actualTime.Subtract(new TimeSpan(0, 0, 1));

            if(this.actualTime.TotalSeconds > 0)
            {
                this.lblTimer.Text = FormatTime(actualTime);
            }
            else
            {
                this.pctSpell.Image = null;
                this.lblTimer.Text = "";
                this.timer.Enabled = false;
            }
        }

        private string FormatTime(TimeSpan time)
        {
            if (Properties.Settings.Default.showTimeInSeconds)
                return time.TotalSeconds.ToString() + "s";
            else
                return string.Format("{0}:{1}", this.actualTime.Minutes.ToString("00"), this.actualTime.Seconds.ToString("00"));
        }
    }
}
