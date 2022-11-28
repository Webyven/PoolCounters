
namespace Pool_Counters_v2._0
{
    partial class fPoolEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPoolEditor));
            this.titleBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblTitleBar = new System.Windows.Forms.Label();
            this.pctTitleBar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtChamp = new Guna.UI2.WinForms.Guna2TextBox();
            this.pctChamp = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.poolPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTitleBar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctChamp)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.Black;
            this.titleBar.Controls.Add(this.guna2ControlBox1);
            this.titleBar.Controls.Add(this.lblTitleBar);
            this.titleBar.Controls.Add(this.pctTitleBar);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.titleBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.ShadowDecoration.Parent = this.titleBar;
            this.titleBar.Size = new System.Drawing.Size(400, 30);
            this.titleBar.TabIndex = 17;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(355, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 30);
            this.guna2ControlBox1.TabIndex = 2;
            this.guna2ControlBox1.UseTransparentBackground = true;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // lblTitleBar
            // 
            this.lblTitleBar.AutoSize = true;
            this.lblTitleBar.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBar.ForeColor = System.Drawing.Color.White;
            this.lblTitleBar.Location = new System.Drawing.Point(33, 8);
            this.lblTitleBar.Name = "lblTitleBar";
            this.lblTitleBar.Size = new System.Drawing.Size(65, 15);
            this.lblTitleBar.TabIndex = 1;
            this.lblTitleBar.Text = "Pool Editor";
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
            this.pctTitleBar.TabIndex = 0;
            this.pctTitleBar.TabStop = false;
            this.pctTitleBar.UseTransparentBackground = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderRadius = 10;
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtChamp);
            this.panel1.Controls.Add(this.pctChamp);
            this.panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.ShadowDecoration.Parent = this.panel1;
            this.panel1.Size = new System.Drawing.Size(175, 75);
            this.panel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.LightGray;
            this.btnAdd.FillColor2 = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(69, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(95, 23);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add Champion";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtChamp
            // 
            this.txtChamp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtChamp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtChamp.BackColor = System.Drawing.Color.Transparent;
            this.txtChamp.BorderRadius = 5;
            this.txtChamp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChamp.DefaultText = "";
            this.txtChamp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChamp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChamp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChamp.DisabledState.Parent = this.txtChamp;
            this.txtChamp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChamp.FocusedState.BorderColor = System.Drawing.Color.Silver;
            this.txtChamp.FocusedState.Parent = this.txtChamp;
            this.txtChamp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtChamp.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtChamp.HoverState.Parent = this.txtChamp;
            this.txtChamp.Location = new System.Drawing.Point(69, 13);
            this.txtChamp.Name = "txtChamp";
            this.txtChamp.PasswordChar = '\0';
            this.txtChamp.PlaceholderText = "";
            this.txtChamp.SelectedText = "";
            this.txtChamp.ShadowDecoration.Parent = this.txtChamp;
            this.txtChamp.Size = new System.Drawing.Size(95, 20);
            this.txtChamp.TabIndex = 0;
            this.txtChamp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChamp.TextChanged += new System.EventHandler(this.txtChamp_TextChanged);
            // 
            // pctChamp
            // 
            this.pctChamp.BackColor = System.Drawing.Color.Transparent;
            this.pctChamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctChamp.BorderRadius = 5;
            this.pctChamp.Cursor = System.Windows.Forms.Cursors.Default;
            this.pctChamp.Image = ((System.Drawing.Image)(resources.GetObject("pctChamp.Image")));
            this.pctChamp.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctChamp.InitialImage")));
            this.pctChamp.Location = new System.Drawing.Point(13, 13);
            this.pctChamp.Name = "pctChamp";
            this.pctChamp.ShadowDecoration.Parent = this.pctChamp;
            this.pctChamp.Size = new System.Drawing.Size(50, 50);
            this.pctChamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctChamp.TabIndex = 36;
            this.pctChamp.TabStop = false;
            this.pctChamp.UseTransparentBackground = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderRadius = 10;
            this.panel2.Controls.Add(this.poolPanel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel2.Location = new System.Drawing.Point(193, 40);
            this.panel2.Name = "panel2";
            this.panel2.ShadowDecoration.Parent = this.panel2;
            this.panel2.Size = new System.Drawing.Size(195, 75);
            this.panel2.TabIndex = 2;
            // 
            // poolPanel
            // 
            this.poolPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poolPanel.BackColor = System.Drawing.Color.Transparent;
            this.poolPanel.Location = new System.Drawing.Point(11, 28);
            this.poolPanel.Name = "poolPanel";
            this.poolPanel.Size = new System.Drawing.Size(172, 40);
            this.poolPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pool";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.guna2DragControl3.TargetControl = this.lblTitleBar;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this;
            // 
            // fPoolEditor
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(400, 125);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 125);
            this.Name = "fPoolEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pool Editor";
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTitleBar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctChamp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel titleBar;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label lblTitleBar;
        private Guna.UI2.WinForms.Guna2PictureBox pctTitleBar;
        private Guna.UI2.WinForms.Guna2Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtChamp;
        private Guna.UI2.WinForms.Guna2PictureBox pctChamp;
        private Guna.UI2.WinForms.Guna2Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel poolPanel;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
    }
}