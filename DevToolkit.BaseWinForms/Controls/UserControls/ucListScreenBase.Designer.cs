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
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AddNewButtonColor = System.Drawing.SystemColors.Control;
            this.GridView.AddNewButtonImage = null;
            this.GridView.AddNewButtonText = "";
            this.GridView.cmsData = null;
            this.GridView.DataSource = null;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridView.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView.ImportButtonColor = System.Drawing.SystemColors.Control;
            this.GridView.ImportButtonImage = null;
            this.GridView.ImportButtonText = "";
            this.GridView.ImportButtonVisible = true;
            this.GridView.Location = new System.Drawing.Point(0, 139);
            this.GridView.Name = "GridView";
            this.GridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridView.Size = new System.Drawing.Size(996, 432);
            this.GridView.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(996, 52);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucListScreenBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.GridView);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucListScreenBase";
            this.Size = new System.Drawing.Size(996, 571);
            this.ResumeLayout(false);

        }

        #endregion

        private ucDataGridView GridView;
        private System.Windows.Forms.Label lblTitle;
    }
}
