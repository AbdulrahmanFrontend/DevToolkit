namespace DevToolkit.BaseWinForms.Controls.UserControls
{
    partial class ucHeaderbar
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSystemName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tDateTime = new System.Windows.Forms.Timer(this.components);
            this.tlpContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpContainer
            // 
            this.tlpContainer.AutoSize = true;
            this.tlpContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpContainer.ColumnCount = 4;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlpContainer.Controls.Add(this.lblTime, 3, 0);
            this.tlpContainer.Controls.Add(this.lblSystemName, 0, 0);
            this.tlpContainer.Controls.Add(this.lblDate, 2, 0);
            this.tlpContainer.Controls.Add(this.lblUserName, 1, 0);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(5, 5);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.RowCount = 1;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.Size = new System.Drawing.Size(448, 16);
            this.tlpContainer.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(3, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(44, 16);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "label2";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSystemName
            // 
            this.lblSystemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSystemName.AutoSize = true;
            this.lblSystemName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSystemName.Location = new System.Drawing.Point(272, 0);
            this.lblSystemName.Name = "lblSystemName";
            this.lblSystemName.Size = new System.Drawing.Size(173, 16);
            this.lblSystemName.TabIndex = 1;
            this.lblSystemName.Text = "نظام إدارة محل قطع غيار السيارات";
            this.lblSystemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(80, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDate.Size = new System.Drawing.Size(44, 16);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "label2";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserName.AutoSize = true;
            this.lblUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserName.Location = new System.Drawing.Point(167, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(70, 16);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "اسم المستخدم";
            // 
            // tDateTime
            // 
            this.tDateTime.Enabled = true;
            this.tDateTime.Interval = 1000;
            this.tDateTime.Tick += new System.EventHandler(this.tDateTime_Tick);
            // 
            // ucHeaderbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tlpContainer);
            this.DoubleBuffered = true;
            this.Name = "ucHeaderbar";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(458, 26);
            this.Load += new System.EventHandler(this.ucHeaderbar_Load);
            this.tlpContainer.ResumeLayout(false);
            this.tlpContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Timer tDateTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblUserName;
    }
}
