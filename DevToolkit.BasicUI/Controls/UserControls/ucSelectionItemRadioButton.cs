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
    public partial class ucSelectionItemRadioButton : UserControl, ISelectionItem
    {
        public ucSelectionItemRadioButton()
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
            get => rbItem.Checked;
            set
            {
                rbItem.Checked = value;
                lblItem.ForeColor = value ? 
                    SelectedColor : clsAppColors.TextSecondary;
            }
        }

        //private void _UpdateLabelSize()
        //{
        //    lblItem.MaximumSize = new Size(this.Width - rbItem.Width - 5, 0);
        //}

        private void ucSelectionItemRadioButton_Load(object sender, EventArgs e)
        {
            //_UpdateLabelSize();
            this.ForeColor = clsAppColors.TextSecondary;
            this.BackColor = clsAppColors.Background;
        }

        private void ucSelectionItemRadioButton_Resize(object sender, EventArgs e)
        {
            //_UpdateLabelSize();
        }

        public delegate void DataBackCheckedChanged(object sender);
        public DataBackCheckedChanged CheckedChanged;
        private void ucSelectionItemRadioButton_Click(object sender, EventArgs e)
        {
            Checked = true;
            CheckedChanged?.Invoke(this);
        }
    }
}
