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
            if (InputChanged != null)
                RaiseInputChanged(SelectedFilterIndex, Input);
        }

        public void RaiseInputChanged(int filteringMethodIndex, string input)
            => RaiseInputChanged(
                new InputChangedEventArgs(filteringMethodIndex, input));

        protected virtual void RaiseInputChanged(InputChangedEventArgs e)
            => InputChanged?.Invoke(this, e);

        [Category("Custom Events")]
        public event EventHandler<InputChangedEventArgs> InputChanged;

        public class InputChangedEventArgs : EventArgs
        {
            public int FilteringMethodIndex { get; }
            public string Input { get; }
            public InputChangedEventArgs(int filteringMethodIndex, string input)
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
        public string Input
        {
            get => tbInput.Text?.ToString();
            set => tbInput.Text = value;
        }

        [Category("Custom Properties")]
        public int SelectedFilterIndex => cbFilterMethod.SelectedIndex;

        [Category("Custom Properties")]
        public bool ShowCancelButton
        {
            get => btnCancel.Visible;
            set => btnCancel.Visible = value;
        }
    }
}
