using DevToolkit.BaseWinForms.Utils;
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
    public partial class ucHeaderbar : UserControl
    {
        public ucHeaderbar()
        {
            InitializeComponent();
        }

        [Category("Custom Properties")]
        public string SystemName
        {
            get => lblSystemName.Text;
            set => lblSystemName.Text = value;
        }

        [Category("Custom Properties")]
        public string UserName
        {
            get => lblUserName.Text;
            set => lblUserName.Text = value;
        }

        [Category("Custom Properties")]
        public bool ShowUserName 
        { 
            get => lblUserName.Visible;
            set => lblUserName.Visible = value; 
        }

        [Category("Custom Properties")]
        public bool ShowDate 
        { 
            get => lblDate.Visible;
            set => lblDate.Visible = value; 
        }

        [Category("Custom Properties")]
        public bool ShowTime 
        { 
            get => lblTime.Visible;
            set
            {
                lblTime.Visible = value;
                tDateTime.Enabled = value;
            } 
        }

        [Category("Custom Properties")]
        public Image ButtonImage
        {
            get => btnAction.Image;
            set => btnAction.Image = value;
        }

        [Category("Custom Properties")]
        public string ButtonText
        {
            get => btnAction.Text;
            set => btnAction.Text = value;
        }

        [Category("Custom Properties")]
        public Color ButtonColor
        {
            get => btnAction.BackColor;
            set => btnAction.BackColor = value;
        }

        [Category("Custom Properties")]
        public ContentAlignment ButtonTextAlign
        {
            get => btnAction.TextAlign;
            set => btnAction.TextAlign = value;
        }

        [Category("Custom Properties")]
        public ContentAlignment ButtonImageAlign
        {
            get => btnAction.ImageAlign;
            set => btnAction.ImageAlign = value;
        }

        private void tDateTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("t");
        }

        private void ucHeaderbar_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("d");
            lblTime.Text = DateTime.Now.ToString("t");

            if (ShowDate || ShowTime)
                tDateTime.Start();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (ActionClick != null)
                RaiseActionClick();
        }

        public void RaiseActionClick()
        {
            RaiseActionClick(new ActionClickEventArgs());
        }

        protected virtual void RaiseActionClick(ActionClickEventArgs e)
        {
            ActionClick?.Invoke(this, e);
        }

        [Category("Custom Events")]
        [Description("Occurs when the action button is clicked.")]
        public event EventHandler<ActionClickEventArgs> ActionClick;

        public class ActionClickEventArgs : EventArgs
        {
            // You can add properties here if you want to pass additional data with the event
        }
    }
}
