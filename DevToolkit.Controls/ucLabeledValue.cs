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
    public partial class ucLabeledValue : UserControl
    {
        public ucLabeledValue()
        {
            InitializeComponent();
        }

        private void ucLabeledValue_Load(object sender, EventArgs e)
        {
            lblValue.MaximumSize = new Size(this.Width - lblTitle.Width - 10, 0);
        }

        [Category("Custom Properties")]
        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        [Category("Custom Properties")]
        public string Value
        {
            get => lblValue.Text;
            set => lblValue.Text = value;
        }

        [Category("Custom Properties")]
        public Font ValueFont
        {
            get => lblValue.Font;
            set => lblValue.Font = value;
        }

        [Category("Custom Properties")]
        public Color ValueColor
        {
            get => lblValue.ForeColor;
            set => lblValue.ForeColor = value;
        }
    }
}
