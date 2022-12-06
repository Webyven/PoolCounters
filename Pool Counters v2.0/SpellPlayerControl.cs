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
    public partial class SpellPlayerControl : UserControl
    {
        public SpellPlayerControl()
        {
            InitializeComponent();
            this.spellD.InitializeControl();
            this.spellF.InitializeControl();
        }

        public void SetPictureLane(Image image)
        {
            this.pctLane.Image = image;
        }

        public void ChangeJonias()
        {
            this.cbJonias.Checked = !this.cbJonias.Checked;
        }

        public void ChangeCosmicInsight()
        {
            this.cbCosmicInsight.Checked = !this.cbCosmicInsight.Checked;
        }

        private void cbJonias_CheckedChanged(object sender, EventArgs e)
        {
            this.spellD.SetJonias(true);
            this.spellF.SetJonias(true);
        }

        private void cbCosmicInsight_CheckedChanged(object sender, EventArgs e)
        {
            this.spellD.SetCosmicInsight(true);
            this.spellF.SetCosmicInsight(true);
        }

    }
}
