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
            this.btnEditMode = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pctTitleBar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTitleBar = new System.Windows.Forms.Label();
            this.guna2DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.menuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showTimeInSecondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.editToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.menuSpells = new Weby.CustomControls.Controls.DropDownMenu.WebyDropdownMenu(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pctIndicator = new System.Windows.Forms.PictureBox();
            this.spellSupportControl = new Pool_Counters_v2._0.SpellPlayerControl();
            this.spellCarryControl = new Pool_Counters_v2._0.SpellPlayerControl();
            this.spellMiddleControl = new Pool_Counters_v2._0.SpellPlayerControl();
            this.spellJungleControl = new Pool_Counters_v2._0.SpellPlayerControl();
            this.spellTopControl = new Pool_Counters_v2._0.SpellPlayerControl();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTitleBar)).BeginInit();
            this.menuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Black;
            this.titleBar.Controls.Add(this.btnPlay);
            this.titleBar.Controls.Add(this.btnEditMode);
            this.titleBar.Controls.Add(this.guna2ControlBox2);
            this.titleBar.Controls.Add(this.guna2ControlBox1);
            this.titleBar.Controls.Add(this.pctTitleBar);
            this.titleBar.Controls.Add(this.lblTitleBar);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.titleBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.ShadowDecoration.Parent = this.titleBar;
            this.titleBar.Size = new System.Drawing.Size(275, 30);
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
            this.btnPlay.Location = new System.Drawing.Point(120, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.PressedState.ImageSize = new System.Drawing.Size(14, 14);
            this.btnPlay.PressedState.Parent = this.btnPlay;
            this.btnPlay.Size = new System.Drawing.Size(35, 30);
            this.btnPlay.TabIndex = 6;
            this.playToolTip.SetToolTip(this.btnPlay, "Click <strong>when the game starts</strong>\r\n<br>\r\nto start tracking spell cooldo" +
        "wns.");
            this.btnPlay.UseTransparentBackground = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnEditMode
            // 
            this.btnEditMode.BackColor = System.Drawing.Color.Transparent;
            this.btnEditMode.CheckedState.Parent = this.btnEditMode;
            this.btnEditMode.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEditMode.HoverState.ImageSize = new System.Drawing.Size(15, 15);
            this.btnEditMode.HoverState.Parent = this.btnEditMode;
            this.btnEditMode.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMode.Image")));
            this.btnEditMode.ImageSize = new System.Drawing.Size(15, 15);
            this.btnEditMode.Location = new System.Drawing.Point(155, 0);
            this.btnEditMode.Name = "btnEditMode";
            this.btnEditMode.PressedState.ImageSize = new System.Drawing.Size(14, 14);
            this.btnEditMode.PressedState.Parent = this.btnEditMode;
            this.btnEditMode.Size = new System.Drawing.Size(35, 30);
            this.btnEditMode.TabIndex = 5;
            this.editToolTip.SetToolTip(this.btnEditMode, "Click to <strong>edit</strong> the spells below");
            this.btnEditMode.UseTransparentBackground = true;
            this.btnEditMode.Click += new System.EventHandler(this.btnEditMode_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(190, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(40, 30);
            this.guna2ControlBox2.TabIndex = 7;
            this.guna2ControlBox2.UseTransparentBackground = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(230, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox1.TabIndex = 4;
            this.guna2ControlBox1.UseTransparentBackground = true;
            // 
            // pctTitleBar
            // 
            this.pctTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.pctTitleBar.Image = ((System.Drawing.Image)(resources.GetObject("pctTitleBar.Image")));
            this.pctTitleBar.Location = new System.Drawing.Point(0, 1);
            this.pctTitleBar.Name = "pctTitleBar";
            this.pctTitleBar.ShadowDecoration.Parent = this.pctTitleBar;
            this.pctTitleBar.Size = new System.Drawing.Size(30, 30);
            this.pctTitleBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTitleBar.TabIndex = 1;
            this.pctTitleBar.TabStop = false;
            this.pctTitleBar.UseTransparentBackground = true;
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
            this.showTimeInSecondsToolStripMenuItem});
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.Size = new System.Drawing.Size(190, 26);
            // 
            // showTimeInSecondsToolStripMenuItem
            // 
            this.showTimeInSecondsToolStripMenuItem.CheckOnClick = true;
            this.showTimeInSecondsToolStripMenuItem.Name = "showTimeInSecondsToolStripMenuItem";
            this.showTimeInSecondsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.showTimeInSecondsToolStripMenuItem.Text = "Show time in seconds";
            this.showTimeInSecondsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showTimeInSecondsToolStripMenuItem_CheckedChanged);
            // 
            // playToolTip
            // 
            this.playToolTip.AllowLinksHandling = true;
            this.playToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.playToolTip.BorderColor = System.Drawing.Color.Maroon;
            this.playToolTip.ForeColor = System.Drawing.Color.Silver;
            this.playToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.playToolTip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.playToolTip.ToolTipTitle = "<strong>Play (Ctrl + Shift + P)</strong>";
            // 
            // editToolTip
            // 
            this.editToolTip.AllowLinksHandling = true;
            this.editToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.editToolTip.BorderColor = System.Drawing.Color.Maroon;
            this.editToolTip.ForeColor = System.Drawing.Color.Silver;
            this.editToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this.editToolTip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.editToolTip.ToolTipTitle = "Edit <strong>(Ctrl + Shift + E)</strong>";
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
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // pctIndicator
            // 
            this.pctIndicator.Image = ((System.Drawing.Image)(resources.GetObject("pctIndicator.Image")));
            this.pctIndicator.Location = new System.Drawing.Point(168, 107);
            this.pctIndicator.Name = "pctIndicator";
            this.pctIndicator.Size = new System.Drawing.Size(10, 10);
            this.pctIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctIndicator.TabIndex = 10;
            this.pctIndicator.TabStop = false;
            // 
            // spellSupportControl
            // 
            this.spellSupportControl.BackColor = System.Drawing.Color.Transparent;
            this.spellSupportControl.Location = new System.Drawing.Point(12, 346);
            this.spellSupportControl.Name = "spellSupportControl";
            this.spellSupportControl.Size = new System.Drawing.Size(250, 70);
            this.spellSupportControl.TabIndex = 9;
            // 
            // spellCarryControl
            // 
            this.spellCarryControl.BackColor = System.Drawing.Color.Transparent;
            this.spellCarryControl.Location = new System.Drawing.Point(12, 270);
            this.spellCarryControl.Name = "spellCarryControl";
            this.spellCarryControl.Size = new System.Drawing.Size(250, 70);
            this.spellCarryControl.TabIndex = 8;
            // 
            // spellMiddleControl
            // 
            this.spellMiddleControl.BackColor = System.Drawing.Color.Transparent;
            this.spellMiddleControl.Location = new System.Drawing.Point(12, 194);
            this.spellMiddleControl.Name = "spellMiddleControl";
            this.spellMiddleControl.Size = new System.Drawing.Size(250, 70);
            this.spellMiddleControl.TabIndex = 7;
            // 
            // spellJungleControl
            // 
            this.spellJungleControl.BackColor = System.Drawing.Color.Transparent;
            this.spellJungleControl.Location = new System.Drawing.Point(12, 118);
            this.spellJungleControl.Name = "spellJungleControl";
            this.spellJungleControl.Size = new System.Drawing.Size(250, 70);
            this.spellJungleControl.TabIndex = 6;
            // 
            // spellTopControl
            // 
            this.spellTopControl.BackColor = System.Drawing.Color.Transparent;
            this.spellTopControl.Location = new System.Drawing.Point(12, 42);
            this.spellTopControl.Name = "spellTopControl";
            this.spellTopControl.Size = new System.Drawing.Size(250, 70);
            this.spellTopControl.TabIndex = 5;
            // 
            // fSpells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(275, 430);
            this.Controls.Add(this.pctIndicator);
            this.Controls.Add(this.spellSupportControl);
            this.Controls.Add(this.spellCarryControl);
            this.Controls.Add(this.spellMiddleControl);
            this.Controls.Add(this.spellJungleControl);
            this.Controls.Add(this.spellTopControl);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSpells";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Spells";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fSpells_FormClosed);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTitleBar)).EndInit();
            this.menuOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctIndicator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel titleBar;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2PictureBox pctTitleBar;
        private System.Windows.Forms.Label lblTitleBar;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.ContextMenuStrip menuOptions;
        private System.Windows.Forms.ToolStripMenuItem showTimeInSecondsToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ImageButton btnPlay;
        private Guna.UI2.WinForms.Guna2ImageButton btnEditMode;
        private Guna.UI2.WinForms.Guna2HtmlToolTip playToolTip;
        private Guna.UI2.WinForms.Guna2HtmlToolTip editToolTip;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        public Weby.CustomControls.Controls.DropDownMenu.WebyDropdownMenu menuSpells;
        private SpellPlayerControl spellSupportControl;
        private SpellPlayerControl spellCarryControl;
        private SpellPlayerControl spellMiddleControl;
        private SpellPlayerControl spellJungleControl;
        private SpellPlayerControl spellTopControl;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pctIndicator;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}