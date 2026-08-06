using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevToolkit.BaseWinForms.Theming;

namespace DevToolkit.BaseWinForms.Forms
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }

        private Themes _CurrentTheme { get; set; }

        protected virtual void ApplyTheme()
        {
            
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            _CurrentTheme = ThemeManager.CurrentTheme;

            ApplyTheme();
        }
    }
}
