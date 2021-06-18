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
            this.btnPin = new System.Windows.Forms.PictureBox();
            this.pctMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPin
            // 
            this.btnPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPin.BackColor = System.Drawing.Color.Black;
            this.btnPin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPin.Image = ((System.Drawing.Image)(resources.GetObject("btnPin.Image")));
            this.btnPin.Location = new System.Drawing.Point(957, 12);
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(15, 15);
            this.btnPin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPin.TabIndex = 20;
            this.btnPin.TabStop = false;
            this.btnPin.Click += new System.EventHandler(this.btnPin_Click);
            // 
            // pctMain
            // 
            this.pctMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctMain.Location = new System.Drawing.Point(0, 0);
            this.pctMain.Name = "pctMain";
            this.pctMain.Size = new System.Drawing.Size(984, 411);
            this.pctMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMain.TabIndex = 0;
            this.pctMain.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.btnPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pctMain;
        private System.Windows.Forms.PictureBox btnPin;
    }
}