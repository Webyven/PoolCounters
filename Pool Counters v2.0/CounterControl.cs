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
    public partial class CounterControl : UserControl
    {
        Counter counter;

        public CounterControl(Counter counter)
        {
            InitializeComponent();
            this.counter = counter;

            ChargeCounters();
        }

        private void ChargeCounters()
        {
            Champion aux = ChampionManager.UniversalFindChamp(counter.Champion);
            this.pctChamp.BackgroundImage = aux.GetSquare();
            this.lblChamp.Text = string.Format("{0} is good against...", aux.GetName());

            foreach(string c in counter.GoodAgainst)
                AddCounterToPanel(ChampionManager.UniversalFindChamp(c), false);

            RefreshTags();
        }

        public void AddCounter(Champion champion)
        {
            if (counter.GoodAgainst.Contains(champion.GetName()) || counter.Champion == champion.GetName())
                return;

            AddCounterToPanel(champion);
            this.counter.GoodAgainst.Add(champion.GetName());
        }

        private void AddCounterToPanel(Champion champion, bool UpdateTags = true)
        {
            PictureBox pct = new PictureBox();
            pct.Size = new Size(30, 30);
            pct.ErrorImage = Properties.Resources.DeleteChamp;
            pct.BackgroundImage = champion.GetSquare();
            pct.BackgroundImageLayout = ImageLayout.Stretch;
            pct.SizeMode = PictureBoxSizeMode.StretchImage;
            pct.MouseEnter += Pct_MouseEnter;
            pct.MouseLeave += Pct_MouseLeave;
            pct.Click += Pct_Click;
            pct.Cursor = Cursors.Hand;
            pct.Name = champion.GetName();
            countersPanel.Controls.Add(pct);

            if(UpdateTags)
                RefreshTags();
        }

        private void Pct_Click(object sender, EventArgs e)
        {
            this.countersPanel.Controls.Remove((Control)sender);
            this.counter.GoodAgainst.Remove(((Control)sender).Name);
        }

        private void RefreshTags()
        {
            for (int i = 0; i < countersPanel.Controls.Count; i++)
                countersPanel.Controls[i].Tag = i;
        }

        private void Pct_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pct = sender as PictureBox;
            pct.Image = null;
        }

        private void Pct_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pct = sender as PictureBox;
            pct.Image = pct.ErrorImage;
            this.BackgroundImage = Properties.Resources.CounterControlBackground;
        }

        private void pctChamp_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.CounterControlDeleteBackground;
        }

        private void pctChamp_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
        }

        private void btnNext_MouseClick(object sender, MouseEventArgs e)
        {
            int count = countersPanel.Controls.Count;

            if (count <= 11)
                return;

            countersPanel.SuspendLayout();

            if (e.Button == MouseButtons.Left)
            {
                countersPanel.Controls[0].SendToBack();
            }
            else if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < 11; i++)
                    countersPanel.Controls[0].SendToBack();
            }

            countersPanel.ResumeLayout();
            countersPanel.PerformLayout();
        }

        private void btnPrevious_MouseClick(object sender, MouseEventArgs e)
        {
            int count = countersPanel.Controls.Count;

            if (count <= 11)
                return;

            countersPanel.SuspendLayout();

            if (e.Button == MouseButtons.Left)
            {
                countersPanel.Controls[count - 1].BringToFront();
            }
            else if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < 11; i++)
                    countersPanel.Controls[count - 1].BringToFront();
            }

            countersPanel.ResumeLayout();
            countersPanel.PerformLayout();
        }

        private void btnPrevious_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.CounterControlBackground;
        }


        private void CounterControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
        }
    }
}
