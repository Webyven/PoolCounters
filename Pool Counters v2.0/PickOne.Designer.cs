namespace Pool_Counters_v2._0
{
    partial class PickOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PickOne));
            this.label1 = new System.Windows.Forms.Label();
            this.btnTEA = new Guna.UI2.WinForms.Guna2Button();
            this.btnSoloQ = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose mode";
            // 
            // btnTEA
            // 
            this.btnTEA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTEA.BorderColor = System.Drawing.Color.White;
            this.btnTEA.BorderRadius = 5;
            this.btnTEA.BorderThickness = 1;
            this.btnTEA.CheckedState.Parent = this.btnTEA;
            this.btnTEA.CustomImages.Parent = this.btnTEA;
            this.btnTEA.FillColor = System.Drawing.Color.Transparent;
            this.btnTEA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTEA.ForeColor = System.Drawing.Color.White;
            this.btnTEA.HoverState.Parent = this.btnTEA;
            this.btnTEA.Image = ((System.Drawing.Image)(resources.GetObject("btnTEA.Image")));
            this.btnTEA.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnTEA.Location = new System.Drawing.Point(98, 45);
            this.btnTEA.Name = "btnTEA";
            this.btnTEA.ShadowDecoration.Parent = this.btnTEA;
            this.btnTEA.Size = new System.Drawing.Size(75, 35);
            this.btnTEA.TabIndex = 5;
            this.btnTEA.Text = "Flex";
            this.btnTEA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTEA.MouseEnter += new System.EventHandler(this.btnSoloQ_MouseEnter);
            this.btnTEA.MouseLeave += new System.EventHandler(this.btnSoloQ_MouseLeave);
            // 
            // btnSoloQ
            // 
            this.btnSoloQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSoloQ.BorderColor = System.Drawing.Color.White;
            this.btnSoloQ.BorderRadius = 5;
            this.btnSoloQ.BorderThickness = 1;
            this.btnSoloQ.CheckedState.Parent = this.btnSoloQ;
            this.btnSoloQ.CustomImages.Parent = this.btnSoloQ;
            this.btnSoloQ.FillColor = System.Drawing.Color.Transparent;
            this.btnSoloQ.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoloQ.ForeColor = System.Drawing.Color.White;
            this.btnSoloQ.HoverState.Parent = this.btnSoloQ;
            this.btnSoloQ.Image = ((System.Drawing.Image)(resources.GetObject("btnSoloQ.Image")));
            this.btnSoloQ.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSoloQ.ImageOffset = new System.Drawing.Point(-1, -1);
            this.btnSoloQ.Location = new System.Drawing.Point(12, 45);
            this.btnSoloQ.Name = "btnSoloQ";
            this.btnSoloQ.ShadowDecoration.Parent = this.btnSoloQ;
            this.btnSoloQ.Size = new System.Drawing.Size(75, 35);
            this.btnSoloQ.TabIndex = 4;
            this.btnSoloQ.Text = "Solo";
            this.btnSoloQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSoloQ.MouseEnter += new System.EventHandler(this.btnSoloQ_MouseEnter);
            this.btnSoloQ.MouseLeave += new System.EventHandler(this.btnSoloQ_MouseLeave);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // PickOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(185, 95);
            this.Controls.Add(this.btnTEA);
            this.Controls.Add(this.btnSoloQ);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PickOne";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose mode";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PickOne_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2Button btnSoloQ;
        public Guna.UI2.WinForms.Guna2Button btnTEA;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}