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
    public partial class PoolForm : Form
    {
        public bool pinned = false;
        public const string wallFile = "wall.pc";
        public const string configFile = "config.pc";
        public int games;

        public PoolForm()
        {
            InitializeComponent();
            ReadConfig();
        }

        private void ReadConfig()
        {
            string wallPath = Path.Combine("files", wallFile);
            string configPath = Path.Combine("files", configFile);

            if (File.Exists(wallPath))
            {
                this.BackgroundImage = (Bitmap)Bitmap.FromFile(File.ReadAllText(wallPath));
            }
        }

        private void WriteConfig(string filePath)
        {
            string wallPath = Path.Combine("files", wallFile);

            File.WriteAllText(wallPath, filePath);
        }

        private void DeleteConfig()
        {
            string path = Path.Combine("files", wallFile);

            if (File.Exists(path))
                File.Delete(path);
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            if (!pinned)
            {
                this.TopMost = true;
                this.btnPin.Image = Properties.Resources.unpin;
                pinned = true;
            }
            else
            {
                this.TopMost = false;
                this.btnPin.Image = Properties.Resources.pin;
                pinned = false;
            }
        }

        private void PoolForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            Bitmap bitmap = new Bitmap(Bitmap.FromFile(filePaths[0]));

            this.BackgroundImage = bitmap;
            //this.BackgroundImageLayout = ImageLayout.Center;

            WriteConfig(filePaths[0]);
        }

        private void PoolForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            DeleteConfig();
        }

        private void opGGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitPage(@"https://las.op.gg/summoner/userName=" + lblOpGg.Text);
        }

        private void leagueOfGraphsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitPage(@"https://www.leagueofgraphs.com/es/summoner/las/" + lblOpGg.Text);
        }

        private void InitPage(string pagePath)
        {
            System.Diagnostics.Process.Start(pagePath);
        }
    }
}
