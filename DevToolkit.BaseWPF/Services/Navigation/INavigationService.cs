using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DevToolkit.BaseWPF.Services.Navigation
{
    public interface INavigationService
    {
        void NavigateTo<TWindow>(Window currentWindow) where TWindow : Window, new();
    }
}
