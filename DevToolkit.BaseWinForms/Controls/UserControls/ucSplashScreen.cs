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
    public partial class ucSplashScreen : UserControl
    {
        public ucSplashScreen()
        {
            InitializeComponent();
        }

        private void ucSplashScreen_Load(object sender, EventArgs e)
        {
            tSplash.Start();
        }

        private void tSplash_Tick(object sender, EventArgs e)
        {
            if (pbLoading.Value < pbLoading.Maximum)
                pbLoading.Value++;
            else
            {
                tSplash.Stop();
                if(SplashCompleted != null)
                    RaiseSplashCompleted();
            }
        }

        [Category("Custom Events")]
        public event Action SplashCompleted;
        protected virtual void RaiseSplashCompleted()
        {
            Action Handler = SplashCompleted;
            if (Handler != null)
                Handler();
        }

        [Category("Custom Properties")]
        public Image Logo
        {
            get => picbLogo.Image;
            set => picbLogo.Image = value;
        }

        [Category("Custom Properties")]
        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        [Category("Custom Properties")]
        public string SubTitle
        {
            get => lblSubTitle.Text;
            set => lblSubTitle.Text = value;
        }

        [Category("Custom Properties")]
        public string LoadingMessage
        {
            get => lblLoading.Text;
            set => lblLoading.Text = value;
        }

        [Category("Custom Properties")]
        public string Footer
        {
            get => lblFooter.Text;
            set => lblFooter.Text = value;
        }

        [Category("Custom Properties")]
        public Color TitleColor
        {
            get => lblTitle.ForeColor;
            set => lblTitle.ForeColor = value;
        }

        [Category("Custom Properties")]
        public Font TitleFont
        {
            get => lblTitle.Font;
            set => lblTitle.Font = value;
        }

        [Category("Custom Properties")]
        public Font SubTitleFont
        {
            get => lblSubTitle.Font;
            set => lblSubTitle.Font = value;
        }
    }
}
