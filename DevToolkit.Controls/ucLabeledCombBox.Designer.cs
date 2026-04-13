namespace DevToolkit.Controls
{
    partial class ucLabeledCombBox
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
            this.cmbValues = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tlpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpContainer
            // 
            this.tlpContainer.AutoSize = true;
            this.tlpContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.Controls.Add(this.cmbValues, 0, 1);
            this.tlpContainer.Controls.Add(this.lblTitle, 0, 0);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(1, 1);
            this.tlpContainer.Margin = new System.Windows.Forms.Padding(4);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.Padding = new System.Windows.Forms.Padding(1);
            this.tlpContainer.RowCount = 2;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContainer.Size = new System.Drawing.Size(310, 66);
            this.tlpContainer.TabIndex = 0;
            // 
            // cmbValues
            // 
            this.cmbValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbValues.FormattingEnabled = true;
            this.cmbValues.Location = new System.Drawing.Point(4, 31);
            this.cmbValues.Name = "cmbValues";
            this.cmbValues.Size = new System.Drawing.Size(302, 31);
            this.cmbValues.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(5, 1);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ucLabeledCombBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tlpContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucLabeledCombBox";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(312, 68);
            this.tlpContainer.ResumeLayout(false);
            this.tlpContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbValues;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
