namespace DevToolkit.Controls
{
    partial class ucSelectionItemRadioButton
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
            this.rbItem = new System.Windows.Forms.RadioButton();
            this.lblItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbItem
            // 
            this.rbItem.AutoSize = true;
            this.rbItem.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbItem.Location = new System.Drawing.Point(5, 5);
            this.rbItem.Name = "rbItem";
            this.rbItem.Padding = new System.Windows.Forms.Padding(0, 2, 10, 0);
            this.rbItem.Size = new System.Drawing.Size(27, 28);
            this.rbItem.TabIndex = 0;
            this.rbItem.Click += new System.EventHandler(this.rbItem_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblItem.Location = new System.Drawing.Point(32, 5);
            this.lblItem.MaximumSize = new System.Drawing.Size(644, 0);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(75, 28);
            this.lblItem.TabIndex = 2;
            this.lblItem.Text = "Answer";
            this.lblItem.Click += new System.EventHandler(this.ucSelectionItemRadioButton_Click);
            // 
            // ucSelectionItemRadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.rbItem);
            this.Name = "ucSelectionItemRadioButton";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(112, 38);
            this.Load += new System.EventHandler(this.ucSelectionItemRadioButton_Load);
            this.Click += new System.EventHandler(this.ucSelectionItemRadioButton_Click);
            this.Resize += new System.EventHandler(this.ucSelectionItemRadioButton_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbItem;
        private System.Windows.Forms.Label lblItem;
    }
}
