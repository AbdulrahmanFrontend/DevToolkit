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
            get => cbFilterValue.Visible;
            set => cbFilterValue.Visible = value;
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

        public void SetFilteringMethod(IEnumerable<string> filterMethods)
        {
            cbFilterMethod.Items.Clear();
            if (Guard.HasItems(filterMethods))
                cbFilterMethod.Items.AddRange(filterMethods.ToArray());
        }

        public void SetFilteringValues(IEnumerable<string> filterValues)
        {
            cbFilterValue.Items.Clear();
            if (Guard.HasItems(filterValues))
            {
                cbFilterValue.Items.AddRange(filterValues.ToArray());

                cbFilterValue.SelectedIndex = 0;
            }
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            Filter?.Invoke(this, 
                new FilterEventArgs(
                    cbFilterMethod.SelectedIndex,
                    cbFilterValue.SelectedIndex,
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
            cbFilterMethod.SelectedIndex = -1;
        }

        [Category("Custom Properties")]
        public string Input => tbInput.Text?.ToString();

        [Category("Custom Properties")]
        public int SelectedFilterMethodIndex => cbFilterMethod.SelectedIndex;

        [Category("Custom Properties")]
        public int SelectedFilterValueIndex => cbFilterValue.SelectedIndex;

        [Category("Custom Properties")]
        public bool ShowCancelButton
        {
            get => btnCancel.Visible;
            set => btnCancel.Visible = value;
        }

        private void cbFilterMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbInput.Enabled = cbFilterMethod.SelectedIndex != -1;
            Filter?.Invoke(this,
                new FilterEventArgs(
                    cbFilterMethod.SelectedIndex,
                    cbFilterValue.SelectedIndex,
                    tbInput.Text));
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
            => InputEntered?.Invoke(this, EventArgs.Empty);

        [Category("Custom Events")]
        public event EventHandler InputEntered;

        private void cbFilterValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter?.Invoke(this,
                new FilterEventArgs(
                    cbFilterMethod.SelectedIndex,
                    cbFilterValue.SelectedIndex,
                    tbInput.Text));
        }
    }
}
