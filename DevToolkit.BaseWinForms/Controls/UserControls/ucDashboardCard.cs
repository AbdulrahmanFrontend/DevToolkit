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
    public partial class ucDashboardCard : UserControl
    {
        public ucDashboardCard()
        {
            InitializeComponent();
        }

        [Category("Custom Properties")]
        public Image CardIcon
        {
            get => picbIcon.Image;
            set => picbIcon.Image = value;
        }

        [Category("Custom Properties")]
        public string CardTitle
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        [Category("Custom Properties")]
        public string CardValue
        {
            get => lblValue.Text;
            set => lblValue.Text = value;
        }

        [Category("Custom Properties")]
        public Color CardTitleColor
        {
            get => lblTitle.ForeColor;
            set => lblTitle.ForeColor = value;
        }

        [Category("Custom Properties")]
        public Color CardValueColor
        {
            get => lblValue.ForeColor;
            set => lblValue.ForeColor = value;
        }

        [Category("Custom Properties")]
        public Font CardTitleFont
        {
            get => lblTitle.Font;
            set => lblTitle.Font = value;
        }

        [Category("Custom Properties")]
        public Font CardValueFont
        {
            get => lblValue.Font;
            set => lblValue.Font = value;
        }
    }
}
