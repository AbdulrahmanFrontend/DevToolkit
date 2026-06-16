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
    public partial class ucHeaderbarWithButton : UserControl
    {
        public ucHeaderbarWithButton()
        {
            InitializeComponent();
        }

        [Category("Custom Properties")]
        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        [Category("Custom Properties")]
        public Image ButtonBackgroundImage
        {
            get => btnAction.BackgroundImage;
            set => btnAction.BackgroundImage = value;
        }

        [Category("Custom Properties")]
        public string ButtonText
        {
            get => btnAction.Text;
            set => btnAction.Text = value;
        }

        [Category("Custom Properties")]
        public float ButtonWidth
        {
            get => tlpContainer.ColumnStyles[1].Width;
            set => tlpContainer.ColumnStyles[1].Width = value;
        }

        public void RaiseActionClicked() 
            => RaiseActionClicked(new ActionClickedEventArgs());

        protected virtual void RaiseActionClicked(ActionClickedEventArgs e)
            => this.ActionClicked?.Invoke(this, e);

        [Category("Custom Events")]
        public event EventHandler<ActionClickedEventArgs> ActionClicked;

        public class ActionClickedEventArgs : EventArgs
        {

        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (ActionClicked != null)
                RaiseActionClicked();
        }
    }
}
