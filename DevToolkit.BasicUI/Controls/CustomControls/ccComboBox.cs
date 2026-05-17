using DevToolkit.Core.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevToolkit.BasicUI.Controls.CustomControls
{
    public partial class ccComboBox : ComboBox
    {
        public ccComboBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        [Category("Custom Properties")]
        public bool Required { get; set; }

        [Category("Custom Properties")]
        public Result IsValid => 
            (Required && !string.IsNullOrEmpty(this.Text)) ? 
            Result.Success() : Result.Failure("Required");
    }
}
