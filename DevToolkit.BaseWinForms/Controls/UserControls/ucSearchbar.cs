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
            {
                RaiseInputChanged(Input, SelectedFilter);
            }
        }

        public void RaiseInputChanged(string filteringMethod, string input)
            => RaiseInputChanged(
                new InputChangedEventArgs(filteringMethod, input));

        protected virtual void RaiseInputChanged(InputChangedEventArgs e)
            => InputChanged?.Invoke(this, e);

        [Category("Custom Events")]
        public event EventHandler<InputChangedEventArgs> InputChanged;

        public class InputChangedEventArgs : EventArgs
        {
            public string FilteringMethod { get; }
            public string Input { get; }
            public InputChangedEventArgs(string filteringMethod, string input)
            {
                FilteringMethod = filteringMethod;
                Input = input;
            }
        }

        private void cbFilterMethod_SelectedIndexChanged(
            object sender,
            EventArgs e)
            => tbInput.Enabled = cbFilterMethod.Text != string.Empty;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbInput.Text = string.Empty;
            tbInput.Enabled = false;

            cbFilterMethod.SelectedIndex = -1;
        }

        [Category("Custom Properties")]
        public Color SearchByColor
        {
            get => lblSearchBy.ForeColor;
            set => lblSearchBy.ForeColor = value;
        }

        [Category("Custom Properties")]
        public Color FilteringMethodBackColor
        {
            get => cbFilterMethod.BackColor;
            set => cbFilterMethod.BackColor = value;
        }

        [Category("Custom Properties")]
        public Color FilteringMethodForeColor
        {
            get => cbFilterMethod.ForeColor;
            set => cbFilterMethod.ForeColor = value;
        }

        [Category("Custom Properties")]
        public string Input
        {
            get => tbInput.Text?.ToString();
            set => tbInput.Text = value;
        }

        public string SelectedFilter => cbFilterMethod?.Text.ToString();

        [Category("Custom Properties")]
        public Color InputBackColor
        {
            get => tbInput.BackColor;
            set => tbInput.BackColor = value;
        }

        [Category("Custom Properties")]
        public Color InputForeColor
        {
            get => tbInput.ForeColor;
            set => tbInput.ForeColor = value;
        }

        [Category("Custom Properties")]
        public Image ButtonBackgroundImage
        {
            get => btnCancel.BackgroundImage;
            set => btnCancel.BackgroundImage = value;
        }

        [Category("Custom Properties")]
        public string ButtonTitle
        {
            get => btnCancel.Text;
            set => btnCancel.Text = value;
        }

        [Category("Custom Properties")]
        public Color ButtonBackColor
        {
            get => btnCancel.BackColor;
            set => btnCancel.BackColor = value;
        }

        [Category("Custom Properties")]
        public Color ButtonForeColor
        {
            get => btnCancel.ForeColor;
            set => btnCancel.ForeColor = value;
        }

        [Category("Custom Properties")]
        public float ButtonWidth
        {
            get => tlpContainer.ColumnStyles[3].Width;
            set => tlpContainer.ColumnStyles[3].Width = value;
        }

        [Category("Custom Properties")]
        public float FilteringMethodField
        {
            get => tlpContainer.ColumnStyles[1].Width;
            set => tlpContainer.ColumnStyles[1].Width = value;
        }
    }
}
