namespace DevToolkit.BaseWinForms.Controls.UserControls
{
    partial class ucSidebar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.picbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.AutoScroll = true;
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(5, 153);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(213, 363);
            this.pnlButtons.TabIndex = 1;
            // 
            // picbLogo
            // 
            this.picbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picbLogo.Location = new System.Drawing.Point(5, 0);
            this.picbLogo.Name = "picbLogo";
            this.picbLogo.Size = new System.Drawing.Size(213, 153);
            this.picbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbLogo.TabIndex = 0;
            this.picbLogo.TabStop = false;
            // 
            // ucSidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.picbLogo);
            this.DoubleBuffered = true;
            this.Name = "ucSidebar";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(223, 516);
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbLogo;
        private System.Windows.Forms.Panel pnlButtons;
    }
}
