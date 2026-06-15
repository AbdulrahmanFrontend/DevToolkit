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
    public partial class ccContextMenuStrip : ContextMenuStrip
    {
        public ccContextMenuStrip()
        {
            InitializeComponent();

            // تطبيق جدول الألوان الاحترافي عبر الـ Renderer
            this.Renderer = new ToolStripProfessionalRenderer(
                new ArabicDarkColorTable());

            // إعدادات التوافق الكامل مع الأنظمة العربية
            this.RightToLeft = RightToLeft.Yes;

            // لون الخط الافتراضي (أبيض ناصع يتناسب مع الخلفية الداكنة)
            this.ForeColor = Color.FromArgb(241, 243, 244);

            // استخدام خط Segoe UI الحديث المريح جداً في القراءة باللغة العربية
            this.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            // تخصيص مساحة الهوامش لضمان عدم تداخل الأيقونات مع النصوص العربية
            this.ShowCheckMargin = false;
            this.ShowImageMargin = true;
            this.ImageScalingSize = new Size(16, 16); 
            // الحجم القياسي للأيقونات UX
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnItemAdded(ToolStripItemEventArgs e)
        {
            base.OnItemAdded(e);
            e.Item.ForeColor = this.ForeColor;
        }
    }
}
