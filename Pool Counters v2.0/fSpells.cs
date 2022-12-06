using Gma.System.MouseKeyHook;
using Guna.UI2.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Counters_v2._0
{
    public partial class fSpells : Form, ITitleable
    {
        Guna2GradientPanel ITitleable.titleBar => this.titleBar;
        IKeyboardMouseEvents m_GlobalHook;
        SpellControl[,] spells = new SpellControl[5,2];

        public fSpells()
        {
            InitializeComponent();
            InitializeSpellPlayerControls();
            InitializeSpellsControls();

            guna2Elipse2.BorderRadius = 15;
            Properties.Settings.Default.editSpellsMode = false;
            this.showTimeInSecondsToolStripMenuItem.Checked = Properties.Settings.Default.showTimeInSeconds;
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.KeyDown += M_GlobalHook_KeyDown;

            foreach (Spell spell in SpellManager.GetSpells())
                menuSpells.Items.Add(spell.Name, spell.Icon);
        }

        private void InitializeSpellPlayerControls()
        {
            string[] pictures = string.IsNullOrEmpty(Properties.Settings.Default.spellsRoles) ? new string[5] :
                JsonConvert.DeserializeObject<string[]>(Properties.Settings.Default.spellsRoles);

            spellTopControl.SetPictureLane(string.IsNullOrEmpty(pictures[0]) ?
                Properties.Resources.Position_Grandmaster_Top : Image.FromFile(pictures[0]));

            spellJungleControl.SetPictureLane(string.IsNullOrEmpty(pictures[1]) ?
                Properties.Resources.Position_Grandmaster_Jungle : Image.FromFile(pictures[1]));

            spellMiddleControl.SetPictureLane(string.IsNullOrEmpty(pictures[2]) ?
                Properties.Resources.Position_Grandmaster_Mid : Image.FromFile(pictures[2]));

            spellCarryControl.SetPictureLane(string.IsNullOrEmpty(pictures[3]) ?
                Properties.Resources.Position_Grandmaster_Bot : Image.FromFile(pictures[3]));

            spellSupportControl.SetPictureLane(string.IsNullOrEmpty(pictures[4]) ?
                Properties.Resources.Position_Grandmaster_Support : Image.FromFile(pictures[4]));
        }

        private void InitializeSpellsControls()
        {
            spells[0, 0] = this.spellTopControl.spellD;
            spells[0, 1] = this.spellTopControl.spellF;
            spells[1, 0] = this.spellJungleControl.spellD;
            spells[1, 1] = this.spellJungleControl.spellF;
            spells[2, 0] = this.spellMiddleControl.spellD;
            spells[2, 1] = this.spellMiddleControl.spellF;
            spells[3, 0] = this.spellCarryControl.spellD;
            spells[3, 1] = this.spellCarryControl.spellF;
            spells[4, 0] = this.spellSupportControl.spellD;
            spells[4, 1] = this.spellSupportControl.spellF;

            Spell[,] defaultSpells = SpellManager.DefaultSpells();

            for(int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    spells[i, k].SetSpell(defaultSpells[i, k]);
                    spells[i, k].SetContextMenuStrip(this.menuSpells);
                }
            }

            Focus.OnFocusChanged += Focus_OnFocusChanged;
            Focus_OnFocusChanged();
        }

        private void Focus_OnFocusChanged()
        {
            SpellControl spell = spells[Focus.Y, Focus.X];

            try
            {
                this.pctIndicator.Location = new Point(spell.Location.X + 35,
                                        spell.Parent.Location.Y + 64);
            }
            catch { }
        }


        private void M_GlobalHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift)
            {
                if (e.KeyCode == Keys.Right)
                    Focus.Right();
                else if (e.KeyCode == Keys.Left)
                    Focus.Left();
                else if (e.KeyCode == Keys.Up)
                    Focus.Up();
                else if (e.KeyCode == Keys.Down)
                    Focus.Down();
                else if (e.KeyCode == Keys.Space)
                    spells[Focus.Y, Focus.X].SpellControl_Click(null, null);
                else if (e.KeyCode == Keys.J)
                    ((SpellPlayerControl)spells[Focus.Y, Focus.X].Parent).ChangeJonias();
                else if (e.KeyCode == Keys.C)
                    ((SpellPlayerControl)spells[Focus.Y, Focus.X].Parent).ChangeCosmicInsight();
                else if (e.KeyCode == Keys.P)
                    btnPlay.PerformClick();
                else if (e.KeyCode == Keys.E)
                    btnEditMode.PerformClick();
            }
        }

        private void pctTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            menuOptions.Show(this.pctTitleBar, this.pctTitleBar.Location.X, 30);
        }

        private void showTimeInSecondsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.showTimeInSeconds = showTimeInSecondsToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnEditMode_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.editSpellsMode = !Properties.Settings.Default.editSpellsMode;
            Properties.Settings.Default.Save();

            btnEditMode.Image = Properties.Settings.Default.editSpellsMode ?
                                Properties.Resources.Cancel : Properties.Resources.Edit;

            editToolTip.SetToolTip(btnEditMode, Properties.Settings.Default.editSpellsMode ?
                                            @"Click to <strong>stop editing</strong>" :
                                            @"Click to <strong>edit</strong> the spells below");

            editToolTip.ToolTipTitle = Properties.Settings.Default.editSpellsMode ?
                                        "Cancel edit" : "Edit";
        }

        private void fSpells_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.editSpellsMode = false;
            Properties.Settings.Default.Save();
        }

        int timeCount = 0;

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.lblTitleBar.Text = "Spells";
            this.timeCount = 0;
            this.gameTimer.Enabled = !this.gameTimer.Enabled;

            if (!this.gameTimer.Enabled)
                ResetTeleport();

            btnPlay.Image = this.gameTimer.Enabled ?
                            Properties.Resources.StopIcon :
                            Properties.Resources.PlayButton;

            playToolTip.SetToolTip(btnPlay, this.gameTimer.Enabled ?
                                            @"Click <strong>to stop</strong> tracking." :
                                            @"Click <strong>when the game starts</strong><br>to start tracking spell cooldowns.");

            playToolTip.ToolTipTitle = this.gameTimer.Enabled ?
                                        "Stop" : "Play";
        }

        private void ResetTeleport()
        {
            foreach(SpellControl control in spells)
            {
                if (control.spell.Name.ToLower() == "Teleport".ToLower())
                    control.SetSpell(SpellManager.FindSpell("Teleport"));
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timeCount++;
            TimeSpan span = new TimeSpan(0, 0, timeCount);
            this.lblTitleBar.Text = string.Format("Spells - {0}", span.ToString());

            if (span.TotalMinutes == 14)
                UpgradeTeleports();
        }

        private void UpgradeTeleports()
        {
            foreach(SpellControl control in spells)
            {
                if (control.spell.Name.ToLower() == "Teleport".ToLower())
                    control.SetSpell(Spell.UpgradedTeleport());
            }
        }

        private delegate void OnFocusChanged();

        private static class Focus
        {
            public static event OnFocusChanged OnFocusChanged;

            private static int x = 0, y = 0;
            private static int MAX_X = 1;
            private static int MAX_Y = 4;

            public static int X
            {
                get { return x; }
                private set
                {
                    if (0 <= value && value <= MAX_X)
                        x = value;
                    else if (value > MAX_X)
                        x = 0;
                    else
                        x = MAX_X;

                    OnFocusChanged?.Invoke();
                }
            }

            public static int Y
            {
                get { return y; }
                private set
                {
                    if (0 <= value && value <= MAX_Y)
                        y = value;
                    else if (value > MAX_Y)
                        y = 0;
                    else 
                        y = MAX_Y;

                    OnFocusChanged?.Invoke();
                }
            }

            public static void Right() { X++; }
            public static void Left() { X--; }
            public static void Up() { Y--; }
            public static void Down() { Y++; }
        }
    }
}
