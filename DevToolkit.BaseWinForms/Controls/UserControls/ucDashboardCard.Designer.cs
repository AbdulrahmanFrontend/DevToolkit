namespace DevToolkit.BaseWinForms.Controls.UserControls
{
    partial class ucDashboardCard
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
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.scContainer = new System.Windows.Forms.SplitContainer();
            this.tlpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContainer)).BeginInit();
            this.scContainer.Panel2.SuspendLayout();
            this.scContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpInfo
            // 
            this.tlpInfo.ColumnCount = 1;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo.Controls.Add(this.lblTitle, 0, 0);
            this.tlpInfo.Controls.Add(this.lblValue, 0, 1);
            this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfo.Location = new System.Drawing.Point(5, 5);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 2;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo.Size = new System.Drawing.Size(125, 90);
            this.tlpInfo.TabIndex = 2;
            // 
            // lblValue
            // 
            this.lblValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(42, 50);
            this.lblValue.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(42, 16);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "Value";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(45, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(36, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // scContainer
            // 
            this.scContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContainer.Location = new System.Drawing.Point(5, 5);
            this.scContainer.Name = "scContainer";
            // 
            // scContainer.Panel1
            // 
            this.scContainer.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.scContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.scContainer.Panel1MinSize = 70;
            // 
            // scContainer.Panel2
            // 
            this.scContainer.Panel2.Controls.Add(this.tlpInfo);
            this.scContainer.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.scContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.scContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.scContainer.Size = new System.Drawing.Size(209, 100);
            this.scContainer.SplitterDistance = 70;
            this.scContainer.TabIndex = 4;
            // 
            // ucDashboardCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scContainer);
            this.DoubleBuffered = true;
            this.Name = "ucDashboardCard";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(219, 110);
            this.tlpInfo.ResumeLayout(false);
            this.tlpInfo.PerformLayout();
            this.scContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContainer)).EndInit();
            this.scContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SplitContainer scContainer;
    }
}
