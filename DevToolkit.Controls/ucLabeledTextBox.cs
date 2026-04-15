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
    public partial class ucLabeledTextBox : UserControl
    {
        public ucLabeledTextBox()
        {
            InitializeComponent();
        }

        [Category("Custom Properties")]
        public string LabelName
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        [Category("Custom Properties")]
        public string Value
        {
            get => tbValue.Text;
            set => tbValue.Text = value;
        }

        [Category("Custom Properties")]
        public bool Readonly
        {
            get => tbValue.ReadOnly;
            set => tbValue.ReadOnly = value;
        }

        [Category("Custom Properties")]
        public Font ValueFont
        {
            get => tbValue.Font;
            set => tbValue.Font = value;
        }

        [Category("Custom Properties")]
        public bool MultiLine
        {
            get => tbValue.Multiline;
            set
            {
                if (value)
                {
                    tbValue.Dock = DockStyle.Fill;
                }
                else
                {
                    tbValue.Dock = DockStyle.Bottom;
                }
                tbValue.Multiline = value;
            }
        }
    }
}
