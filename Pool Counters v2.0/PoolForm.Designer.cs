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
            this.cmsPickSource = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OPGGToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.LeagueOfGraphsToolTip = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.MainGradientPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnSettings = new System.Windows.Forms.PictureBox();
            this.btnAppearance = new System.Windows.Forms.PictureBox();
            this.btnPin = new System.Windows.Forms.PictureBox();
            this.lblOpGg = new System.Windows.Forms.Label();
            this.lytPoolPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pctRole = new System.Windows.Forms.PictureBox();
            this.lblPool = new System.Windows.Forms.Label();
            this.guna2Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.cmsPickSource.SuspendLayout();
            this.MainGradientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAppearance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRole)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsPickSource
            // 
            this.cmsPickSource.ImageScalingSize = new System.Drawing.Size(24, 24);
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
            // guna2DragControl
            // 
            this.guna2DragControl.TargetControl = this.MainGradientPanel;
            // 
            // MainGradientPanel
            // 
            this.MainGradientPanel.Controls.Add(this.btnSettings);
            this.MainGradientPanel.Controls.Add(this.btnAppearance);
            this.MainGradientPanel.Controls.Add(this.btnPin);
            this.MainGradientPanel.Controls.Add(this.lblOpGg);
            this.MainGradientPanel.Controls.Add(this.lytPoolPanel);
            this.MainGradientPanel.Controls.Add(this.pctRole);
            this.MainGradientPanel.Controls.Add(this.lblPool);
            this.MainGradientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGradientPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.MainGradientPanel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.MainGradientPanel.Location = new System.Drawing.Point(0, 0);
            this.MainGradientPanel.Name = "MainGradientPanel";
            this.MainGradientPanel.ShadowDecoration.Parent = this.MainGradientPanel;
            this.MainGradientPanel.Size = new System.Drawing.Size(300, 100);
            this.MainGradientPanel.TabIndex = 21;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(231, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(15, 15);
            this.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSettings.TabIndex = 22;
            this.btnSettings.TabStop = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAppearance
            // 
            this.btnAppearance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppearance.BackColor = System.Drawing.Color.Transparent;
            this.btnAppearance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAppearance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppearance.Image = ((System.Drawing.Image)(resources.GetObject("btnAppearance.Image")));
            this.btnAppearance.Location = new System.Drawing.Point(252, 12);
            this.btnAppearance.Name = "btnAppearance";
            this.btnAppearance.Padding = new System.Windows.Forms.Padding(2);
            this.btnAppearance.Size = new System.Drawing.Size(15, 15);
            this.btnAppearance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAppearance.TabIndex = 21;
            this.btnAppearance.TabStop = false;
            this.btnAppearance.Click += new System.EventHandler(this.btnAppearance_Click);
            // 
            // btnPin
            // 
            this.btnPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPin.BackColor = System.Drawing.Color.Transparent;
            this.btnPin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPin.Image = global::Pool_Counters_v2._0.Properties.Resources.pinWhite;
            this.btnPin.Location = new System.Drawing.Point(273, 12);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(15, 15);
            this.btnPin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPin.TabIndex = 19;
            this.btnPin.TabStop = false;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // lblOpGg
            // 
            this.lblOpGg.AutoSize = true;
            this.lblOpGg.BackColor = System.Drawing.Color.Transparent;
            this.lblOpGg.ContextMenuStrip = this.cmsPickSource;
            this.lblOpGg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOpGg.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblOpGg.Font = new System.Drawing.Font("Clattering", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpGg.ForeColor = System.Drawing.Color.White;
            this.lblOpGg.Location = new System.Drawing.Point(227, 40);
            this.lblOpGg.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lblOpGg.Name = "lblOpGg";
            this.lblOpGg.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.lblOpGg.Size = new System.Drawing.Size(73, 44);
            this.lblOpGg.TabIndex = 0;
            this.lblOpGg.Text = "Weby";
            this.lblOpGg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOpGg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblOpGg_Click);
            // 
            // lytPoolPanel
            // 
            this.lytPoolPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lytPoolPanel.BackColor = System.Drawing.Color.Transparent;
            this.lytPoolPanel.Location = new System.Drawing.Point(60, 40);
            this.lytPoolPanel.Name = "lytPoolPanel";
            this.lytPoolPanel.Size = new System.Drawing.Size(145, 50);
            this.lytPoolPanel.TabIndex = 18;
            // 
            // pctRole
            // 
            this.pctRole.BackColor = System.Drawing.Color.Transparent;
            this.pctRole.Image = ((System.Drawing.Image)(resources.GetObject("pctRole.Image")));
            this.pctRole.Location = new System.Drawing.Point(8, 40);
            this.pctRole.Name = "pctRole";
            this.pctRole.Size = new System.Drawing.Size(50, 50);
            this.pctRole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRole.TabIndex = 2;
            this.pctRole.TabStop = false;
            // 
            // lblPool
            // 
            this.lblPool.BackColor = System.Drawing.Color.Transparent;
            this.lblPool.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPool.Font = new System.Drawing.Font("Fira Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPool.ForeColor = System.Drawing.Color.White;
            this.lblPool.Location = new System.Drawing.Point(0, 0);
            this.lblPool.Name = "lblPool";
            this.lblPool.Size = new System.Drawing.Size(300, 40);
            this.lblPool.TabIndex = 14;
            this.lblPool.Text = "POOL";
            this.lblPool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse
            // 
            this.guna2Elipse.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.lblPool;
            // 
            // PoolForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(300, 100);
            this.ControlBox = false;
            this.Controls.Add(this.MainGradientPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 100);
            this.Name = "PoolForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PoolForm_FormClosing);
            this.cmsPickSource.ResumeLayout(false);
            this.MainGradientPanel.ResumeLayout(false);
            this.MainGradientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAppearance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsPickSource;
        public System.Windows.Forms.ToolStripMenuItem OPGGToolStrip;
        public System.Windows.Forms.ToolStripMenuItem LeagueOfGraphsToolTip;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.PictureBox btnPin;
        public System.Windows.Forms.FlowLayoutPanel lytPoolPanel;
        public System.Windows.Forms.Label lblPool;
        private System.Windows.Forms.PictureBox pctRole;
        public System.Windows.Forms.Label lblOpGg;
        private Guna.UI2.WinForms.Guna2GradientPanel MainGradientPanel;
        private System.Windows.Forms.PictureBox btnAppearance;
        private System.Windows.Forms.PictureBox btnSettings;
    }
}