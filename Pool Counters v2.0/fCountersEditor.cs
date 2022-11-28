using Guna.UI2.WinForms;
using Newtonsoft.Json;
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
    public partial class fCountersEditor : Form, ITitleable
    {
        List<Counter> Counters;
        int? selectedIndex = null;
        bool CounterMode = false;

        Guna2GradientPanel ITitleable.titleBar => this.titleBar;

        public fCountersEditor(List<Counter> Counters)
        {
            InitializeComponent();
            guna2Elipse1.BorderRadius = guna2Elipse4.BorderRadius = 10;

            this.Counters = Counters;
            this.txtChamp.AutoCompleteCustomSource = AutoCompleteSources.Champions;

            ChargeCounters();
            this.UpdateTitleGradients();
        }

        private void ChargeCounters()
        {
            countersPanel.Controls.Clear();

            foreach(Counter c in Counters)
                AddCounterToPanel(c, false);

            RefreshTags();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CounterMode /* && No existen los counters de este champ */)
                AddCounter(new Counter(ChampionManager.UniversalFindChamp(txtChamp.Text).GetName()));
            else
                AddCounterToSelectedChamp();

            txtChamp.Text = "";
            txtChamp.Focus();
        }

        public void AddCounter(Counter counter)
        {
            this.Counters.Add(counter);
            AddCounterToPanel(counter);
        }

        public void AddCounterToPanel(Counter counter, bool UpdateTags = true)
        {
            CounterControl ctrl = new CounterControl(counter);
            ctrl.Click += Ctrl_Click;
            ctrl.lblChamp.Click += Ctrl_Click;
            ctrl.pctChamp.Click += PctChamp_Click;
            countersPanel.Controls.Add(ctrl);

            if(UpdateTags)
                RefreshTags();
        }

        private void AddCounterToSelectedChamp()
        {
            if(ChampionManager.UniversalFindChamp(txtChamp.Text) != null)
                ((CounterControl)countersPanel.Controls[selectedIndex.Value]).AddCounter(ChampionManager.UniversalFindChamp(txtChamp.Text));
        }

        private void RemoveCounterToPanel(int index)
        {
            this.countersPanel.Controls.RemoveAt(index);
            RefreshTags();
        }

        private void PctChamp_Click(object sender, EventArgs e)
        {
            int index = (int)((Control)sender).Parent.Tag;
            UpdateSelected(null);
            RemoveCounterToPanel(index);
            this.Counters.RemoveAt(index);
        }

        private void Ctrl_Click(object sender, EventArgs e)
        {
            UpdateSelected(GetIndex(sender));
        }

        private int GetIndex(object sender)
        {
            if (sender is CounterControl)
                return (int)((Control)sender).Tag;
            else
                return (int)((Control)sender).Parent.Tag;
        }

        private void UpdateSelected(int? newSelected)
        {
            if (selectedIndex.HasValue)
                countersPanel.Controls[selectedIndex.Value].BackColor = Color.FromArgb(33, 33, 33);

            if (newSelected.HasValue)
                countersPanel.Controls[newSelected.Value].BackColor = Color.Black;

            selectedIndex = newSelected;

            if (selectedIndex.HasValue)
                UpdateCounterMode(true);
            else
                UpdateCounterMode(false);
        }

        private void UpdateCounterMode(bool CounterMode)
        {
            if (CounterMode)
                this.btnAdd.Text = "Add Counter";
            else
                this.btnAdd.Text = "Add Champion";

            this.CounterMode = CounterMode;
        }

        public void RefreshTags()
        {
            for(int i = 0; i < countersPanel.Controls.Count; i++)
                countersPanel.Controls[i].Tag = i;
        }

        private void txtChamp_TextChanged(object sender, EventArgs e)
        {
            Champion aux = ChampionManager.UniversalFindChamp(txtChamp.Text);

            pctChamp.Image = aux == null ? pctChamp.InitialImage : aux.GetSquare();
        }

        private void fCountersEditor_Click(object sender, EventArgs e)
        {
            UpdateSelected(null);
        }

        private void fCountersEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                c.Dispose();
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            this.DialogResult = ((IButtonControl)sender).DialogResult;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(Counters));
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            this.Counters.Clear();
            this.Counters.AddRange(JsonConvert.DeserializeObject<List<Counter>>(File.ReadAllText(openFileDialog.FileName)));
            ChargeCounters();
        }
    }
}
