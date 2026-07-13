using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.BaseWinForms.Theming
{
    public static class DevFonts
    {
        public static readonly Font Default =
            new Font("Segoe UI", 9F);

        public static readonly Font Body =
            new Font("Segoe UI", 10F);

        public static readonly Font Bold =
            new Font("Segoe UI", 10F, FontStyle.Bold);

        public static readonly Font Title =
            new Font("Segoe UI", 18F, FontStyle.Bold);

        public static readonly Font Small =
            new Font("Segoe UI", 8F);

        public static readonly Font Menu =
            new Font("Segoe UI", 10F);

        public static readonly Font GridHeader =
            new Font("Segoe UI", 10F, FontStyle.Bold);
    }
}
