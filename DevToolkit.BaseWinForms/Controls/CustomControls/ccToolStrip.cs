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
    public partial class ccToolStrip : ToolStrip
    {
        public ccToolStrip()
        {
            InitializeComponent();

            GripStyle = ToolStripGripStyle.Hidden;

            Font = new Font("Segoe UI", 9F);

            BackColor = Color.White;

            ForeColor = Color.FromArgb(30, 41, 59);

            RenderMode = ToolStripRenderMode.System;

            ImageScalingSize = new Size(18, 18);

            Padding = new Padding(6);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
