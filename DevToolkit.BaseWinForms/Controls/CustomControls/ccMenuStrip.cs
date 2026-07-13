using DevToolkit.BaseWinForms.Theming;
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
    public partial class ccMenuStrip : MenuStrip
    {
        public ccMenuStrip()
        {
            InitializeComponent();

            Renderer = new ToolStripProfessionalRenderer(
                new ArabicDarkColorTable());

            Font = new Font("Segoe UI", 10F);

            GripStyle = ToolStripGripStyle.Hidden;

            RenderMode = ToolStripRenderMode.Professional;

            ImageScalingSize = new Size(18, 18);

            Cursor = Cursors.Hand;

            Padding = new Padding(10, 4, 10, 4);

            Dock = DockStyle.Top;
        }

        protected override void OnItemAdded(
            ToolStripItemEventArgs e)
        {
            base.OnItemAdded(e);

            ApplyStyle(e.Item);
        }

        private void ApplyStyle(ToolStripItem item)
        {
            item.Font = DevFonts.Menu;

            item.ForeColor = this.ForeColor;

            item.BackColor = this.BackColor;

            if (item is ToolStripMenuItem menu)
            {
                foreach (ToolStripItem child in menu.DropDownItems)
                {
                    ApplyStyle(child);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
