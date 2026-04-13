using DevToolkit.Controls.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevToolkit.Controls
{
    public partial class ucSelectionItemRadioButton : UserControl, ISelectionItem
    {
        public ucSelectionItemRadioButton()
        {
            InitializeComponent();
        }

        [Category("Custom Properties")]
        public int ItemId { get; set; }

        [Category("Custom Properties")]
        public string ItemText
        {
            get { return lblItem.Text; }
            set { lblItem.Text = value; }
        }

        [Category("Custom Properties")]
        public Color SelectedColor { get; set; } = clsAppColors.Highlight;

        [Category("Custom Properties")]
        public bool Checked
        {
            get { return rbItem.Checked; }
            set
            {
                rbItem.Checked = value;
                this.BackColor = value ? SelectedColor : Color.Transparent;
            }
        }

        private void _UpdateLabelSize()
        {
            lblItem.MaximumSize = new Size(this.Width - rbItem.Width - 10, 0);
        }

        private void ucSelectionItemRadioButton_Load(object sender, EventArgs e)
        {
            _UpdateLabelSize();
        }

        private void ucSelectionItemRadioButton_Resize(object sender, EventArgs e)
        {
            _UpdateLabelSize();
        }

        public event EventHandler CheckedChanged;
        private void ucSelectionItemRadioButton_Click(object sender, EventArgs e)
        {
            Checked = true;
            CheckedChanged?.Invoke(this, e);
        }

        private void rbItem_Click(object sender, EventArgs e)
        {
            CheckedChanged?.Invoke(this, e);
        }
    }
}
