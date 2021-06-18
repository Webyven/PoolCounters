namespace Pool_Counters_v2._0
{
    partial class PoolForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PoolForm));
            this.lblPool = new System.Windows.Forms.Label();
            this.lytPoolPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOpGg = new System.Windows.Forms.Label();
            this.cmsPickSource = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OPGGToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.LeagueOfGraphsToolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPin = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.PictureBox();
            this.cmsPickSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPool
            // 
            this.lblPool.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPool.AutoSize = true;
            this.lblPool.BackColor = System.Drawing.Color.Transparent;
            this.lblPool.Font = new System.Drawing.Font("Fira Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPool.Location = new System.Drawing.Point(120, 9);
            this.lblPool.Name = "lblPool";
            this.lblPool.Size = new System.Drawing.Size(64, 25);
            this.lblPool.TabIndex = 14;
            this.lblPool.Text = "POOL";
            // 
            // lytPoolPanel
            // 
            this.lytPoolPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lytPoolPanel.AutoSize = true;
            this.lytPoolPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lytPoolPanel.BackColor = System.Drawing.Color.Transparent;
            this.lytPoolPanel.Location = new System.Drawing.Point(60, 39);
            this.lytPoolPanel.Name = "lytPoolPanel";
            this.lytPoolPanel.Size = new System.Drawing.Size(0, 0);
            this.lytPoolPanel.TabIndex = 18;
            // 
            // lblOpGg
            // 
            this.lblOpGg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOpGg.BackColor = System.Drawing.Color.Transparent;
            this.lblOpGg.ContextMenuStrip = this.cmsPickSource;
            this.lblOpGg.Font = new System.Drawing.Font("Clattering", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpGg.Location = new System.Drawing.Point(222, 44);
            this.lblOpGg.Name = "lblOpGg";
            this.lblOpGg.Size = new System.Drawing.Size(63, 39);
            this.lblOpGg.TabIndex = 0;
            this.lblOpGg.Text = "Weby";
            // 
            // cmsPickSource
            // 
            this.cmsPickSource.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OPGGToolStrip,
            this.LeagueOfGraphsToolTip});
            this.cmsPickSource.Name = "cmsPickSource";
            this.cmsPickSource.ShowImageMargin = false;
            this.cmsPickSource.ShowItemToolTips = false;
            this.cmsPickSource.Size = new System.Drawing.Size(138, 48);
            // 
            // OPGGToolStrip
            // 
            this.OPGGToolStrip.Name = "OPGGToolStrip";
            this.OPGGToolStrip.Size = new System.Drawing.Size(137, 22);
            this.OPGGToolStrip.Text = "OP.GG";
            this.OPGGToolStrip.Click += new System.EventHandler(this.opGGToolStripMenuItem_Click);
            // 
            // LeagueOfGraphsToolTip
            // 
            this.LeagueOfGraphsToolTip.Name = "LeagueOfGraphsToolTip";
            this.LeagueOfGraphsToolTip.Size = new System.Drawing.Size(137, 22);
            this.LeagueOfGraphsToolTip.Text = "LeagueOfGraphs";
            this.LeagueOfGraphsToolTip.Click += new System.EventHandler(this.leagueOfGraphsToolStripMenuItem_Click);
            // 
            // btnPin
            // 
            this.btnPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPin.BackColor = System.Drawing.Color.Transparent;
            this.btnPin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPin.Image = global::Pool_Counters_v2._0.Properties.Resources.pin;
            this.btnPin.Location = new System.Drawing.Point(273, 9);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(15, 15);
            this.btnPin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPin.TabIndex = 19;
            this.btnPin.TabStop = false;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Pool_Counters_v2._0.Properties.Resources.Top;
            this.pictureBox3.Location = new System.Drawing.Point(20, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pool_Counters_v2._0.Properties.Resources.BackgroundLeft;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Pool_Counters_v2._0.Properties.Resources.BackgroundRight;
            this.pictureBox2.Location = new System.Drawing.Point(270, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(252, 9);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(15, 15);
            this.btnReset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReset.TabIndex = 20;
            this.btnReset.TabStop = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // PoolForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(300, 100);
            this.ControlBox = false;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPin);
            this.Controls.Add(this.lblOpGg);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lytPoolPanel);
            this.Controls.Add(this.lblPool);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PoolForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PoolForm";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.PoolForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.PoolForm_DragEnter);
            this.cmsPickSource.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label lblPool;
        public System.Windows.Forms.FlowLayoutPanel lytPoolPanel;
        private System.Windows.Forms.Label lblOpGg;
        private System.Windows.Forms.PictureBox btnPin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnReset;
        private System.Windows.Forms.ContextMenuStrip cmsPickSource;
        public System.Windows.Forms.ToolStripMenuItem OPGGToolStrip;
        public System.Windows.Forms.ToolStripMenuItem LeagueOfGraphsToolTip;
    }
}