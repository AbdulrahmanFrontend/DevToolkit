namespace DevToolkit.BasicUI.Controls.UserControls
{
    partial class ucSelectionItemCheckBox
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
            this.chbItem = new System.Windows.Forms.CheckBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chbItem
            // 
            this.chbItem.AutoSize = true;
            this.chbItem.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chbItem.Dock = System.Windows.Forms.DockStyle.Left;
            this.chbItem.Location = new System.Drawing.Point(4, 5);
            this.chbItem.Name = "chbItem";
            this.chbItem.Padding = new System.Windows.Forms.Padding(0, 4, 9, 0);
            this.chbItem.Size = new System.Drawing.Size(27, 28);
            this.chbItem.TabIndex = 2;
            this.chbItem.UseVisualStyleBackColor = true;
            this.chbItem.Click += new System.EventHandler(this.chbItem_Click);
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblItem.Location = new System.Drawing.Point(31, 5);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(75, 28);
            this.lblItem.TabIndex = 3;
            this.lblItem.Text = "Answer";
            this.lblItem.Click += new System.EventHandler(this.ucSelectionItemCheckBox_Click);
            // 
            // ucSelectionItemCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.chbItem);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucSelectionItemCheckBox";
            this.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Size = new System.Drawing.Size(110, 38);
            this.Load += new System.EventHandler(this.ucSelectionItemCheckBox_Load);
            this.Click += new System.EventHandler(this.ucSelectionItemCheckBox_Click);
            this.Resize += new System.EventHandler(this.ucSelectionItemCheckBox_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbItem;
        private System.Windows.Forms.Label lblItem;
    }
}
