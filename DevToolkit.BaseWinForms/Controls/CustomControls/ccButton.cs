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
    public partial class ccButton : Button
    {
        private ButtonStyle _style = ButtonStyle.Primary;

        [Category("DevToolkit")]
        public ButtonStyle ButtonStyle
        {
            get => _style;
            set
            {
                _style = value;
                ApplyStyle();
            }
        }

        public ccButton()
        {
            InitializeComponent();

            this.FlatStyle = FlatStyle.Flat;

            this.FlatAppearance.BorderSize = 0;

            this.FlatAppearance.MouseOverBackColor =
                ControlPaint.Light(this.BackColor, 0.08f);

            this.FlatAppearance.MouseDownBackColor =
                ControlPaint.Dark(this.BackColor, 0.08f);

            Cursor = Cursors.Hand;

            Font = DevFonts.Bold;

            Height = 40;

            Width = 120;

            ForeColor = DevColors.TextWhite;

            this.Padding = new Padding(10, 0, 10, 0);

            ApplyStyle();
        }

        private void ApplyStyle()
        {
            switch (_style)
            {
                case ButtonStyle.Primary:

                    BackColor = DevColors.Primary;

                    FlatAppearance.MouseOverBackColor =
                        DevColors.PrimaryHover;

                    FlatAppearance.MouseDownBackColor =
                        DevColors.PrimaryPressed;

                    ForeColor = DevColors.TextWhite;

                    break;

                case ButtonStyle.Secondary:

                    BackColor = DevColors.Background;

                    FlatAppearance.BorderSize = 1;

                    FlatAppearance.BorderColor =
                        DevColors.Border;

                    FlatAppearance.MouseOverBackColor =
                        Color.WhiteSmoke;

                    ForeColor = DevColors.TextPrimary;

                    break;

                case ButtonStyle.Success:

                    BackColor = DevColors.Success;

                    FlatAppearance.MouseOverBackColor =
                        Color.FromArgb(22, 145, 74);

                    ForeColor = Color.White;

                    break;

                case ButtonStyle.Danger:

                    BackColor = DevColors.Danger;

                    FlatAppearance.MouseOverBackColor =
                        Color.FromArgb(185, 28, 28);

                    ForeColor = Color.White;

                    break;
            }
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);

            this.FlatAppearance.MouseOverBackColor =
                ControlPaint.Light(this.BackColor, 0.08f);

            this.FlatAppearance.MouseDownBackColor =
                ControlPaint.Dark(this.BackColor, 0.08f);
        }
    }
}
