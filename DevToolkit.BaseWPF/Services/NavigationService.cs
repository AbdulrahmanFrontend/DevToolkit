using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DevToolkit.BaseWPF.Services
{
    public class NavigationService
    {
        public void NavigateTo<TWindow>(Window currentWindow)
        where TWindow : Window, new()
        {
            var window = new TWindow();

            window.Show();

            currentWindow.Close();
        }
    }
}
