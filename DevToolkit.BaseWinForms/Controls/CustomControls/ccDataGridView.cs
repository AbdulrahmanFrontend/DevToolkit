using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevToolkit.BaseWinForms.Controls.CustomControls
{
    public partial class ccDataGridView : DataGridView
    {
        public ccDataGridView()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            this.BackgroundColor = Color.FromArgb(245, 247, 250);
            this.BorderStyle = BorderStyle.None;
            this.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridColor = Color.FromArgb(220, 224, 230);
            this.RowHeadersVisible = false;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.AllowUserToResizeRows = false;
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;

            this.ReadOnly = true;
            this.MultiSelect = false;

            this.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.ColumnHeadersDefaultCellStyle.BackColor = 
                Color.FromArgb(43, 60, 80);
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.ColumnHeadersDefaultCellStyle.Font = 
                new Font("Segoe UI", 10, FontStyle.Bold);
            this.ColumnHeadersHeight = 40;
            this.ColumnHeadersHeightSizeMode = 
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.EnableHeadersVisualStyles = false;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.DefaultCellStyle.BackColor = Color.White;
            this.DefaultCellStyle.ForeColor = Color.FromArgb(33, 37, 41);
            this.DefaultCellStyle.Font = 
                new Font("Segoe UI", 9.5f, FontStyle.Regular);
            this.DefaultCellStyle.SelectionBackColor = 
                Color.FromArgb(232, 240, 254);
            this.DefaultCellStyle.SelectionForeColor = 
                Color.FromArgb(33, 37, 41);

            this.AlternatingRowsDefaultCellStyle.BackColor = 
                Color.FromArgb(250, 251, 252);

            this.RowTemplate.Height = 35;
        }

        public object GetSelectedRow(string columnName)
            => this.CurrentRow.Cells[columnName].Value;

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
