using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevToolkit.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            _WarnTime(
                "30 Minutes Remaining",
                "You have 30 minutes left. Start reviewing your answers.",
                Color.Yellow,
                ToolTipIcon.Info);
        }

        private void _WarnTime(string title, string message,
            Color timerColor, ToolTipIcon icon)
        {
            //timer1.ForeColor = timerColor;

            notifyIcon1.BalloonTipTitle = title;
            notifyIcon1.BalloonTipText = message;
            notifyIcon1.BalloonTipIcon = icon;
            notifyIcon1.ShowBalloonTip(6000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
