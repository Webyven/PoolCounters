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
        int? actualFocus = null;

        public fSpells()
        {
            InitializeComponent();

            guna2Elipse2.BorderRadius = 15;
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.KeyDown += M_GlobalHook_KeyDown;

            foreach (Spell spell in SpellManager.GetSpells())
            {
                Controls.Add(new SpellControl(spell, menuSpells) { Dock = DockStyle.Fill });

                menuSpells.Items.Add(spell.Name, spell.Icon);
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
