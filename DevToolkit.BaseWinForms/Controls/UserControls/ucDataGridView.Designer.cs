namespace DevToolkit.BaseWinForms.Controls.UserControls
{
    partial class ucDataGridView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDataGridView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPagination = new System.Windows.Forms.TableLayoutPanel();
            this.lblPage = new System.Windows.Forms.Label();
            this.cbPagesNumbers = new System.Windows.Forms.ComboBox();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.Searchbar = new DevToolkit.BaseWinForms.Controls.UserControls.ucSearchbar();
            this.ctrlDgvMain = new DevToolkit.BaseWinForms.Controls.CustomControls.ccDataGridView();
            this.tlpFooter.SuspendLayout();
            this.tlpPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpFooter
            // 
            this.tlpFooter.AutoSize = true;
            this.tlpFooter.ColumnCount = 2;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Controls.Add(this.tlpPagination, 1, 0);
            this.tlpFooter.Controls.Add(this.lblRecordsCount, 0, 0);
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpFooter.Location = new System.Drawing.Point(0, 488);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Size = new System.Drawing.Size(1087, 36);
            this.tlpFooter.TabIndex = 4;
            // 
            // tlpPagination
            // 
            this.tlpPagination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpPagination.AutoSize = true;
            this.tlpPagination.ColumnCount = 2;
            this.tlpPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpPagination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagination.Controls.Add(this.lblPage, 0, 0);
            this.tlpPagination.Controls.Add(this.cbPagesNumbers, 1, 0);
            this.tlpPagination.Location = new System.Drawing.Point(436, 3);
            this.tlpPagination.Name = "tlpPagination";
            this.tlpPagination.RowCount = 1;
            this.tlpPagination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagination.Size = new System.Drawing.Size(133, 30);
            this.tlpPagination.TabIndex = 12;
            // 
            // lblPage
            // 
            this.lblPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(89, 7);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(41, 16);
            this.lblPage.TabIndex = 0;
            this.lblPage.Text = "صفحة: ";
            // 
            // cbPagesNumbers
            // 
            this.cbPagesNumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPagesNumbers.FormattingEnabled = true;
            this.cbPagesNumbers.ItemHeight = 16;
            this.cbPagesNumbers.Location = new System.Drawing.Point(3, 3);
            this.cbPagesNumbers.MaxDropDownItems = 3;
            this.cbPagesNumbers.Name = "cbPagesNumbers";
            this.cbPagesNumbers.Size = new System.Drawing.Size(80, 24);
            this.cbPagesNumbers.Sorted = true;
            this.cbPagesNumbers.TabIndex = 1;
            this.cbPagesNumbers.SelectedIndexChanged += new System.EventHandler(this.cbPagesNumbers_SelectedIndexChanged);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Location = new System.Drawing.Point(1007, 10);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(77, 16);
            this.lblRecordsCount.TabIndex = 0;
            this.lblRecordsCount.Text = "عدد الصفوف: 0";
            // 
            // Searchbar
            // 
            this.Searchbar.AutoSize = true;
            this.Searchbar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Searchbar.ButtonBackColor = System.Drawing.SystemColors.Control;
            this.Searchbar.ButtonBackgroundImage = ((System.Drawing.Image)(resources.GetObject("Searchbar.ButtonBackgroundImage")));
            this.Searchbar.ButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.Searchbar.ButtonTitle = "";
            this.Searchbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Searchbar.FilteringMethodBackColor = System.Drawing.SystemColors.Window;
            this.Searchbar.FilteringMethodForeColor = System.Drawing.SystemColors.WindowText;
            this.Searchbar.InputBackColor = System.Drawing.SystemColors.Window;
            this.Searchbar.InputForeColor = System.Drawing.SystemColors.WindowText;
            this.Searchbar.Location = new System.Drawing.Point(0, 0);
            this.Searchbar.Name = "Searchbar";
            this.Searchbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Searchbar.SearchByColor = System.Drawing.SystemColors.ControlText;
            this.Searchbar.Size = new System.Drawing.Size(1087, 30);
            this.Searchbar.TabIndex = 13;
            // 
            // ctrlDgvMain
            // 
            this.ctrlDgvMain.AllowUserToAddRows = false;
            this.ctrlDgvMain.AllowUserToDeleteRows = false;
            this.ctrlDgvMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.ctrlDgvMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ctrlDgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ctrlDgvMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ctrlDgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctrlDgvMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ctrlDgvMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ctrlDgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ctrlDgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ctrlDgvMain.DefaultCellStyle = dataGridViewCellStyle3;
            this.ctrlDgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlDgvMain.EnableHeadersVisualStyles = false;
            this.ctrlDgvMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.ctrlDgvMain.Location = new System.Drawing.Point(0, 30);
            this.ctrlDgvMain.MultiSelect = false;
            this.ctrlDgvMain.Name = "ctrlDgvMain";
            this.ctrlDgvMain.ReadOnly = true;
            this.ctrlDgvMain.RowHeadersVisible = false;
            this.ctrlDgvMain.RowHeadersWidth = 51;
            this.ctrlDgvMain.RowTemplate.Height = 35;
            this.ctrlDgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctrlDgvMain.Size = new System.Drawing.Size(1087, 458);
            this.ctrlDgvMain.TabIndex = 14;
            // 
            // ucDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlDgvMain);
            this.Controls.Add(this.Searchbar);
            this.Controls.Add(this.tlpFooter);
            this.Name = "ucDataGridView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1087, 524);
            this.Load += new System.EventHandler(this.ucDataGridView_Load);
            this.tlpFooter.ResumeLayout(false);
            this.tlpFooter.PerformLayout();
            this.tlpPagination.ResumeLayout(false);
            this.tlpPagination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.TableLayoutPanel tlpPagination;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.ComboBox cbPagesNumbers;
        private ucSearchbar Searchbar;
        private CustomControls.ccDataGridView ctrlDgvMain;
    }
}
