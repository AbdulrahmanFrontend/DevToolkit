using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.BasicUI.Utils
{
    public class clsAppColors
    {
        public static readonly Color Primary = Color.FromArgb(30, 41, 59);
        public static readonly Color Background = Color.FromArgb(248, 250, 252);

        public static readonly Color Success = Color.FromArgb(34, 197, 94);
        public static readonly Color Danger = Color.FromArgb(239, 68, 68);
        public static readonly Color Warning = Color.FromArgb(245, 158, 11);
        public static readonly Color Accent = Color.FromArgb(59, 130, 246);
        public static readonly Color Highlight = Color.Gray;

        // Text
        public static readonly Color TextPrimary = Color.White;
        public static readonly Color TextSecondary = Color.FromArgb(100, 116, 139);
        public static readonly Color TextOnPrimary = Color.FromArgb(30, 41, 59);

        public static readonly Color Border = Color.LightBlue;

        // Selection
        public static readonly Color SelectedOption = Color.DarkCyan;
    }
}
