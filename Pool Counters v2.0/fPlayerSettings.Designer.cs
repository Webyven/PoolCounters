
using System.Drawing;

namespace Pool_Counters_v2._0
{
    partial class fPlayerSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPlayerSettings));
            this.titleBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pctTitleBar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txtNickname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRealNickname = new Guna.UI2.WinForms.Guna2TextBox();
            this.pctRole = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.barPadding = new Guna.UI2.WinForms.Guna2VTrackBar();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTitleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRole)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.Controls.Add(this.label1);
            this.titleBar.Controls.Add(this.pctTitleBar);
            this.titleBar.Controls.Add(this.guna2ControlBox1);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.titleBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.ShadowDecoration.Parent = this.titleBar;
            this.titleBar.Size = new System.Drawing.Size(250, 30);
            this.titleBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(32, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player Settings";
            // 
            // pctTitleBar
            // 
            this.pctTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.pctTitleBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pctTitleBar.Image = ((System.Drawing.Image)(resources.GetObject("pctTitleBar.Image")));
            this.pctTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pctTitleBar.Name = "pctTitleBar";
            this.pctTitleBar.Padding = new System.Windows.Forms.Padding(5);
            this.pctTitleBar.ShadowDecoration.Parent = this.pctTitleBar;
            this.pctTitleBar.Size = new System.Drawing.Size(30, 30);
            this.pctTitleBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTitleBar.TabIndex = 1;
            this.pctTitleBar.TabStop = false;
            this.pctTitleBar.UseTransparentBackground = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(205, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.UseTransparentBackground = true;
            this.guna2ControlBox1.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.titleBar;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.pctTitleBar;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.TargetControl = this.label1;
            // 
            // txtNickname
            // 
            this.txtNickname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNickname.BorderRadius = 5;
            this.txtNickname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNickname.DefaultText = "";
            this.txtNickname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNickname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNickname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNickname.DisabledState.Parent = this.txtNickname;
            this.txtNickname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNickname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtNickname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNickname.FocusedState.Parent = this.txtNickname;
            this.txtNickname.ForeColor = System.Drawing.Color.Silver;
            this.txtNickname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNickname.HoverState.Parent = this.txtNickname;
            this.txtNickname.Location = new System.Drawing.Point(12, 63);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.PasswordChar = '\0';
            this.txtNickname.PlaceholderText = "";
            this.txtNickname.SelectedText = "";
            this.txtNickname.ShadowDecoration.Parent = this.txtNickname;
            this.txtNickname.Size = new System.Drawing.Size(125, 25);
            this.txtNickname.TabIndex = 38;
            this.txtNickname.TextChanged += new System.EventHandler(this.txtNickname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nickname to show";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Real Nickname";
            // 
            // txtRealNickname
            // 
            this.txtRealNickname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRealNickname.BorderRadius = 5;
            this.txtRealNickname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRealNickname.DefaultText = "";
            this.txtRealNickname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRealNickname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRealNickname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRealNickname.DisabledState.Parent = this.txtRealNickname;
            this.txtRealNickname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRealNickname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.txtRealNickname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRealNickname.FocusedState.Parent = this.txtRealNickname;
            this.txtRealNickname.ForeColor = System.Drawing.Color.Silver;
            this.txtRealNickname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRealNickname.HoverState.Parent = this.txtRealNickname;
            this.txtRealNickname.Location = new System.Drawing.Point(12, 123);
            this.txtRealNickname.Name = "txtRealNickname";
            this.txtRealNickname.PasswordChar = '\0';
            this.txtRealNickname.PlaceholderText = "";
            this.txtRealNickname.SelectedText = "";
            this.txtRealNickname.ShadowDecoration.Parent = this.txtRealNickname;
            this.txtRealNickname.Size = new System.Drawing.Size(125, 25);
            this.txtRealNickname.TabIndex = 40;
            // 
            // pctRole
            // 
            this.pctRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pctRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctRole.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.pctRole.Location = new System.Drawing.Point(168, 65);
            this.pctRole.Name = "pctRole";
            this.pctRole.Padding = new System.Windows.Forms.Padding(Properties.Settings.Default.rolePadding);
            this.pctRole.ShadowDecoration.Color = System.Drawing.Color.White;
            this.pctRole.ShadowDecoration.Parent = this.pctRole;
            this.pctRole.Size = new System.Drawing.Size(50, 50);
            this.pctRole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRole.TabIndex = 41;
            this.pctRole.TabStop = false;
            this.pctRole.Click += new System.EventHandler(this.pctRole_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "Role Image";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.AddExtension = false;
            this.openFileDialog1.Filter = "Archivos de imagen|*.png; *.jpg; *.jpeg; *.bmp";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BorderRadius = 5;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FillColor = System.Drawing.Color.LightGray;
            this.btnSave.FillColor2 = System.Drawing.Color.White;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(158, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this.pctRole;
            // 
            // barPadding
            // 
            this.barPadding.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.barPadding.HoverState.FillColor = System.Drawing.Color.Silver;
            this.barPadding.HoverState.Parent = this.barPadding;
            this.barPadding.Location = new System.Drawing.Point(223, 67);
            this.barPadding.Maximum = 10;
            this.barPadding.MouseWheelBarPartitions = 1;
            this.barPadding.Name = "barPadding";
            this.barPadding.Size = new System.Drawing.Size(10, 45);
            this.barPadding.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.barPadding.TabIndex = 43;
            this.barPadding.ThumbColor = System.Drawing.Color.DimGray;
            this.barPadding.Value = global::Pool_Counters_v2._0.Properties.Settings.Default.rolePadding;
            this.barPadding.ValueChanged += new System.EventHandler(this.barPadding_ValueChanged);
            // 
            // fPlayerSettings
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(250, 165);
            this.Controls.Add(this.barPadding);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pctRole);
            this.Controls.Add(this.txtRealNickname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.titleBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fPlayerSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player Settings";
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTitleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel titleBar;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox pctTitleBar;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox pctRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        public Guna.UI2.WinForms.Guna2TextBox txtRealNickname;
        public Guna.UI2.WinForms.Guna2TextBox txtNickname;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2VTrackBar barPadding;
    }
}