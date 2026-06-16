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
        public ucHeaderbarWithButton Headerbar => headerbar;

        [Category("Custom Properties")]
        public ucDataGridView Grid => GridView;
    }
}
