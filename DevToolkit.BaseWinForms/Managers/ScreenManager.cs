using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevToolkit.BaseWinForms.Managers
{
    public static class ScreenManager
    {
        public static void ShowScreen(Panel host, UserControl screen)
        {
            host.Controls.Clear();

            screen.Dock = DockStyle.Fill;

            host.Controls.Add(screen);
        }
    }
}
