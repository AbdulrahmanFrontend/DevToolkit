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

        protected virtual void _ApplyTheme(ThemeColors theme)
        {
            this.BackColor = theme.Background;
            this.ForeColor = theme.TextPrimary;
        }

        protected delegate void ThemeChangedEventHandler(ThemeColors newTheme);
        protected ThemeChangedEventHandler ThemeChanged;
    }
}
