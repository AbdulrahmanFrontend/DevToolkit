using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.Core.Common;

namespace DevToolkit.BaseWinForms.Theming
{
    public static class ThemeManager
    {
        public static ThemeType CurrentTheme { get; set; } = ThemeType.Light;
    }
}
