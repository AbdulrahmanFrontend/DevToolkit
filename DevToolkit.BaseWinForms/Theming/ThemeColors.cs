using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.BaseWinForms.Theming
{
    public class ThemeColors
    {
        public Color Background { get; set; } = Color.FromArgb(255, 255, 255);
        public Color TextPrimary { get; set; } = Color.FromArgb(0, 0, 0);
        public Color Surface { get; set; } = Color.FromArgb(240, 240, 240);
        public Color Border { get; set; } = Color.FromArgb(200, 200, 200);
    }
}
