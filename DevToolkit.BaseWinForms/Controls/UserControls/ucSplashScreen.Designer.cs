namespace DevToolkit.BaseWinForms.Controls.UserControls
{
    partial class ucSplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.picbLogo = new System.Windows.Forms.PictureBox();
            this.tSplash = new System.Windows.Forms.Timer(this.components);
            this.tlpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpContainer
            // 
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.Controls.Add(this.lblFooter, 0, 5);
            this.tlpContainer.Controls.Add(this.lblLoading, 0, 3);
            this.tlpContainer.Controls.Add(this.lblSubTitle, 0, 2);
            this.tlpContainer.Controls.Add(this.lblTitle, 0, 1);
            this.tlpContainer.Controls.Add(this.pbLoading, 0, 4);
            this.tlpContainer.Controls.Add(this.picbLogo, 0, 0);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(10, 10);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 6;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.4F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.53333F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.66667F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.13333F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpContainer.Size = new System.Drawing.Size(652, 404);
            this.tlpContainer.TabIndex = 2;
            // 
            // lblFooter
            // 
            this.lblFooter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFooter.AutoSize = true;
            this.lblFooter.Location = new System.Drawing.Point(305, 376);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(41, 16);
            this.lblFooter.TabIndex = 6;
            this.lblFooter.Text = "الخاتمة";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(272, 300);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(108, 16);
            this.lblLoading.TabIndex = 3;
            this.lblLoading.Text = "رسائل/رسالة التحميل";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Location = new System.Drawing.Point(264, 259);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(124, 16);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "عنوان فرعي/رقم الإصدار";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(264, 207);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(123, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "اسم الشركة/المحل/النظام";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLoading
            // 
            this.pbLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLoading.Location = new System.Drawing.Point(55, 336);
            this.pbLoading.MarqueeAnimationSpeed = 0;
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.RightToLeftLayout = true;
            this.pbLoading.Size = new System.Drawing.Size(542, 21);
            this.pbLoading.Step = 1;
            this.pbLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbLoading.TabIndex = 5;
            // 
            // picbLogo
            // 
            this.picbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picbLogo.Location = new System.Drawing.Point(211, 7);
            this.picbLogo.Name = "picbLogo";
            this.picbLogo.Size = new System.Drawing.Size(229, 171);
            this.picbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbLogo.TabIndex = 0;
            this.picbLogo.TabStop = false;
            this.picbLogo.WaitOnLoad = true;
            // 
            // tSplash
            // 
            this.tSplash.Enabled = true;
            this.tSplash.Interval = 40;
            this.tSplash.Tick += new System.EventHandler(this.tSplash_Tick);
            // 
            // ucSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpContainer);
            this.Name = "ucSplashScreen";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(672, 424);
            this.Load += new System.EventHandler(this.ucSplashScreen_Load);
            this.tlpContainer.ResumeLayout(false);
            this.tlpContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ProgressBar pbLoading;
        private System.Windows.Forms.PictureBox picbLogo;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Timer tSplash;
    }
}
