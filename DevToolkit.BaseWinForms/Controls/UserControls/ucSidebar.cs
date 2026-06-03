using DevToolkit.BaseWinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevToolkit.BaseWinForms.Controls.UserControls
{
    public partial class ucSidebar : UserControl
    {
        public ucSidebar()
        {
            InitializeComponent();
        }

        [Category("Custom Properties")]
        public Image Logo
        {
            get => picbLogo.Image;
            set => picbLogo.Image = value;
        }

        [Category("Custom Properties")]
        public IEnumerable<NavigationButtonModel> ButtonsInfo
        {
            get => _buttons.Select(b => new NavigationButtonModel
                {
                    Title = b.Text,
                    Icon = b.Image,
                });
            set
            {
                pnlButtons.Controls.Clear();

                var buttonsInfo = value.ToList();

                int Index = 0;
                int lastIndex = buttonsInfo.Count - 1;

                foreach (var buttonInfo in buttonsInfo)
                {
                    Button btn = new Button();

                    btn.ImageAlign = ButtonIconAlignment;
                    btn.TextAlign = ButtonTextAlignment;
                    btn.Padding = ButtonPadding;
                    btn.Margin = ButtonMargin;
                    btn.Height = ButtonHeight;
                    btn.TextImageRelation = ButtonTextImageRelation;
                    btn.RightToLeft = this.RightToLeft;

                    btn.Dock = DockStyle.Top;
                    btn.Cursor = Cursors.Hand;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.UseVisualStyleBackColor = false;

                    btn.Text = buttonInfo.Title;
                    btn.Image = buttonInfo.Icon;

                    btn.Click += (s, e) => {
                        var b = s as Button;
                        ScreenSelected?.Invoke(b, new ScreenSelectedEventArgs(btn.Text));

                        if (_buttons.Count() > 0)
                            foreach (var button in _buttons)
                                button.BackColor = BackColor;

                        b.BackColor = SelectedButtonColor;
                    };

                    pnlButtons.Controls.Add(btn);

                    if (Index == lastIndex)
                        btn.BackColor = SelectedButtonColor;

                    Index++;
                }
            }
        }

        [Category("Custom Properties")]
        public Color SelectedButtonColor { get; set; }

        public class ScreenSelectedEventArgs : EventArgs
        {
            public string ScreenName { get; }

            public ScreenSelectedEventArgs(string screenName)
            {
                this.ScreenName = screenName;
            }
        }

        [Category("Custom Events")]
        public event EventHandler<ScreenSelectedEventArgs> ScreenSelected;

        private IEnumerable<Button> _buttons => pnlButtons.Controls.OfType<Button>();
        private ContentAlignment _btnIconAlignment = ContentAlignment.MiddleLeft;
        private ContentAlignment _btnTextAlignment = ContentAlignment.MiddleCenter;
        private Padding _btnPadding = new Padding(0);
        private Padding _btnMargin = new Padding(0, 0, 0, 5);
        private int _btnHeight = 50;
        private TextImageRelation _btnTextImageRelation = TextImageRelation.Overlay;

        [Category("Custom Properties")]
        public ContentAlignment ButtonIconAlignment
        {
            get => _btnIconAlignment;
            set
            {
                if(_btnIconAlignment != value)
                {
                    _btnIconAlignment = value;
                    _UpdateButtonsStyles();
                }
            }
        }

        [Category("Custom Properties")]
        public ContentAlignment ButtonTextAlignment
        {
            get => _btnTextAlignment;
            set
            {
                if(_btnTextAlignment != value)
                {
                    _btnTextAlignment = value;
                    _UpdateButtonsStyles();
                }
            }
        }

        [Category("Custom Properties")]
        public Padding ButtonPadding
        {
            get => _btnPadding;
            set
            {
                if (_btnPadding != value)
                {
                    _btnPadding = value;
                    _UpdateButtonsStyles();
                }
            }
        }

        [Category("Custom Properties")]
        public Padding ButtonMargin
        {
            get => _btnMargin;
            set
            {
                if (_btnMargin != value)
                {
                    _btnMargin = value;
                    _UpdateButtonsStyles();
                }
            }
        }

        [Category("Custom Properties")]
        public override RightToLeft RightToLeft
        {
            get => base.RightToLeft;
            set
            {
                if (base.RightToLeft != value)
                {
                    base.RightToLeft = value;
                    _UpdateButtonsStyles();
                }
            }
        }

        [Category("Custom Properties")]
        public int ButtonHeight
        {
            get => _btnHeight;
            set
            {
                if (_btnHeight != value)
                {
                    _btnHeight = value;
                    _UpdateButtonsStyles();
                }
            }
        }

        [Category("Custom Properties")]
        public TextImageRelation ButtonTextImageRelation
        {
            get => _btnTextImageRelation;
            set
            {
                if (_btnTextImageRelation != value)
                {
                    _btnTextImageRelation = value;
                    _UpdateButtonsStyles();
                }
            }
        }

        private void _UpdateButtonsStyles()
        {
            if (!_buttons.Any())
                return;

            foreach (var btn in _buttons)
            {
                btn.ImageAlign = ButtonIconAlignment;
                btn.TextAlign = ButtonTextAlignment;
                btn.Padding = ButtonPadding;
                btn.Margin = ButtonMargin;
                btn.RightToLeft = this.RightToLeft;
                btn.Height = ButtonHeight;
                btn.TextImageRelation = ButtonTextImageRelation;
            }
        }
    }
}
