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
    public partial class fPoolEditor : Form, ITitleable
    {
        List<string> Pool;

        Guna2GradientPanel ITitleable.titleBar => this.titleBar;

        public fPoolEditor(List<string> Pool)
        {
            InitializeComponent();
            this.Pool = Pool;
            ShowPool();

            this.txtChamp.AutoCompleteCustomSource = AutoCompleteSources.Champions;

            this.guna2Elipse3.BorderRadius = 10;

            this.UpdateTitleGradients();
        }

        private void ShowPool()
        {
            poolPanel.Controls.Clear();

            foreach(string champ in Pool)
            {
                AddChampionToPanel(ChampionManager.UniversalFindChamp(champ));
            }
        }

        private void RefreshTags()
        {
            for(int i = 0; i < poolPanel.Controls.Count; i++)
                poolPanel.Controls[i].Tag = i;
        }

        private void RefreshSize()
        {
            const int defaultHeight = 125;
            const int widthWithoutChamps = 230;

            this.Size = new Size(widthWithoutChamps + (this.poolPanel.Controls.Count * 41), defaultHeight);
        }

        private void AddChampionToPanel(Champion champ)
        {
            PictureBox pct = new PictureBox();
            pct.Size = new Size(35, 35);
            pct.SizeMode = PictureBoxSizeMode.StretchImage;
            pct.BackgroundImageLayout = ImageLayout.Stretch;
            pct.BackgroundImage = champ.GetSquare();
            pct.MouseEnter += Pct_MouseEnter;
            pct.MouseLeave += Pct_MouseLeave;
            pct.Click += Pct_Click;
            pct.Cursor = Cursors.Hand;
            poolPanel.Controls.Add(pct);

            RefreshTags();
            RefreshSize();
        }

        private void Pct_Click(object sender, EventArgs e)
        {
            int index = (int)((PictureBox)sender).Tag;

            Pool.RemoveAt(index);
            RemoveChampionToPanel(index);
        }

        private void RemoveChampionToPanel(int index)
        {
            poolPanel.Controls.RemoveAt(index);
            RefreshTags();
            RefreshSize();
        }

        private void Pct_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = null;
        }

        private void Pct_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = Properties.Resources.DeleteChamp;
        }

        private void txtChamp_TextChanged(object sender, EventArgs e)
        {
            Champion aux = ChampionManager.UniversalFindChamp(txtChamp.Text);

            pctChamp.Image = aux == null ? pctChamp.InitialImage : aux.GetSquare();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Champion aux = ChampionManager.UniversalFindChamp(txtChamp.Text);

            if (aux != null && !Pool.Contains(aux.GetName()))
            {
                if (Pool.Count < 20)
                {
                    Pool.Add(aux.GetName());
                    AddChampionToPanel(aux);
                }
            }

            Reset();
        }

        private void Reset()
        {
            this.txtChamp.Text = "";
            this.txtChamp.Focus();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
