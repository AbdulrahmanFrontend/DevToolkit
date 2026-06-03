using DevToolkit.BaseWinForms.Forms;
using DevToolkit.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.BaseWinForms.Models;

namespace DevToolkit.BaseWinForms.Managers
{
    public class ToastManager
    {
        public static void ShowSuccess(string msg)
            => Show(_Success(msg));

        public static void ShowError(string msg)
            => Show(_Error(msg));

        public static void ShowWarning(string msg)
            => Show(_Warning(msg));

        public static void ShowInfo(string msg)
            => Show(_Info(msg));

        public static void Show(ToastModel ToastData)
        {
            var Toast = new frmToast(ToastData);
            Toast.Show();
        }

        private static ToastModel _Success(string msg) =>
            new ToastModel
            {
                Message = msg,
                DialogType = DialogType.Success,
            };

        private static ToastModel _Error(string msg) =>
            new ToastModel
            {
                Message = msg,
                DialogType = DialogType.Error,
            };

        private static ToastModel _Warning(string msg) =>
            new ToastModel
            {
                Message = msg,
                DialogType = DialogType.Warning,
            };

        private static ToastModel _Info(string msg) =>
            new ToastModel
            {
                Message = msg,
                DialogType = DialogType.Info,
            };
    }
}
