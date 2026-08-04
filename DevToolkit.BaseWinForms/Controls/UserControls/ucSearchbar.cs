using DevToolkit.Core.Guards;
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
    public partial class ucSearchbar : UserControl
    {
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

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            InputChanged?.Invoke(this, 
                new InputChangedEventArgs(
                    cbFilterMethod.SelectedIndex,
                    tbInput.Text));
        }

        [Category("Custom Events")]
        public event EventHandler<InputChangedEventArgs> InputChanged;

        public class InputChangedEventArgs : EventArgs
        {
            public int FilteringMethodIndex { get; }
            public object Input { get; }
            public InputChangedEventArgs(int filteringMethodIndex, object input)
            {
                FilteringMethodIndex = filteringMethodIndex;
                Input = input;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbInput.Text = string.Empty;
            cbFilterMethod.SelectedIndex = -1;
        }

        [Category("Custom Properties")]
        public object Input => tbInput.Text?.ToString();

        [Category("Custom Properties")]
        public int SelectedFilterIndex => cbFilterMethod.SelectedIndex;

        [Category("Custom Properties")]
        public bool ShowCancelButton
        {
            get => btnCancel.Visible;
            set => btnCancel.Visible = value;
        }

        private void cbFilterMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbInput.Enabled = cbFilterMethod.SelectedIndex != -1;
            InputChanged?.Invoke(this,
                new InputChangedEventArgs(
                    cbFilterMethod.SelectedIndex,
                    tbInput.Text));
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
            => InputEntered?.Invoke(this, EventArgs.Empty);

        public event EventHandler InputEntered;
    }
}
