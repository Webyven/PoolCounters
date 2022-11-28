using Gma.System.MouseKeyHook;
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
    public partial class fSpells : Form, ITitleable
    {
        Guna2GradientPanel ITitleable.titleBar => this.titleBar;
        IKeyboardMouseEvents m_GlobalHook;
        SpellControl[,] spells = new SpellControl[5,2];
        int[,] actualFocus = new int[1, 2] { { 0, 0 } }; 

        public fSpells()
        {
            InitializeComponent();
            InitializeSpellsControls();

            guna2Elipse2.BorderRadius = 15;
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.KeyDown += M_GlobalHook_KeyDown;

            foreach (Spell spell in SpellManager.GetSpells())
                menuSpells.Items.Add(spell.Name, spell.Icon);
        }

        private void InitializeSpellsControls()
        {
            spells[0, 0] = this.spellTopD;
            spells[0, 1] = this.spellTopF;
            spells[1, 0] = this.spellJungleD;
            spells[1, 1] = this.spellJungleF;
            spells[2, 0] = this.spellMiddleD;
            spells[2, 1] = this.spellMiddleF;
            spells[3, 0] = this.spellCarryD;
            spells[3, 1] = this.spellCarryF;
            spells[4, 0] = this.spellSupportD;
            spells[4, 1] = this.spellSupportF;

            Spell[,] defaultSpells = SpellManager.DefaultSpells();

            for(int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 2; k++)
                    spells[i, k].SetSpell(defaultSpells[i, k]);
            }
        }

        private void M_GlobalHook_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.Control && e.Shift)
            //{
            //    if(e.KeyCode == Keys.Right)
            //    {
            //        if(actualFocus == null)
            //            this.actualFocus = 0;
            //        else
            //            this.actualFocus += this.actualFocus < this.tableLayoutPanel1.Controls.Count ? 1 : 0;

            //        this.tableLayoutPanel1.Controls[this.actualFocus.Value].Focus();
            //    }

            //    if (e.KeyCode == Keys.Space)
            //        ((SpellControl)this.tableLayoutPanel1.Controls[0]).SpellControl_Click(null, null);
            //}
        }

        private void pctTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            menuOptions.Show(this.pctTitleBar, this.pctTitleBar.Location.X, 30);
        }
    }
}
