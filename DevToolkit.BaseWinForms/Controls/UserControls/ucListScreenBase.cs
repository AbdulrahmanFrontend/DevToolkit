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
    public partial class ucListScreenBase : UserControl
    {
        public ucListScreenBase()
        {
            InitializeComponent();
        }

        [Category("Custom Properties")]
        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        [Category("Custom Properties")]
        public Color TitleTextColor
        {
            get => lblTitle.ForeColor;
            set => lblTitle.ForeColor = value;
        }

        [Category("Custom Properties")]
        public Image TitleImage
        {
            get => lblTitle.Image;
            set => lblTitle.Image = value;
        }

        [Category("Custom Properties")]
        public Color TitleBackColor
        {
            get => lblTitle.BackColor;
            set => lblTitle.BackColor = value;
        }

        [Category("Custom Properties")]
        protected ucDataGridView Grid => GridView;
    }
}
