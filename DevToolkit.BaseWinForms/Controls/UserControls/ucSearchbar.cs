using DevToolkit.Core.Guards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevToolkit.BaseWinForms.Controls.UserControls
{
    public partial class ucSearchbar : UserControl
    {
        [Category("Custom Properties")]
        public bool ShowFilterValue
        {
            get => cbFilterValues.Visible;
            set => cbFilterValues.Visible = value;
        }

        public ucSearchbar()
        {
            InitializeComponent();
        }

        private void ucSearchbar_Load(object sender, EventArgs e)
        {
            if (this.RightToLeft == RightToLeft.Yes)
                lblSearchBy.Text = "بحث بواسطة: ";
            else
                lblSearchBy.Text = "Search by: ";
        }

        public void SetFilteringMethods(IEnumerable<string> filterMethods)
        {
            cbFilterMethods.Items.Clear();
            if (Guard.HasItems(filterMethods))
                cbFilterMethods.Items.AddRange(filterMethods.ToArray());
        }

        public void SetFilteringValues(IEnumerable<string> filterValues)
        {
            cbFilterValues.Items.Clear();
            if (Guard.HasItems(filterValues))
            {
                cbFilterValues.Items.AddRange(filterValues.ToArray());

                cbFilterValues.SelectedIndex = 0;
            }
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            Filter?.Invoke(this, 
                new FilterEventArgs(
                    cbFilterMethods.SelectedIndex,
                    cbFilterValues.SelectedIndex,
                    tbInput.Text));
        }

        [Category("Custom Events")]
        public event EventHandler<FilterEventArgs> Filter;

        public class FilterEventArgs : EventArgs
        {
            public int FilteringMethodIndex { get; }
            public int FilteringValueIndex { get; }
            public string Input { get; }
            public FilterEventArgs(
                int filteringMethodIndex,
                int filteringValueIndex,
                string input)
            {
                FilteringMethodIndex = filteringMethodIndex;
                FilteringValueIndex = filteringValueIndex;
                Input = input;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbInput.Text = string.Empty;
            cbFilterMethods.SelectedIndex = -1;
        }

        [Category("Custom Properties")]
        public string Input => tbInput.Text?.ToString();

        [Category("Custom Properties")]
        public int SelectedFilterMethodIndex => cbFilterMethods.SelectedIndex;

        [Category("Custom Properties")]
        public int SelectedFilterValueIndex => cbFilterValues.SelectedIndex;

        [Category("Custom Properties")]
        public bool ShowCancelButton
        {
            get => btnCancel.Visible;
            set => btnCancel.Visible = value;
        }

        private void cbFilterMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbInput.ReadOnly = cbFilterMethods.SelectedIndex == -1;
            Filter?.Invoke(this,
                new FilterEventArgs(
                    cbFilterMethods.SelectedIndex,
                    cbFilterValues.SelectedIndex,
                    tbInput.Text));
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
            => InputEntered?.Invoke(this, EventArgs.Empty);

        [Category("Custom Events")]
        public event EventHandler InputEntered;

        private void cbFilterValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter?.Invoke(this,
                new FilterEventArgs(
                    cbFilterMethods.SelectedIndex,
                    cbFilterValues.SelectedIndex,
                    tbInput.Text));
        }
    }
}
