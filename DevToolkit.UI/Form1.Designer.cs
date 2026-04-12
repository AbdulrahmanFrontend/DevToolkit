namespace DevToolkit.UI
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucLabeledCombBox1 = new DevToolkit.Controls.ucLabeledCombBox();
            this.SuspendLayout();
            // 
            // ucLabeledCombBox1
            // 
            this.ucLabeledCombBox1.AutoSize = true;
            this.ucLabeledCombBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabeledCombBox1.LabelText = "Title";
            this.ucLabeledCombBox1.Location = new System.Drawing.Point(397, 80);
            this.ucLabeledCombBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ucLabeledCombBox1.Name = "ucLabeledCombBox1";
            this.ucLabeledCombBox1.Padding = new System.Windows.Forms.Padding(3);
            this.ucLabeledCombBox1.Size = new System.Drawing.Size(235, 98);
            this.ucLabeledCombBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucLabeledCombBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ucLabeledCombBox ucLabeledCombBox1;
    }
}

