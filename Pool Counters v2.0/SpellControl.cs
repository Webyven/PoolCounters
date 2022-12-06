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
using static Guna.UI2.Native.WinApi;

namespace Pool_Counters_v2._0
{
    public partial class SpellControl : UserControl
    {
        public Spell spell;
        TimeSpan actualTime = new TimeSpan(0);
        public ContextMenuStrip menu;
        private SpellPlayerControl parent;
        private Guna2CustomCheckBox cbJonias, cbCosmic;

        public SpellControl()
        {
            InitializeComponent();
        }

        public void InitializeControl()
        {
            this.parent = ((SpellPlayerControl)this.Parent);
            this.cooldownProgress.Value = 0;
            this.cbCosmic = this.parent.cbCosmicInsight;
            this.cbJonias = this.parent.cbJonias;
            this.cbJonias.CheckedChanged += Cb_CheckedChanged;
            this.cbCosmic.CheckedChanged += Cb_CheckedChanged;
        }

        private void Cb_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTimer();
        }

        private void UpdateTimer()
        {
            int actualCooldown = this.spell.GetCooldown(this.cbJonias.Checked, this.cbCosmic.Checked);

            if (actualTime.TotalSeconds > 0)
            {
                if(actualTime.TotalSeconds > actualCooldown)
                    actualTime = new TimeSpan(0, 0, actualCooldown);
            }
        }

        public void SetContextMenuStrip(ContextMenuStrip menu) { this.menu = menu; }

        public void SetSpell(Spell spell)
        {
            this.spell = spell;
            this.pctSpell.BackgroundImage = spell.Icon;
            this.UpdateTimer();
            this.Update();
            this.UpdateStyles();
            this.PerformLayout();
        }

        public void SpellControl_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.editSpellsMode)
            {
                menu.ItemClicked += Menu_ItemClicked;
                menu.Closed += Menu_Closed;
                menu.Show(this, 0, this.Height);
            }
            else
            {
                if (this.actualTime.TotalSeconds > 0)
                {
                    this.pctSpell.Image = null;
                    this.lblTimer.Text = "";
                    this.timer.Enabled = false;
                    this.actualTime = new TimeSpan(0);
                    this.cooldownProgress.Value = 0;
                }
                else
                {
                    this.actualTime = new TimeSpan(0, 0, spell.GetCooldown(this.cbJonias.Checked, this.cbCosmic.Checked));
                    this.cooldownProgress.Value = this.cooldownProgress.Maximum = (int)this.actualTime.TotalSeconds; 
                    this.timer.Enabled = true;
                    this.lblTimer.Visible = true;
                    this.lblTimer.ForeColor = Color.White;
                    this.guna2Panel1.ForeColor = Color.White;
                    this.lblTimer.Text = FormatTime(actualTime);
                    this.pctSpell.Image = Properties.Resources.Opacity2;
                }

            }
        }

        private void Menu_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            menu.ItemClicked -= Menu_ItemClicked;
            menu.Closed -= Menu_Closed;
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            this.SetSpell(SpellManager.FindSpell(e.ClickedItem.Text));
            menu.ItemClicked -= Menu_ItemClicked;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.actualTime = this.actualTime.Subtract(new TimeSpan(0, 0, 1));


            if (this.actualTime.TotalSeconds > 0)
            {
                this.lblTimer.Text = FormatTime(actualTime);
                this.cooldownProgress.Value = (int)actualTime.TotalSeconds;
            }
            else
            {
                this.pctSpell.Image = null;
                this.lblTimer.Text = "";
                this.timer.Enabled = false;
                this.actualTime = new TimeSpan(0);
                this.cooldownProgress.Value = 0;
            }
        }

        private string FormatTime(TimeSpan time)
        {
            if (Properties.Settings.Default.showTimeInSeconds)
                return time.TotalSeconds.ToString() + "s";
            else
                return string.Format("{0}:{1}", this.actualTime.Minutes.ToString("00"), this.actualTime.Seconds.ToString("00"));
        }

        bool Jonias, Cosmic = false;

        internal void SetJonias(bool v)
        {
            this.Jonias = v;
        }

        internal void SetCosmicInsight(bool v)
        {
            this.Cosmic = v;
        }

    }
}
