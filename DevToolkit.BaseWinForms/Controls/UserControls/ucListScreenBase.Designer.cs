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
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.GridView = new DevToolkit.BaseWinForms.Controls.UserControls.ucDataGridView();
            this.tlpContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContainer
            // 
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.Controls.Add(this.lblTitle, 0, 0);
            this.tlpContainer.Controls.Add(this.GridView, 0, 1);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 2;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.Size = new System.Drawing.Size(996, 711);
            this.tlpContainer.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(990, 60);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridView
            // 
            this.GridView.AddNewButtonColor = System.Drawing.SystemColors.Control;
            this.GridView.AddNewButtonImage = null;
            this.GridView.AddNewButtonText = "";
            this.GridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView.cmsData = null;
            this.GridView.DataSource = null;
            this.GridView.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView.ImportButtonColor = System.Drawing.SystemColors.Control;
            this.GridView.ImportButtonImage = null;
            this.GridView.ImportButtonText = "";
            this.GridView.ImportButtonVisible = true;
            this.GridView.Location = new System.Drawing.Point(3, 223);
            this.GridView.Name = "GridView";
            this.GridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridView.Size = new System.Drawing.Size(990, 485);
            this.GridView.TabIndex = 2;
            // 
            // ucListScreenBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucListScreenBase";
            this.Size = new System.Drawing.Size(996, 711);
            this.tlpContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.Label lblTitle;
        private ucDataGridView GridView;
    }
}
