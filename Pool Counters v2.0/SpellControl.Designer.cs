using System.Drawing;

namespace Pool_Counters_v2._0
{
    partial class SpellControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpellControl));
            this.pctSpell = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cooldownProgress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pctSpell)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctSpell
            // 
            this.pctSpell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctSpell.BackgroundImage")));
            this.pctSpell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctSpell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctSpell.Enabled = false;
            this.pctSpell.Location = new System.Drawing.Point(0, 0);
            this.pctSpell.Name = "pctSpell";
            this.pctSpell.Size = new System.Drawing.Size(50, 50);
            this.pctSpell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSpell.TabIndex = 0;
            this.pctSpell.TabStop = false;
            this.pctSpell.Click += new System.EventHandler(this.SpellControl_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(0, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(50, 50);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimer.Visible = false;
            this.lblTimer.Click += new System.EventHandler(this.SpellControl_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.lblTimer);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.ForeColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(50, 50);
            this.guna2Panel1.TabIndex = 1;
            this.guna2Panel1.UseTransparentBackground = true;
            this.guna2Panel1.Click += new System.EventHandler(this.SpellControl_Click);
            // 
            // cooldownProgress
            // 
            this.cooldownProgress.BackColor = System.Drawing.Color.Transparent;
            this.cooldownProgress.EnsureVisible = true;
            this.cooldownProgress.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cooldownProgress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.cooldownProgress.Location = new System.Drawing.Point(-23, -23);
            this.cooldownProgress.Name = "cooldownProgress";
            this.cooldownProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.cooldownProgress.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.cooldownProgress.ProgressThickness = 50;
            this.cooldownProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.cooldownProgress.ShadowDecoration.Parent = this.cooldownProgress;
            this.cooldownProgress.Size = new System.Drawing.Size(100, 100);
            this.cooldownProgress.TabIndex = 42;
            this.cooldownProgress.UseTransparentBackground = true;
            this.cooldownProgress.Value = 50;
            // 
            // SpellControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.cooldownProgress);
            this.Controls.Add(this.pctSpell);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SpellControl";
            this.Size = new System.Drawing.Size(50, 50);
            this.Click += new System.EventHandler(this.SpellControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pctSpell)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctSpell;
        private System.Windows.Forms.Timer timer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblTimer;
        private Guna.UI2.WinForms.Guna2CircleProgressBar cooldownProgress;
    }
}
