using DevToolkit.BaseWinForms.Controls.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevToolkit.BaseWinForms.Controls.UserControls
{
    public partial class ucDataGridView : UserControl
    {
        public ucDataGridView()
        {
            InitializeComponent();
        }

        [Category("Custom Properties")]
        public DataGridViewColumnCollection Columns => ctrlDgvMain.Columns;

        [Category("Custom Properties")]
        public ucSearchbar Searchbar => searchbar;

        [Category("Custom Properties")]
        public ContextMenuStrip cmsData
        {
            get => ctrlDgvMain.ContextMenuStrip;
            set => ctrlDgvMain.ContextMenuStrip = value;
        }

        [Category("Custom Properties")]
        public object DataSource
        {
            get => ctrlDgvMain.DataSource;
            set => ctrlDgvMain.DataSource = value;
        }

        public void SetCountPages(int count)
        {
            if (RightToLeft == RightToLeft.Yes)
                lblRecordsCount.Text = $"عدد الصفوف: {count}";
            else
                lblRecordsCount.Text = $"Records Count: {count}";
        }

        public object GetSelectedRow(string columnName) 
            => ctrlDgvMain.GetSelectedRow(columnName);

        public void SetPagesCount(int count)
        {
            cbPagesNumbers.Items.Clear();

            for(int i = count; i > 0; i--)
                cbPagesNumbers.Items.Add(i.ToString());

            cbPagesNumbers.SelectedIndex = 0;
        }

        private void cbPagesNumbers_SelectedIndexChanged(
            object sender, 
            EventArgs e)
        {
            if (int.TryParse(cbPagesNumbers.Text?.ToString(), out int value))
                if (PageNumberSelected != null)
                    RaisePageNumberSelected(value);
        }

        public void RaisePageNumberSelected(int pageNumber)
            => RaisePageNumberSelected(
                new PageNumberSelectedEventArgs(pageNumber));

        protected virtual void RaisePageNumberSelected(
            PageNumberSelectedEventArgs e)
            => PageNumberSelected?.Invoke(this, e);

        [Category("Custom Events")]
        public event EventHandler<PageNumberSelectedEventArgs> PageNumberSelected;

        public class PageNumberSelectedEventArgs : EventArgs
        {
            public int PageNumber { get; }
            public PageNumberSelectedEventArgs(int pageNumber)
            {
                PageNumber = pageNumber;
            }
        }

        private void ucDataGridView_Load(object sender, EventArgs e)
        {
            if (RightToLeft == RightToLeft.Yes)
                lblPage.Text = "صفحة: ";
            else
                lblPage.Text = "Page: ";
        }
    }
}
