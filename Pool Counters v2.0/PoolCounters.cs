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
    public partial class PoolCounters : Form
    {
        PictureBox[] pictureBoxes = new PictureBox[9];
        PictureBox[] pctAmounts = new PictureBox[9];
        Champion[] champCounters = new Champion[9];
        Label[] lblGamesCount;
        ChampionManager allChampsManager = new ChampionManager();
        ChampionManager poolManager = new ChampionManager();
        Champion actualChamp = null;
        PoolForm poolForm;
        PickOne pick;
        ExtraInfo info;

        public string path = Path.Combine(Application.StartupPath, "files");
        public bool SoloQ;

        const string champsFile = "champs.pc";
        const string gamesFile = "games.pc";
        const string aliasFile = "alias.pc";
        const string tipsFile = "tips.pc";
        const string cdsFile = "cds.pc";
        const string poolTFile = "tea.pc";
        const string poolSFile = "soloQ.pc";        
        const string countersFile = "counters.pc";

        public PoolCounters()
        {
            PickMode();
            InitializeComponent();
            InitializeApplication();
        }

        private void InitializeApplication()
        {            
            InitPictures();
            ChargeFiles();
            ChargeForms();
            Reset();
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
                pictureBoxes[i].Image = pictureBoxes[i].InitialImage;
                champCounters[i] = null;

                pctAmounts[i].Visible = false;
            }

            tipMainChamp.SetToolTip(pctChamp, null);
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
            int champCounts = 0;
            List<Champion> Pool = poolManager.GetChampions();
            PictureBox[] champs = new PictureBox[Pool.Count];
            poolForm = new PoolForm();
            lblGamesCount = new Label[Pool.Count];

            foreach(Champion champ in Pool)
            {
                FlowLayoutPanel panel = new FlowLayoutPanel();
                lblGamesCount[champCounts] = new Label();
                lblGamesCount[champCounts].AutoSize = false;
                lblGamesCount[champCounts].Size = new Size(43, 13);
                lblGamesCount[champCounts].Padding = new Padding(5, 0, 0, 0);
                lblGamesCount[champCounts].TextAlign = ContentAlignment.MiddleCenter;

                if(champ.GetObjGames() != 0)
                {
                    if (champ.GetGames() >= champ.GetObjGames())
                    {
                        lblGamesCount[champCounts].Text = "✓";
                        lblGamesCount[champCounts].ForeColor = Color.Green;
                        lblGamesCount[champCounts].Font = new Font(this.Font, FontStyle.Bold);
                    }
                    else
                    {
                        lblGamesCount[champCounts].Text = champ.GetGames().ToString() + "/" + champ.GetObjGames().ToString();
                        lblGamesCount[champCounts].ForeColor = Color.Black;
                        lblGamesCount[champCounts].Font = new Font(this.Font, FontStyle.Regular);
                    }
                }
                else
                {
                    lblGamesCount[champCounts].Text = "✘";
                    lblGamesCount[champCounts].ForeColor = Color.Red;
                    lblGamesCount[champCounts].Font = new Font(this.Font, FontStyle.Regular);
                }

                champs[champCounts] = new PictureBox();
                champs[champCounts].Image = champ.GetSquare();
                champs[champCounts].Size = new Size(45, 45);
                champs[champCounts].SizeMode = PictureBoxSizeMode.StretchImage;
                champs[champCounts].Name = champCounts.ToString();
                champs[champCounts].MouseDown += pctPool_Click;

                panel.AutoSize = true;
                panel.FlowDirection = FlowDirection.TopDown;
                panel.Controls.Add(champs[champCounts]);
                panel.Controls.Add(lblGamesCount[champCounts]);

                poolForm.lytPoolPanel.Controls.Add(panel);
                champCounts++;
            }

            int defaultWidth = 150;
            int defaultHeight = 115;
            Point spawnForm2 = this.Location;
            spawnForm2.X = spawnForm2.X + 1750 - (champCounts * 56);
            spawnForm2.Y = spawnForm2.Y + 15;

            poolForm.Show();
            poolForm.Size = new Size(defaultWidth + champCounts * 56, defaultHeight);
            poolForm.lytPoolPanel.Size = new Size(10 + (champCounts * 60), 75);
            poolForm.Location = spawnForm2;

            Point spawnForm1 = this.Location;
            spawnForm1.X += 1610;
            spawnForm1.Y += 145;

            poolForm.lblPool.Location = new Point((100 + champCounts * 55) / 2, poolForm.lblPool.Location.Y);
            this.Location = spawnForm1;
        }

        private void ChargeFiles()
        {
            ChargeChamps();
            ChargeAlias();
            ChargeCounters();
            ChargeTips();
            ChargeCooldowns();
            ChargeGames();
            ChargePool();
        }

        private void ChargeGames()
        {
            string gamesPath = Path.Combine(path, gamesFile);

            if (File.Exists(gamesPath))
            {
                string[] contents = File.ReadAllLines(gamesPath);

                foreach(string content in contents)
                {
                    string champ = content.Split(':')[0];
                    int games = int.Parse(content.Split(':')[1]);

                    allChampsManager.UniversalFindChamp(champ).SetObjGames(games);
                }
            }
        }

        private void WriteGames()
        {
            string champsPath = Path.Combine(path, champsFile);
            string contents = "";

            foreach (Champion champ in allChampsManager.GetChampions())
            {
                if (champ != allChampsManager.GetChampions().Last<Champion>())
                    contents += champ.GetName() + ":" + champ.GetGames() + System.Environment.NewLine;
                else
                    contents += champ.GetName() + ":" + champ.GetGames();
            }

            File.WriteAllText(champsPath, contents);
        }

        private void ChargeTips()
        {
            string cdsPath = Path.Combine(path, cdsFile);

            if (File.Exists(cdsPath))
            {
                string[] contents = File.ReadAllLines(cdsPath);

                foreach (string content in contents)
                {
                    string[] aux = content.Split(':');
                    string champ = aux[0];
                    string cds = aux[1];

                    allChampsManager.UniversalFindChamp(champ).SetCDs(cds.Split(';'));
                }
            }
        }

        private void ChargeCooldowns()
        {
            string tipsPath = Path.Combine(path, tipsFile);

            if (File.Exists(tipsPath))
            {
                string[] contents = File.ReadAllLines(tipsPath);

                foreach (string content in contents)
                {
                    string[] aux = content.Split(':');
                    string champ = aux[0];
                    string tip = aux[1];

                    allChampsManager.UniversalFindChamp(champ).SetTips(tip);
                }
            }
        }

        private void ChargeCounters()
        {
            string countersPath = Path.Combine(path, countersFile);

            if (File.Exists(countersPath))
            {
                string[] contents = File.ReadAllLines(countersPath);

                foreach(string content in contents)
                {
                    string[] aux = content.Split(':');
                    string champ = aux[0];
                    string[] counters = aux[1].Split(',');

                    Champion toModify = allChampsManager.UniversalFindChamp(champ);

                    for(int i = 0; i < counters.Length; i++)
                    {
                        Champion auxChamp = allChampsManager.UniversalFindChamp(counters[i]);

                        if (i < counters.Length / 3)
                            toModify.AddVeryCounter(auxChamp);

                        else if (i < (counters.Length * 2) / 3)
                            toModify.AddGoodCounter(auxChamp);

                        else
                            toModify.AddMediumCounter(auxChamp);
                    }                        
                }
            }
        }

        private void ChargeAlias()
        {
            string aliasPath = Path.Combine(path, aliasFile);

            if (File.Exists(aliasPath))
            {
                string[] contents = File.ReadAllLines(aliasPath);

                foreach(string champ in contents)
                {
                    string[] allAlias = champ.Split(';');
                    Champion toModify = allChampsManager.UniversalFindChamp(allAlias[0]);
                    
                    foreach(string a in allAlias)
                    {
                        if (a != toModify.GetName())
                            toModify.AddAlias(a);
                    }
                }
            }
        }

        private void ChargeChamps()
        {
            string champsPath = Path.Combine(path, champsFile);

            if (File.Exists(champsPath))
            {
                string[] contents = File.ReadAllLines(champsPath);

                foreach(string champ in contents)
                {
                    string champName = champ.Split(':')[0];
                    int champGames = int.Parse(champ.Split(':')[1]);

                    Champion champion = new Champion();
                    champion.SetName(champName);
                    champion.SetSquare((Image)Properties.Resources.ResourceManager.GetObject(champName + "Square"));
                    champion.SetInfo((Image)Properties.Resources.ResourceManager.GetObject(champName + "Info"));
                    champion.SetGames(champGames);

                    allChampsManager.AddChamp(champion);
                }
            }
        }

        private void ChargePool()
        {
            string poolFile = SoloQ ? poolSFile : poolTFile;
            
            string poolPath = Path.Combine(path, poolFile);
            
            if (File.Exists(poolPath))
            {
                string[] contents = File.ReadAllText(poolPath).Split(',');

                foreach(string content in contents)
                    poolManager.AddChamp(allChampsManager.UniversalFindChamp(content));
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

            pctAmounts[0] = pctAmount0;
            pctAmounts[1] = pctAmount1;
            pctAmounts[2] = pctAmount2;
            pctAmounts[3] = pctAmount3;
            pctAmounts[4] = pctAmount4;
            pctAmounts[5] = pctAmount5;
            pctAmounts[6] = pctAmount6;
            pctAmounts[7] = pctAmount7;
            pctAmounts[8] = pctAmount8;
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

            info.Show();
        }

        private void ShowInfo(int picNumber)
        {
            if (champCounters[picNumber] == null)
                return;

            info = new ExtraInfo();

            info.Text = champCounters[picNumber].GetName();
            info.pctMain.Image = champCounters[picNumber].GetInfo();

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
            List<Champion> Pool = poolManager.GetChampions();

            info = new ExtraInfo();

            info.Text = Pool[picNumber].GetName();
            info.pctMain.Image = Pool[picNumber].GetInfo();

            info.Show();
        }

        private void ShowTips()
        {
            if (actualChamp.GetTips() == null)
                return;

            TipsForm form = new TipsForm();

            form.Text = actualChamp.GetName();
            form.lblTips.Text = Modules.Internal.SubdivideString(actualChamp.GetTips());

            form.Show();
        }

        private void InitPage(string pagePath)
        {
            System.Diagnostics.Process.Start(pagePath);
        }

        private void RefreshChampGames(int picNumber, char MoL)
        {
            List<Champion> Pool = poolManager.GetChampions();

            if (MoL == '+')
            {
                Pool[picNumber].AddGame();
                poolForm.games++;
            }
            else
            {
                Pool[picNumber].SubGame();
                poolForm.games--;
            }

            RefreshCounts(picNumber);
            WriteGames();
        }

        private void RefreshCounts(int lblNumber)
        {
            List<Champion> Pool = poolManager.GetChampions();

            if(Pool[lblNumber].GetObjGames() != 0)
            {
                if (Pool[lblNumber].GetGames() >= Pool[lblNumber].GetObjGames())
                {
                    lblGamesCount[lblNumber].Text = "✓";
                    lblGamesCount[lblNumber].ForeColor = Color.Green;
                    lblGamesCount[lblNumber].Font = new Font(this.Font, FontStyle.Bold);
                }
                else
                {
                    lblGamesCount[lblNumber].Text = Pool[lblNumber].GetGames().ToString() + "/" + Pool[lblNumber].GetObjGames().ToString();
                    lblGamesCount[lblNumber].ForeColor = Color.Black;
                    lblGamesCount[lblNumber].Font = new Font(this.Font, FontStyle.Regular);
                }
            }
            else
            {
                //lblGamesCount[lblNumber].Text = Pool[lblNumber].GetGames().ToString();
            }
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
                actualChamp = allChampsManager.UniversalFindChamp(txtChamp.Text);

                pctChamp.Image = actualChamp.GetSquare();
                tipMainChamp.SetToolTip(pctChamp, Modules.Internal.SubdivideString(actualChamp.GetTips()));

                List<Champion> poolChampions = poolManager.GetChampions();
                int count = 0;
                int amount;

                foreach (Champion champ in poolChampions)
                {
                    if (champ.Counters(actualChamp, out amount) && count < 9)
                    {
                        pictureBoxes[count].Image = champ.GetSquare();
                        champCounters[count] = champ;

                        switch (amount)
                        {
                            case 3:
                                pctAmounts[count].BackColor = Color.Green;
                                break;
                            case 2:
                                pctAmounts[count].BackColor = Color.Yellow;
                                break;
                            case 1:
                                pctAmounts[count].BackColor = Color.Red;
                                break;
                        }

                        pctAmounts[count].Visible = true;

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

        private void tipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTips();
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

            switch ((e.Button))
            {
                case (MouseButtons.Left):
                    {
                        RefreshChampGames(number, '+');
                        return;
                    }
                case (MouseButtons.Right):
                    {
                        RefreshChampGames(number, '-');
                        return;
                    }
                case (MouseButtons.Middle):
                    {
                        ShowPoolInfo(number);
                        return;
                    }                    


                default:
                    break;
            }
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
    }
}