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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpFooter = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPagination = new System.Windows.Forms.TableLayoutPanel();
            this.lblPage = new System.Windows.Forms.Label();
            this.cbPagesNumbers = new System.Windows.Forms.ComboBox();
            this.lblRecordsCount = new System.Windows.Forms.Label();
            this.tlpContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ctrlDgvMain = new DevToolkit.BaseWinForms.Controls.CustomControls.ccDataGridView();
            this.searchbar = new DevToolkit.BaseWinForms.Controls.UserControls.ucSearchbar();
            this.tlpFooter.SuspendLayout();
            this.tlpPagination.SuspendLayout();
            this.tlpContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpFooter
            // 
            this.tlpFooter.AutoSize = true;
            this.tlpFooter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpFooter.ColumnCount = 2;
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Controls.Add(this.tlpPagination, 1, 0);
            this.tlpFooter.Controls.Add(this.lblRecordsCount, 0, 0);
            this.tlpFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFooter.Location = new System.Drawing.Point(8, 512);
            this.tlpFooter.Name = "tlpFooter";
            this.tlpFooter.RowCount = 1;
            this.tlpFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFooter.Size = new System.Drawing.Size(1144, 37);
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
            this.tlpPagination.Location = new System.Drawing.Point(456, 3);
            this.tlpPagination.Name = "tlpPagination";
            this.tlpPagination.RowCount = 1;
            this.tlpPagination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPagination.Size = new System.Drawing.Size(132, 31);
            this.tlpPagination.TabIndex = 12;
            // 
            // lblPage
            // 
            this.lblPage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(79, 7);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(50, 17);
            this.lblPage.TabIndex = 0;
            this.lblPage.Text = "صفحة: ";
            // 
            // cbPagesNumbers
            // 
            this.cbPagesNumbers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPagesNumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPagesNumbers.FormattingEnabled = true;
            this.cbPagesNumbers.ItemHeight = 17;
            this.cbPagesNumbers.Location = new System.Drawing.Point(3, 3);
            this.cbPagesNumbers.MaxDropDownItems = 3;
            this.cbPagesNumbers.Name = "cbPagesNumbers";
            this.cbPagesNumbers.Size = new System.Drawing.Size(70, 25);
            this.cbPagesNumbers.Sorted = true;
            this.cbPagesNumbers.TabIndex = 1;
            this.cbPagesNumbers.SelectedIndexChanged += new System.EventHandler(this.cbPagesNumbers_SelectedIndexChanged);
            // 
            // lblRecordsCount
            // 
            this.lblRecordsCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRecordsCount.AutoSize = true;
            this.lblRecordsCount.Location = new System.Drawing.Point(1046, 10);
            this.lblRecordsCount.Name = "lblRecordsCount";
            this.lblRecordsCount.Size = new System.Drawing.Size(95, 17);
            this.lblRecordsCount.TabIndex = 0;
            this.lblRecordsCount.Text = "عدد الصفوف: 0";
            // 
            // tlpContainer
            // 
            this.tlpContainer.ColumnCount = 1;
            this.tlpContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.Controls.Add(this.ctrlDgvMain, 0, 1);
            this.tlpContainer.Controls.Add(this.tlpFooter, 0, 2);
            this.tlpContainer.Controls.Add(this.searchbar, 0, 0);
            this.tlpContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpContainer.Name = "tlpContainer";
            this.tlpContainer.Padding = new System.Windows.Forms.Padding(5);
            this.tlpContainer.RowCount = 3;
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContainer.Size = new System.Drawing.Size(1160, 557);
            this.tlpContainer.TabIndex = 14;
            // 
            // ctrlDgvMain
            // 
            this.ctrlDgvMain.AllowUserToAddRows = false;
            this.ctrlDgvMain.AllowUserToDeleteRows = false;
            this.ctrlDgvMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.ctrlDgvMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ctrlDgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ctrlDgvMain.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ctrlDgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctrlDgvMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ctrlDgvMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ctrlDgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ctrlDgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ctrlDgvMain.DefaultCellStyle = dataGridViewCellStyle12;
            this.ctrlDgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlDgvMain.EnableHeadersVisualStyles = false;
            this.ctrlDgvMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(224)))), ((int)(((byte)(230)))));
            this.ctrlDgvMain.Location = new System.Drawing.Point(8, 39);
            this.ctrlDgvMain.MultiSelect = false;
            this.ctrlDgvMain.Name = "ctrlDgvMain";
            this.ctrlDgvMain.ReadOnly = true;
            this.ctrlDgvMain.RowHeadersVisible = false;
            this.ctrlDgvMain.RowHeadersWidth = 51;
            this.ctrlDgvMain.RowTemplate.Height = 35;
            this.ctrlDgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ctrlDgvMain.Size = new System.Drawing.Size(1144, 467);
            this.ctrlDgvMain.TabIndex = 17;
            // 
            // searchbar
            // 
            this.searchbar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.searchbar.ButtonWidth = 33F;
            this.searchbar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbar.Input = "";
            this.searchbar.Location = new System.Drawing.Point(543, 5);
            this.searchbar.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.searchbar.Name = "searchbar";
            this.searchbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchbar.ShowCancelButton = true;
            this.searchbar.Size = new System.Drawing.Size(609, 31);
            this.searchbar.TabIndex = 13;
            // 
            // ucDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucDataGridView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1160, 557);
            this.Load += new System.EventHandler(this.ucDataGridView_Load);
            this.tlpFooter.ResumeLayout(false);
            this.tlpFooter.PerformLayout();
            this.tlpPagination.ResumeLayout(false);
            this.tlpPagination.PerformLayout();
            this.tlpContainer.ResumeLayout(false);
            this.tlpContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpFooter;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.TableLayoutPanel tlpPagination;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.ComboBox cbPagesNumbers;
        private ucSearchbar searchbar;
        private System.Windows.Forms.TableLayoutPanel tlpContainer;
        private CustomControls.ccDataGridView ctrlDgvMain;
    }
}
