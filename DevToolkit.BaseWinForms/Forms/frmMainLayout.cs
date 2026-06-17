using DevToolkit.BaseWinForms.Controls.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevToolkit.BaseWinForms.Forms
{
    public partial class frmMainLayout : frmBase
    {
        public frmMainLayout()
        {
            InitializeComponent();
        }

        [Category("Custom Properties")]
        protected Panel pnlContent => pnlContainer;

        [Category("Custom Properties")]
        protected ucSidebar Sidebar => sidebar;

        [Category("Custom Properties")]
        protected ucHeaderbar Headerbar => headerbar;
    }
}
