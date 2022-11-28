
namespace Pool_Counters_v2._0
{
    partial class CounterControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CounterControl));
            this.lblChamp = new System.Windows.Forms.Label();
            this.pctChamp = new Guna.UI2.WinForms.Guna2PictureBox();
            this.countersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctChamp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChamp
            // 
            this.lblChamp.AutoSize = true;
            this.lblChamp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChamp.Location = new System.Drawing.Point(74, 13);
            this.lblChamp.Name = "lblChamp";
            this.lblChamp.Size = new System.Drawing.Size(134, 13);
            this.lblChamp.TabIndex = 1;
            this.lblChamp.Text = "Aatrox is good against...";
            this.lblChamp.MouseEnter += new System.EventHandler(this.btnPrevious_MouseEnter);
            // 
            // pctChamp
            // 
            this.pctChamp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctChamp.BackgroundImage")));
            this.pctChamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctChamp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctChamp.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pctChamp.ErrorImage")));
            this.pctChamp.Location = new System.Drawing.Point(13, 13);
            this.pctChamp.Name = "pctChamp";
            this.pctChamp.ShadowDecoration.Parent = this.pctChamp;
            this.pctChamp.Size = new System.Drawing.Size(55, 55);
            this.pctChamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctChamp.TabIndex = 2;
            this.pctChamp.TabStop = false;
            this.pctChamp.MouseEnter += new System.EventHandler(this.pctChamp_MouseEnter);
            this.pctChamp.MouseLeave += new System.EventHandler(this.pctChamp_MouseLeave);
            // 
            // countersPanel
            // 
            this.countersPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countersPanel.BackColor = System.Drawing.Color.Transparent;
            this.countersPanel.Location = new System.Drawing.Point(104, 33);
            this.countersPanel.Name = "countersPanel";
            this.countersPanel.Size = new System.Drawing.Size(405, 35);
            this.countersPanel.TabIndex = 3;
            this.countersPanel.MouseEnter += new System.EventHandler(this.btnPrevious_MouseEnter);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.AutoRoundedCorners = true;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderRadius = 9;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.FillColor = System.Drawing.Color.Transparent;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Location = new System.Drawing.Point(515, 33);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(20, 35);
            this.btnNext.TabIndex = 40;
            this.btnNext.Text = ">";
            this.btnNext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnNext_MouseClick);
            this.btnNext.MouseEnter += new System.EventHandler(this.btnPrevious_MouseEnter);
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoRoundedCorners = true;
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BorderRadius = 9;
            this.btnPrevious.CheckedState.Parent = this.btnPrevious;
            this.btnPrevious.CustomImages.Parent = this.btnPrevious;
            this.btnPrevious.FillColor = System.Drawing.Color.Transparent;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.HoverState.Parent = this.btnPrevious;
            this.btnPrevious.Location = new System.Drawing.Point(78, 33);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.ShadowDecoration.Parent = this.btnPrevious;
            this.btnPrevious.Size = new System.Drawing.Size(20, 35);
            this.btnPrevious.TabIndex = 41;
            this.btnPrevious.Text = "<";
            this.btnPrevious.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPrevious_MouseClick);
            this.btnPrevious.MouseEnter += new System.EventHandler(this.btnPrevious_MouseEnter);
            // 
            // CounterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.countersPanel);
            this.Controls.Add(this.pctChamp);
            this.Controls.Add(this.lblChamp);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(15, 10, 15, 0);
            this.Name = "CounterControl";
            this.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.Size = new System.Drawing.Size(550, 80);
            this.MouseEnter += new System.EventHandler(this.btnPrevious_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.CounterControl_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pctChamp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel countersPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        public Guna.UI2.WinForms.Guna2PictureBox pctChamp;
        public System.Windows.Forms.Label lblChamp;
    }
}
