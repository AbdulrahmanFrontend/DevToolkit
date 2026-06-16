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
            this.headerbar = new DevToolkit.BaseWinForms.Controls.UserControls.ucHeaderbarWithButton();
            this.GridView = new DevToolkit.BaseWinForms.Controls.UserControls.ucDataGridView();
            this.SuspendLayout();
            // 
            // headerbar
            // 
            this.headerbar.ButtonBackgroundImage = null;
            this.headerbar.ButtonText = "";
            this.headerbar.ButtonWidth = 36F;
            this.headerbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerbar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerbar.Location = new System.Drawing.Point(0, 0);
            this.headerbar.Margin = new System.Windows.Forms.Padding(0);
            this.headerbar.Name = "headerbar";
            this.headerbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.headerbar.Size = new System.Drawing.Size(996, 34);
            this.headerbar.TabIndex = 2;
            this.headerbar.Title = "Title";
            // 
            // GridView
            // 
            this.GridView.cmsData = null;
            this.GridView.DataSource = null;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridView.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView.Location = new System.Drawing.Point(0, 139);
            this.GridView.Name = "GridView";
            this.GridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridView.Size = new System.Drawing.Size(996, 432);
            this.GridView.TabIndex = 1;
            // 
            // ucListScreenBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.headerbar);
            this.Controls.Add(this.GridView);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucListScreenBase";
            this.Size = new System.Drawing.Size(996, 571);
            this.ResumeLayout(false);

        }

        #endregion

        private ucDataGridView GridView;
        private ucHeaderbarWithButton headerbar;
    }
}
