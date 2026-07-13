using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.BaseWinForms.Theming
{
    public static class DevColors
    {
        // Primary

        public static readonly Color Primary =
            Color.FromArgb(37, 99, 235);

        public static readonly Color PrimaryHover =
            Color.FromArgb(29, 78, 216);

        public static readonly Color PrimaryPressed =
            Color.FromArgb(30, 64, 175);

        //----------------------------------------------------

        // Backgrounds

        public static readonly Color Background =
            Color.FromArgb(248, 250, 252);

        public static readonly Color Surface =
            Color.White;

        public static readonly Color Sidebar =
            Color.FromArgb(15, 23, 42);

        //----------------------------------------------------

        // Text

        public static readonly Color TextPrimary =
            Color.FromArgb(30, 41, 59);

        public static readonly Color TextSecondary =
            Color.FromArgb(100, 116, 139);

        public static readonly Color TextWhite =
            Color.White;

        //----------------------------------------------------

        // Borders

        public static readonly Color Border =
            Color.FromArgb(203, 213, 225);

        //----------------------------------------------------

        // Status

        public static readonly Color Success =
            Color.FromArgb(22, 163, 74);

        public static readonly Color Warning =
            Color.FromArgb(245, 158, 11);

        public static readonly Color Danger =
            Color.FromArgb(220, 38, 38);

        //----------------------------------------------------

        // Menu

        public static readonly Color MenuBackground =
            Color.FromArgb(32, 33, 36);

        public static readonly Color MenuHover =
            Color.FromArgb(53, 54, 58);

        public static readonly Color MenuBorder =
            Color.FromArgb(60, 64, 67);

        //----------------------------------------------------

        // Grid

        public static readonly Color GridHeader =
            Color.FromArgb(241, 245, 249);

        public static readonly Color GridSelection =
            Color.FromArgb(219, 234, 254);

        public static readonly Color GridAlternate =
            Color.FromArgb(248, 250, 252);
    }
}
