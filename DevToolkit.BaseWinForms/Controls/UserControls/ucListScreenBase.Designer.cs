namespace DevToolkit.BaseWinForms.Controls.UserControls
{
    partial class ucListScreenBase
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
            this.GridView = new DevToolkit.BaseWinForms.Controls.UserControls.ucDataGridView();
            this.headerbar = new DevToolkit.BaseWinForms.Controls.UserControls.ucHeaderbarWithButton();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.cmsData = null;
            this.GridView.DataSource = null;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridView.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView.Location = new System.Drawing.Point(0, 130);
            this.GridView.Name = "GridView";
            this.GridView.PagePhraseColor = System.Drawing.SystemColors.ControlText;
            this.GridView.RecordsCountPhrase = "عدد الصفوف: 0";
            this.GridView.RecordsCountPhraseColor = System.Drawing.SystemColors.ControlText;
            this.GridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridView.Size = new System.Drawing.Size(1100, 407);
            this.GridView.TabIndex = 1;
            // 
            // headerbar
            // 
            this.headerbar.AutoSize = true;
            this.headerbar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.headerbar.ButtonBackColor = System.Drawing.SystemColors.Control;
            this.headerbar.ButtonBackgroundImage = null;
            this.headerbar.ButtonText = "";
            this.headerbar.ButtonWidth = 41F;
            this.headerbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerbar.Location = new System.Drawing.Point(0, 0);
            this.headerbar.Name = "headerbar";
            this.headerbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.headerbar.Size = new System.Drawing.Size(1100, 30);
            this.headerbar.TabIndex = 2;
            this.headerbar.Title = "Title";
            this.headerbar.TitleColor = System.Drawing.SystemColors.ControlText;
            // 
            // ucListScreenBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.headerbar);
            this.Controls.Add(this.GridView);
            this.Name = "ucListScreenBase";
            this.Size = new System.Drawing.Size(1100, 537);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucDataGridView GridView;
        private ucHeaderbarWithButton headerbar;
    }
}
