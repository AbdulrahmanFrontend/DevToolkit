using DevToolkit.BasicUI.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevToolkit.BasicUI.Controls.UserControls
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
            get => lblItem.Text;
            set => lblItem.Text = value;
        }

        [Category("Custom Properties")]
        public Color SelectedColor { get; set; } = Color.DarkCyan;

        [Category("Custom Properties")]
        public bool Checked
        {
            get => chbItem.Checked;
            set
            {
                chbItem.Checked = value;
                lblItem.ForeColor = value ? SelectedColor : this.ForeColor;
            }
        }

        private void ucSelectionItemCheckBox_Load(object sender, EventArgs e)
        {
            lblItem.ForeColor = this.ForeColor;
        }

        public delegate void DataBackCheckedChanged(object sender);
        public DataBackCheckedChanged CheckedChanged;
        private void ucSelectionItemCheckBox_Click(object sender, EventArgs e)
        {
            Checked = !Checked;
            CheckedChanged?.Invoke(this);
        }

        private void chbItem_Click(object sender, EventArgs e)
        {
            lblItem.ForeColor = Checked ? SelectedColor : this.ForeColor;
            CheckedChanged?.Invoke(this);
        }
    }
}
