using Guna.UI2.WinForms;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Counters_v2._0
{
    public partial class fUpdateChampions : Form, ITitleable
    {
        const string DEFAULT_TITLE = "Updating...";
        public bool ALERT = false;
        private bool ALERT_UPDATED = false;
        private bool updating = false;

        Guna2GradientPanel ITitleable.titleBar => this.titleBar;

        public fUpdateChampions()
        {
            InitializeComponent();
            ChargeLastUpdateInfo();
            this.UpdateTitleGradients();
        }

        private void ChargeTitle()
        {
            lblTitle.Text = ALERT ? "Files are missing, need to update." : "Press the button to update...";
            lblTitle.ForeColor = ALERT ? Color.Red : Color.White;
        }

        private void ChargeLastUpdateInfo()
        {
            lblChampions.Text = "Champions: " + Properties.Settings.Default.champsCount;
            lblLastChampion.Text = "Last Champion: " + Properties.Settings.Default.lastChamp;
        }

        delegate void SetTextCallback(string text, string percent);

        private void SetText(string text, string percent)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.lblProgress.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text, percent });
            }
            else
            {
                this.lblProgress.Text = text;
                this.lblTitle.Text = string.Format("{0} ({1}%)", DEFAULT_TITLE, percent);
            }
        }

        public async Task UpdateChampions()
        {
            lblTitle.Text = DEFAULT_TITLE;
            lblTitle.ForeColor = Color.White;

            await Task.Run(() =>
            {
                if (!Directory.Exists(DEFAULT_PATHS.RESOURCES_CHAMPIONS))
                    Directory.CreateDirectory(DEFAULT_PATHS.RESOURCES_CHAMPIONS);

                updating = true;

                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = web.Load("https://lol.fandom.com/wiki/Portal:Champions");

                HtmlNode champs = doc.DocumentNode.CssSelect(".portal-champion-left").First();
                bool jump = false;

                UpdateProgressBar.Value = 1;
                Properties.Settings.Default.champsCount = UpdateProgressBar.Maximum = champs.CssSelect("div").ToList().Count / 2;

                foreach (var champ in champs.CssSelect("div"))
                {
                    if (jump)
                    {
                        jump = false;
                        continue;
                    }

                    var node = champ.CssSelect("a").First();

                    // Get and handle champ name
                    string champName = node.GetAttributeValue("title");
                    champName = champName.Replace("&#39;", "").Replace(" ", "").Replace(".", "");

                    if (champName.StartsWith("Nunu"))
                        champName = "Nunu";

                    int percent = (UpdateProgressBar.Value * 100) / UpdateProgressBar.Maximum;
                    SetText(string.Format("{0} ({1}/{2})", champName, UpdateProgressBar.Value, UpdateProgressBar.Maximum), percent.ToString());

                    // Get and save champ square
                    string imgSource = node.CssSelect("img").First().GetAttributeValue("data-src");
                    imgSource = imgSource.Substring(0, imgSource.IndexOf(".png") + 4);

                    if (!File.Exists(Path.Combine(DEFAULT_PATHS.RESOURCES_CHAMPIONS, champName + "Square.png")))
                    {
                        WebClient client = new WebClient();
                        client.DownloadFile(imgSource, Path.Combine(DEFAULT_PATHS.RESOURCES_CHAMPIONS, champName + "Square.png"));
                        Properties.Settings.Default.lastChamp = champName;
                    }
                    
                    UpdateProgressBar.Value++;

                    jump = true;
                }

                if (ALERT)
                    ALERT_UPDATED = false;

                updating = false;
                Properties.Settings.Default.Save();
            });
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (updating)
                return;

            await UpdateChampions();
            ChargeLastUpdateInfo();

            if (ALERT)
                Application.Restart();
        }

        private void fUpdateChampions_Load(object sender, EventArgs e)
        {
            ChargeTitle();
        }

        private void fUpdateChampions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ALERT & !ALERT_UPDATED)
                Application.Exit();
        }
    }
}
