using Guna.UI2.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Counters_v2._0
{
    public partial class PoolCounters : Form, ITitleable
    {
        PictureBox[] pictureBoxes = new PictureBox[9];
        Champion[] champCounters = new Champion[9];
        List<string> Pool = new List<string>();
        List<Counter> Counters = new List<Counter>();
        Champion actualChamp = null;
        PoolForm poolForm;
        PickOne pick;
        ExtraInfo info;

        public string path = Path.Combine(Application.StartupPath, "files");
        public bool SoloQ;


        Guna2GradientPanel ITitleable.titleBar => this.titleBar;

        public PoolCounters()
        {
            PickMode();
            InitializeComponent();
            InitializeApplication();

            new fSpells().ShowDialog();
        }

        private void InitializeApplication()
        {
            InitPictures();
            ChargeFiles();
            ChargeForms();
            Reset();

            DraftMusicManager.OnValueChanged += DraftMusicManager_OnValueChanged;
            DraftMusicManager.Initialize();

            Properties.Settings.Default.PropertyChanged += (object s, PropertyChangedEventArgs e) => { this.UpdateTitleGradients(); };
            this.UpdateTitleGradients();
        }

        private void Reset()
        {
            ResetChamps();
            txtChamp.Text = "";
        }

        private void ResetChamps()
        {
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].BackgroundImage = pictureBoxes[i].InitialImage;
                champCounters[i] = null;

                pictureBoxes[i].ErrorImage = pictureBoxes[i].Image = null;
            }

            pctChamp.Image = pctChamp.InitialImage;
        }

        private void PickMode()
        {
            pick = new PickOne();
            
            pick.btnTEA.Click += BtnTEA_Click;
            pick.btnSoloQ.Click += BtnSoloQ_Click;

            pick.ShowDialog();
        }

        private void ChargeForms()
        {
            poolForm = new PoolForm(this.SoloQ, RefreshSizes);

            RefreshPool();
            RefreshSizes();

            Point spawnForm1 = Screen.GetWorkingArea(this).Location;
            spawnForm1.X = Screen.GetWorkingArea(this).Right - (this.Size.Width) - 15;
            spawnForm1.Y = poolForm.Height + 30;

            this.Location = spawnForm1;

            if (!Properties.Settings.Default.mainLocation.IsEmpty)
                this.Location = Properties.Settings.Default.mainLocation;
        }

        private void RefreshPool()
        {
            poolForm.lytPoolPanel.Controls.Clear();
            int champCounts = 0;

            foreach (string champ in this.Pool)
            {
                Champion aux = ChampionManager.UniversalFindChamp(champ);

                PictureBox pct = new PictureBox();
                pct.Image = aux.GetSquare();
                pct.Size = new Size(45, 45);
                pct.SizeMode = PictureBoxSizeMode.StretchImage;
                pct.Name = champCounts.ToString();
                pct.MouseDown += pctPool_Click;
                pct.Cursor = Cursors.Hand;

                poolForm.lytPoolPanel.Controls.Add(pct);
                champCounts++;
            }
        }

        private void RefreshSizes()
        {
            int champs = poolForm.lytPoolPanel.Controls.Count;
            champs = champs < 4 ? 4 : champs;

            int defaultWidth = 80 + poolForm.lblOpGg.Size.Width - poolForm.lblOpGg.Padding.Right;
            int defaultHeight = 100;
            Point spawnForm2 = Screen.GetWorkingArea(this).Location;
            spawnForm2.X = Screen.GetWorkingArea(this).Right - (champs * 51) - defaultWidth - 15;
            spawnForm2.Y = spawnForm2.Y + 15;

            poolForm.Show();
            poolForm.Size = new Size(defaultWidth + champs * 51, defaultHeight);
            poolForm.lytPoolPanel.Size = new Size(10 + (champs * 51), 75);
            poolForm.Location = spawnForm2;
        }

        private void ChargeFiles()
        {
            try
            {
                DirectoriesManager.Check();
                ChargeChamps();
                ChargeAlias();
                ChargeCounters();
                ChargePool();
                ChargeSpells();
            }
            catch
            {
                fUpdateChampions fUpdate = new fUpdateChampions();
                fUpdate.ALERT = true;
                fUpdate.ShowDialog();
            }
        }

        private void ChargeCounters()
        {
            string countersPath = Path.Combine(path, DEFAULT_PATHS.countersFile);

            try
            {
                if (!string.IsNullOrEmpty(Properties.Settings.Default.counters))
                    Counters = JsonConvert.DeserializeObject<List<Counter>>(Properties.Settings.Default.counters);

                UpdateCounters();
            }
            catch
            {
                MessageBox.Show("Error loading counters", "Thank you for break me 🙃");
            }
        }

        private void UpdateCounters()
        {
            foreach (Counter c in Counters)
            {
                Champion toModify = ChampionManager.UniversalFindChamp(c.Champion);

                foreach (string s in c.GoodAgainst)
                {
                    Champion auxChamp = ChampionManager.UniversalFindChamp(s);
                    toModify.AddCounter(auxChamp);
                }

                toModify.RedistributeCounters();
            }
        }

        private void ChargeAlias()
        {
            string[] contents = Properties.Resources.alias.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string champ in contents)
            {
                string[] allAlias = champ.Split(';');
                Champion toModify = ChampionManager.UniversalFindChamp(allAlias[0]);

                foreach (string a in allAlias)
                {
                    if (a != toModify.GetName())
                        toModify.AddAlias(a);
                }
            }
        }

        private void ChargeChamps()
        {
            if (Directory.Exists(DEFAULT_PATHS.RESOURCES_CHAMPIONS))
            {
                foreach(string square in Directory.GetFiles(DEFAULT_PATHS.RESOURCES_CHAMPIONS))
                {
                    string fileName = Path.GetFileName(square);
                    string champName = fileName.Substring(0, fileName.IndexOf("Square"));

                    Champion champion = new Champion();
                    champion.SetName(champName);
                    champion.SetSquare(Image.FromFile(square));

                    string path = Path.Combine(DEFAULT_PATHS.RESOURCES_BUILDS, champName + "Build");

                    if (File.Exists(path + ".jpeg"))
                        champion.SetInfo(Image.FromFile(path + ".jpeg"));
                    else if(File.Exists(path + ".jpg"))
                        champion.SetInfo(Image.FromFile(path + ".jpg"));
                    else if (File.Exists(path + ".png"))
                        champion.SetInfo(Image.FromFile(path + ".png"));

                    ChampionManager.AddChamp(champion);
                }
            }
        }

        private void ChargeSpells()
        {
            if (Directory.Exists(DEFAULT_PATHS.RESOURCES_SPELLS))
            {
                foreach (string square in Directory.GetFiles(DEFAULT_PATHS.RESOURCES_SPELLS))
                {
                    string fileName = Path.GetFileName(square);
                    string spellName = fileName.Substring(0, fileName.IndexOf("Square"));

                    Spell spell = new Spell(spellName, Image.FromFile(square));

                    SpellManager.AddSpell(spell);
                }
            }
        }

        private void ChargePool()
        {
            string poolContents = SoloQ ? Properties.Settings.Default.poolSolo : Properties.Settings.Default.poolFlex;

            if (!string.IsNullOrEmpty(poolContents))
            {
                Pool = JsonConvert.DeserializeObject<List<string>>(poolContents);
            }
            else
            {
                Pool = new List<string>();

                for (int i = 0; i < 6; i++)
                    Pool.Add("Teemo");
            }
        }

        private void InitPictures()
        {
            pictureBoxes[0] = pctCounter0;
            pictureBoxes[1] = pctCounter1;
            pictureBoxes[2] = pctCounter2;
            pictureBoxes[3] = pctCounter3;
            pictureBoxes[4] = pctCounter4;
            pictureBoxes[5] = pctCounter5;
            pictureBoxes[6] = pctCounter6;
            pictureBoxes[7] = pctCounter7;
            pictureBoxes[8] = pctCounter8;
        }

        private void ShowInfo()
        {
            if (actualChamp == null)
                return;

            if (actualChamp.GetInfo() == null)
                return;

            info = new ExtraInfo();

            info.Text = actualChamp.GetName();
            info.pctMain.Image = actualChamp.GetInfo();

            int width = actualChamp.GetInfo().Width - 25;
            int height = actualChamp.GetInfo().Height;

            info.MaximumSize = new Size((int)(width * 1.25), (int)(height * 1.25));
            info.MinimumSize = new Size((int)(width / 1.25), (int)(height / 1.25));
            info.Size = new Size(width, height);

            info.Show();
        }

        private void ShowInfo(int picNumber)
        {
            if (champCounters[picNumber] == null)
                return;

            info = new ExtraInfo();

            info.Text = champCounters[picNumber].GetName();
            info.pctMain.Image = champCounters[picNumber].GetInfo();

            int width = champCounters[picNumber].GetInfo().Width - 25;
            int height = champCounters[picNumber].GetInfo().Height;

            info.MaximumSize = new Size((int)(width * 1.25), (int)(height * 1.25));
            info.MinimumSize = new Size((int)(width / 1.25), (int)(height / 1.25));
            info.Size = new Size(width, height);

            info.Show();
        }

        private void ShowItemization(int picNumber)
        {
            if (actualChamp == null)
                return;

            if (champCounters[picNumber] == null)
                return;

            string champ = champCounters[picNumber].GetName();
            string versus = actualChamp.GetName();

            if (champ == "Wukong")
                champ = "monkeyking";
            else if (versus == "Wukong")
                versus = "monkeyking";

            champ = champ.ToLower();
            versus = versus.ToLower();

            InitPage(string.Format(@"https://www.leagueofgraphs.com/es/champions/items/{0}/top/vs-{1}/sr-ranked", champ, versus));
        }

        private void ShowPoolInfo(int picNumber)
        {
            info = new ExtraInfo();

            Champion aux = ChampionManager.UniversalFindChamp(Pool[picNumber]);

            if (aux.GetInfo() == null)
                return;

            info.Text = aux.GetName();
            info.pctMain.Image = aux.GetInfo();

            int width = aux.GetInfo().Width - 25;
            int height = aux.GetInfo().Height;

            info.MaximumSize = new Size((int)(width * 1.25), (int)(height * 1.25));
            info.MinimumSize = new Size((int)(width / 1.25), (int)(height / 1.25));
            info.Size = new Size(width, height);

            info.Show();
        }

        private void InitPage(string pagePath)
        {
            System.Diagnostics.Process.Start(pagePath);
        }

        private void BtnSoloQ_Click(object sender, EventArgs e)
        {
            SoloQ = true;
            pick.Close();
        }

        private void BtnTEA_Click(object sender, EventArgs e)
        {
            SoloQ = false;
            pick.Close();
        }


        private void btnCounter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtChamp.Text))
                return;

            ResetChamps();

            try
            {
                actualChamp = ChampionManager.UniversalFindChamp(txtChamp.Text);

                pctChamp.Image = actualChamp.GetSquare();

                int count = 0;
                int amount;

                foreach (string champ in this.Pool)
                {
                    Champion aux = ChampionManager.UniversalFindChamp(champ);

                    if (aux.Counters(actualChamp, out amount) && count < 9)
                    {
                        pictureBoxes[count].BackgroundImage = aux.GetSquare();
                        champCounters[count] = aux;

                        switch (amount)
                        {
                            case 3:
                                pictureBoxes[count].ErrorImage = Properties.Resources.VeryGoodCounter;
                                break;
                            case 2:
                                pictureBoxes[count].ErrorImage = Properties.Resources.GoodCounter;
                                break;
                            case 1:
                                pictureBoxes[count].ErrorImage = Properties.Resources.MediumCounter;
                                break;
                        }

                        count++;
                    }
                }
            }
            catch
            {
                MessageBox.Show(string.Format("Unknown Champ: {0}", txtChamp.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtChamp.Text = "";
                txtChamp.Focus();
            }            
        }

        private void btnExtra_Click(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void extraInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void PoolCounters_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Application.Exit();
        }

        private void pctChamp_Click(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void pctPool_Click(object sender, MouseEventArgs e)
        {
            string pct = ((Control)sender).Name;
            int number = int.Parse(pct);

            ShowPoolInfo(number);
        }

        private void pctCounter_Click(object sender, MouseEventArgs e)
        {
            string pct = ((Control)sender).Name;
            pct = pct.Substring(pct.Length - 1);

            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Middle)
                ShowInfo(int.Parse(pct));

            else if(e.Button == MouseButtons.Right)
                ShowItemization(int.Parse(pct));
        }

        private void PoolCounters_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.mainLocation = this.Location;
            Properties.Settings.Default.draftMusic = DraftMusicManager.Playing;
            Properties.Settings.Default.Save();
        }


        private void iconBar_MouseUp(object sender, MouseEventArgs e)
        {
            optionsMenu.Show(this.iconBar, this.iconBar.Location.X, 30);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updateChampsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fUpdateChampions update = new fUpdateChampions();
            update.ShowDialog();
        }

        private void editCountersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Counter> backupCounters = new List<Counter>(this.Counters);

            using (fCountersEditor editor = new fCountersEditor(this.Counters))
            {
                if(editor.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.counters = JsonConvert.SerializeObject(this.Counters);
                    Properties.Settings.Default.Save();

                    foreach (string c in backupCounters.Select(x => x.Champion).Distinct())
                        ChampionManager.UniversalFindChamp(c).RedistributeCounters();

                    UpdateCounters();
                }
                else Counters = new List<Counter>(backupCounters);
            }
        }

        private void editPoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPoolEditor editor = new fPoolEditor(this.Pool);

            if(editor.ShowDialog() == DialogResult.OK)
            {
                if (SoloQ)
                    Properties.Settings.Default.poolSolo = JsonConvert.SerializeObject(this.Pool);
                else
                    Properties.Settings.Default.poolFlex = JsonConvert.SerializeObject(this.Pool);

                Properties.Settings.Default.Save();

                RefreshPool();
                RefreshSizes();
            }
        }

        private void pctCounter_MouseEnter(object sender, EventArgs e)
        {
            PictureBox s = sender as PictureBox;
            s.Image = s.ErrorImage;
        }

        private void pctCounter_MouseLeave(object sender, EventArgs e)
        {
            PictureBox s = sender as PictureBox;
            s.Image = null;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            fHelp help = new fHelp();
            help.ShowDialog();
        }

        private void btnControlBox_MouseEnter(object sender, EventArgs e)
        {
            Guna2ImageButton s = sender as Guna2ImageButton;
            s.UseTransparentBackground = false;
            s.BackColor = Color.FromArgb(33,33,33);
        }

        private void btnControlBox_MouseLeave(object sender, EventArgs e)
        {
            Guna2ImageButton s = sender as Guna2ImageButton;
            s.UseTransparentBackground = true;
            s.BackColor = Color.Transparent;
        }

        private void DraftMusicManager_OnValueChanged()
        {
            this.btnMusic.Image = DraftMusicManager.Playing ? Properties.Resources.Unmuted : Properties.Resources.Muted;
        }

        private void btnMusic_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DraftMusicManager.Playing = !DraftMusicManager.Playing;
            else
                this.musicMenu.Show(this, this.btnMusic.Location.X, 30);
        }

        private void Music_Click(object sender, EventArgs e)
        {
            DraftMusicManager.SetMusic(Properties.Resources.ResourceManager.GetStream(((ToolStripMenuItem)sender).Name));
        }
    }
}