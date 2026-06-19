using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DevToolkit.BaseWPF.Services.Dialogs
{
    public class DialogService : IDialogService
    {
        public void ShowInfo(string message)
            => MessageBox.Show(
                message,
                "Information",
                MessageBoxButton.OK, 
                MessageBoxImage.Information);

        public void ShowError(string message)
            => MessageBox.Show(
                message, 
                "Error",
                MessageBoxButton.OK,
                MessageBoxImage.Error);

        public void ShowWarning(string message)
            => MessageBox.Show(
                message, 
                "Warning",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);

        public bool Confirm(string message)
        {
            var result = MessageBox.Show(
                message,
                "Confirmation",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            return result == MessageBoxResult.Yes;
        }
    }
}
