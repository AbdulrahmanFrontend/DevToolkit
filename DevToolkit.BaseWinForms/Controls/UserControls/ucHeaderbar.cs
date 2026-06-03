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
        public string Title
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
    }
}
