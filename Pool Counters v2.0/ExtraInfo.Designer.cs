namespace Pool_Counters_v2._0
{
    partial class ExtraInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtraInfo));
            this.pctMain = new System.Windows.Forms.PictureBox();
            this.btnPin = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPin)).BeginInit();
            this.SuspendLayout();
            // 
            // pctMain
            // 
            this.pctMain.BackColor = System.Drawing.Color.Black;
            this.pctMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctMain.Location = new System.Drawing.Point(0, 0);
            this.pctMain.Name = "pctMain";
            this.pctMain.Size = new System.Drawing.Size(984, 411);
            this.pctMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctMain.TabIndex = 0;
            this.pctMain.TabStop = false;
            // 
            // btnPin
            // 
            this.btnPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPin.BackColor = System.Drawing.Color.Transparent;
            this.btnPin.FillColor = System.Drawing.Color.Transparent;
            this.btnPin.Image = global::Pool_Counters_v2._0.Properties.Resources.pinWhite;
            this.btnPin.Location = new System.Drawing.Point(957, 12);
            this.btnPin.Name = "btnPin";
            this.btnPin.ShadowDecoration.Parent = this.btnPin;
            this.btnPin.Size = new System.Drawing.Size(15, 15);
            this.btnPin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPin.TabIndex = 21;
            this.btnPin.TabStop = false;
            this.btnPin.UseTransparentBackground = true;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // ExtraInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(984, 411);
            this.Controls.Add(this.btnPin);
            this.Controls.Add(this.pctMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1000, 450);
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "ExtraInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extra Info";
            ((System.ComponentModel.ISupportInitialize)(this.pctMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pctMain;
        private Guna.UI2.WinForms.Guna2PictureBox btnPin;
    }
}