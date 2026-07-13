using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevToolkit.BaseWinForms.Controls.CustomControls
{
    public partial class ccStatusStrip : StatusStrip
    {
        public ccStatusStrip()
        {
            InitializeComponent();

            Font = new Font("Segoe UI", 9F);

            BackColor = Color.FromArgb(248, 250, 252);

            ForeColor = Color.FromArgb(30, 41, 59);

            SizingGrip = false;

            RenderMode = ToolStripRenderMode.System;
        }
        
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
