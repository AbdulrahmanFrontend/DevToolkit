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
    public partial class ucSelectionItemCheckBox : UserControl, ISelectionItem
    {
        public ucSelectionItemCheckBox()
        {
            InitializeComponent();
        }

        [Category("Custom Properties")]
        public int ItemID { get; set; }

        [Category("Custom Properties")]
        public string ItemText
        {
            get { return lblItem.Text; }
            set { lblItem.Text = value; }
        }

        [Category("Custom Properties")]
        public Color SelectedColor { get; set; } = Color.LightCyan;

        [Category("Custom Properties")]
        public bool Checked
        {
            get { return chbItem.Checked; }
            set 
            { 
                chbItem.Checked = value;
                this.BackColor = value ? SelectedColor : Color.Transparent;
            }
        }
        
        private void _UpdateLabelSize()
        {
            lblItem.MaximumSize = new Size(this.Width - chbItem.Width - 10, 0);
        }

        private void ucSelectionItemCheckBox_Load(object sender, EventArgs e)
        {
            _UpdateLabelSize();
        }

        private void ucSelectionItemCheckBox_Resize(object sender, EventArgs e)
        {
            _UpdateLabelSize();
        }

        public event EventHandler CheckedChanged;
        private void ucSelectionItemCheckBox_Click(object sender, EventArgs e)
        {
            Checked = !Checked;
            CheckedChanged?.Invoke(this, e);
        }

        private void chbItem_Click(object sender, EventArgs e)
        {
            CheckedChanged?.Invoke(this, e);
        }
    }
}
