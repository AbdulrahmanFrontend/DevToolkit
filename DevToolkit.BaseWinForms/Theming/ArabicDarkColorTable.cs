using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevToolkit.BaseWinForms.Theming
{
    public class ArabicDarkColorTable : ProfessionalColorTable
    {
        // لون الخلفية الرئيسي للقائمة
        public override Color ToolStripDropDownBackground
            => Color.FromArgb(32, 33, 36);

        // لون الحواف الخارجية للقائمة
        public override Color ToolStripBorder => Color.FromArgb(60, 64, 67);

        // لون الخلفية الجانبية المخصصة للأيقونات (تمنع ظهور الشريط الأبيض المشوه)
        public override Color ImageMarginGradientBegin
            => Color.FromArgb(32, 33, 36);
        public override Color ImageMarginGradientMiddle
            => Color.FromArgb(32, 33, 36);
        public override Color ImageMarginGradientEnd
            => Color.FromArgb(32, 33, 36);

        // لون عنصر القائمة عند تحريك الماوس فوقه (Hover)
        public override Color MenuItemSelected => Color.FromArgb(53, 54, 58);

        // لون حواف العنصر المحدد
        public override Color MenuItemBorder => Color.FromArgb(138, 180, 248);
    }
}
