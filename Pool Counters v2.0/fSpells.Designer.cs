namespace Pool_Counters_v2._0
{
    partial class fSpells
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSpells));
            this.titleBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pctTitleBar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTitleBar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.guna2DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.menuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editSpellsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTimeInSecondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.editToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.menuSpells = new Weby.CustomControls.Controls.DropDownMenu.WebyDropdownMenu(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.spellTopD = new Pool_Counters_v2._0.SpellControl();
            this.spellJungleD = new Pool_Counters_v2._0.SpellControl();
            this.spellMiddleD = new Pool_Counters_v2._0.SpellControl();
            this.spellSupportD = new Pool_Counters_v2._0.SpellControl();
            this.spellCarryD = new Pool_Counters_v2._0.SpellControl();
            this.spellTopF = new Pool_Counters_v2._0.SpellControl();
            this.spellJungleF = new Pool_Counters_v2._0.SpellControl();
            this.spellMiddleF = new Pool_Counters_v2._0.SpellControl();
            this.spellSupportF = new Pool_Counters_v2._0.SpellControl();
            this.spellCarryF = new Pool_Counters_v2._0.SpellControl();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTitleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.menuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Black;
            this.titleBar.Controls.Add(this.btnPlay);
            this.titleBar.Controls.Add(this.guna2ImageButton1);
            this.titleBar.Controls.Add(this.guna2ControlBox1);
            this.titleBar.Controls.Add(this.pctTitleBar);
            this.titleBar.Controls.Add(this.lblTitleBar);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.titleBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.ShadowDecoration.Parent = this.titleBar;
            this.titleBar.Size = new System.Drawing.Size(280, 30);
            this.titleBar.TabIndex = 4;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.CheckedState.Parent = this.btnPlay;
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPlay.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnPlay.HoverState.Parent = this.btnPlay;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageSize = new System.Drawing.Size(15, 15);
            this.btnPlay.Location = new System.Drawing.Point(155, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.PressedState.ImageSize = new System.Drawing.Size(13, 13);
            this.btnPlay.PressedState.Parent = this.btnPlay;
            this.btnPlay.Size = new System.Drawing.Size(40, 30);
            this.btnPlay.TabIndex = 6;
            this.playToolTip.SetToolTip(this.btnPlay, "Click <strong>when the game starts</strong>\r\n<br>\r\nto start tracking spell cooldo" +
        "wns.");
            this.btnPlay.UseTransparentBackground = true;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2ImageButton1.Location = new System.Drawing.Point(195, 0);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(13, 13);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(40, 30);
            this.guna2ImageButton1.TabIndex = 5;
            this.editToolTip.SetToolTip(this.guna2ImageButton1, "Click to <strong>edit</strong> the spells below");
            this.guna2ImageButton1.UseTransparentBackground = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(235, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox1.TabIndex = 4;
            this.guna2ControlBox1.UseTransparentBackground = true;
            // 
            // pctTitleBar
            // 
            this.pctTitleBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pctTitleBar.Image = ((System.Drawing.Image)(resources.GetObject("pctTitleBar.Image")));
            this.pctTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pctTitleBar.Name = "pctTitleBar";
            this.pctTitleBar.ShadowDecoration.Parent = this.pctTitleBar;
            this.pctTitleBar.Size = new System.Drawing.Size(30, 30);
            this.pctTitleBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTitleBar.TabIndex = 1;
            this.pctTitleBar.TabStop = false;
            this.pctTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pctTitleBar_MouseUp);
            // 
            // lblTitleBar
            // 
            this.lblTitleBar.AutoSize = true;
            this.lblTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBar.ForeColor = System.Drawing.Color.White;
            this.lblTitleBar.Location = new System.Drawing.Point(32, 8);
            this.lblTitleBar.Name = "lblTitleBar";
            this.lblTitleBar.Size = new System.Drawing.Size(37, 15);
            this.lblTitleBar.TabIndex = 0;
            this.lblTitleBar.Text = "Spells";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(23, 179);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(23, 299);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(23, 239);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // guna2DragControl
            // 
            this.guna2DragControl.TargetControl = this.lblTitleBar;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.titleBar;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // menuOptions
            // 
            this.menuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSpellsToolStripMenuItem,
            this.showTimeInSecondsToolStripMenuItem});
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(190, 48);
            // 
            // editSpellsToolStripMenuItem
            // 
            this.editSpellsToolStripMenuItem.Name = "editSpellsToolStripMenuItem";
            this.editSpellsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.editSpellsToolStripMenuItem.Text = "Edit spells...";
            // 
            // showTimeInSecondsToolStripMenuItem
            // 
            this.showTimeInSecondsToolStripMenuItem.CheckOnClick = true;
            this.showTimeInSecondsToolStripMenuItem.Name = "showTimeInSecondsToolStripMenuItem";
            this.showTimeInSecondsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.showTimeInSecondsToolStripMenuItem.Text = "Show time in seconds";
            // 
            // playToolTip
            // 
            this.playToolTip.AllowLinksHandling = true;
            this.playToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.playToolTip.BorderColor = System.Drawing.Color.Maroon;
            this.playToolTip.ForeColor = System.Drawing.Color.Silver;
            this.playToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.playToolTip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.playToolTip.ToolTipTitle = "<strong>Play (Ctrl + P)</strong>";
            // 
            // editToolTip
            // 
            this.editToolTip.AllowLinksHandling = true;
            this.editToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.editToolTip.BorderColor = System.Drawing.Color.Maroon;
            this.editToolTip.ForeColor = System.Drawing.Color.Silver;
            this.editToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.editToolTip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editToolTip.ToolTipTitle = "Edit";
            // 
            // menuSpells
            // 
            this.menuSpells.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.menuSpells.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.menuSpells.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuSpells.MenuItemHeight = 10;
            this.menuSpells.MenuItemTextColor = System.Drawing.Color.WhiteSmoke;
            this.menuSpells.MenuItemWidth = 10;
            this.menuSpells.Name = "menuSpells";
            this.menuSpells.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuSpells.Size = new System.Drawing.Size(61, 4);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.menuSpells;
            // 
            // spellTopD
            // 
            this.spellTopD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.spellTopD.Location = new System.Drawing.Point(80, 55);
            this.spellTopD.Margin = new System.Windows.Forms.Padding(5);
            this.spellTopD.Name = "spellTopD";
            this.spellTopD.Size = new System.Drawing.Size(50, 50);
            this.spellTopD.TabIndex = 11;
            // 
            // spellJungleD
            // 
            this.spellJungleD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.spellJungleD.Location = new System.Drawing.Point(80, 115);
            this.spellJungleD.Margin = new System.Windows.Forms.Padding(5);
            this.spellJungleD.Name = "spellJungleD";
            this.spellJungleD.Size = new System.Drawing.Size(50, 50);
            this.spellJungleD.TabIndex = 12;
            // 
            // spellMiddleD
            // 
            this.spellMiddleD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.spellMiddleD.Location = new System.Drawing.Point(80, 175);
            this.spellMiddleD.Margin = new System.Windows.Forms.Padding(5);
            this.spellMiddleD.Name = "spellMiddleD";
            this.spellMiddleD.Size = new System.Drawing.Size(50, 50);
            this.spellMiddleD.TabIndex = 13;
            // 
            // spellSupportD
            // 
            this.spellSupportD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.spellSupportD.Location = new System.Drawing.Point(80, 295);
            this.spellSupportD.Margin = new System.Windows.Forms.Padding(5);
            this.spellSupportD.Name = "spellSupportD";
            this.spellSupportD.Size = new System.Drawing.Size(50, 50);
            this.spellSupportD.TabIndex = 14;
            // 
            // spellCarryD
            // 
            this.spellCarryD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.spellCarryD.Location = new System.Drawing.Point(80, 235);
            this.spellCarryD.Margin = new System.Windows.Forms.Padding(5);
            this.spellCarryD.Name = "spellCarryD";
            this.spellCarryD.Size = new System.Drawing.Size(50, 50);
            this.spellCarryD.TabIndex = 15;
            // 
            // spellTopF
            // 
            this.spellTopF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.spellTopF.Location = new System.Drawing.Point(143, 55);
            this.spellTopF.Margin = new System.Windows.Forms.Padding(5);
            this.spellTopF.Name = "spellTopF";
            this.spellTopF.Size = new System.Drawing.Size(50, 50);
            this.spellTopF.TabIndex = 16;
            // 
            // spellJungleF
            // 
            this.spellJungleF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.spellJungleF.Location = new System.Drawing.Point(143, 115);
            this.spellJungleF.Margin = new System.Windows.Forms.Padding(5);
            this.spellJungleF.Name = "spellJungleF";
            this.spellJungleF.Size = new System.Drawing.Size(50, 50);
            this.spellJungleF.TabIndex = 17;
            // 
            // spellMiddleF
            // 
            this.spellMiddleF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.spellMiddleF.Location = new System.Drawing.Point(143, 175);
            this.spellMiddleF.Margin = new System.Windows.Forms.Padding(5);
            this.spellMiddleF.Name = "spellMiddleF";
            this.spellMiddleF.Size = new System.Drawing.Size(50, 50);
            this.spellMiddleF.TabIndex = 18;
            // 
            // spellSupportF
            // 
            this.spellSupportF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.spellSupportF.Location = new System.Drawing.Point(143, 295);
            this.spellSupportF.Margin = new System.Windows.Forms.Padding(5);
            this.spellSupportF.Name = "spellSupportF";
            this.spellSupportF.Size = new System.Drawing.Size(50, 50);
            this.spellSupportF.TabIndex = 19;
            // 
            // spellCarryF
            // 
            this.spellCarryF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.spellCarryF.Location = new System.Drawing.Point(143, 235);
            this.spellCarryF.Margin = new System.Windows.Forms.Padding(5);
            this.spellCarryF.Name = "spellCarryF";
            this.spellCarryF.Size = new System.Drawing.Size(50, 50);
            this.spellCarryF.TabIndex = 20;
            // 
            // fSpells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(280, 370);
            this.ContextMenuStrip = this.menuSpells;
            this.Controls.Add(this.spellCarryF);
            this.Controls.Add(this.spellSupportF);
            this.Controls.Add(this.spellMiddleF);
            this.Controls.Add(this.spellJungleF);
            this.Controls.Add(this.spellTopF);
            this.Controls.Add(this.spellCarryD);
            this.Controls.Add(this.spellSupportD);
            this.Controls.Add(this.spellMiddleD);
            this.Controls.Add(this.spellJungleD);
            this.Controls.Add(this.spellTopD);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fSpells";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSpells";
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTitleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.menuOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel titleBar;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2PictureBox pctTitleBar;
        private System.Windows.Forms.Label lblTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ContextMenuStrip menuOptions;
        private System.Windows.Forms.ToolStripMenuItem editSpellsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTimeInSecondsToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ImageButton btnPlay;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip playToolTip;
        private Guna.UI2.WinForms.Guna2HtmlToolTip editToolTip;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private SpellControl spellCarryF;
        private SpellControl spellSupportF;
        private SpellControl spellMiddleF;
        private SpellControl spellJungleF;
        private SpellControl spellTopF;
        private SpellControl spellCarryD;
        private SpellControl spellSupportD;
        private SpellControl spellMiddleD;
        private SpellControl spellJungleD;
        private SpellControl spellTopD;
        public Weby.CustomControls.Controls.DropDownMenu.WebyDropdownMenu menuSpells;
    }
}