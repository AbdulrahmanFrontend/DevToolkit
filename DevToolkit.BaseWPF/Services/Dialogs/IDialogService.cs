using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DevToolkit.BaseWPF.Services.Dialogs
{
    public interface IDialogService
    {
        void ShowInfo(string message);

        void ShowError(string message);

        void ShowWarning(string message);

        bool Confirm(string message);
    }
}
