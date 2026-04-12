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
    public partial class ucLabeledCombBox : UserControl
    {
        public ucLabeledCombBox()
        {
            InitializeComponent();
        }

        [Category("Custom Properties")]
        public string LabelText
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        [Category("Custom Properties")]
        public bool Required { get; set; }
        
        [Category("Custom Properties")]
        public ComboBox ComboBoxValues => cmbValues;
    }
}
