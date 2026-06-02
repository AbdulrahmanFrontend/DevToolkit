using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.Core.Common;
using DevToolkit.BaseWinForms.Forms;

namespace DevToolkit.BaseWinForms.Utils
{
    public class clsUIToast
    {
        public static void ShowSuccess(string msg)
            => Show(_Success(msg));

        public static void ShowError(string msg)
            => Show(_Error(msg));

        public static void ShowWarning(string msg)
            => Show(_Warning(msg));

        public static void ShowInfo(string msg)
            => Show(_Info(msg));

        public static void Show(clsToastData ToastData)
        {
            var Toast = new frmToast(ToastData);
            Toast.Show();
        }
        
        private static clsToastData _Success(string msg) =>
            new clsToastData
            {
                Message = msg,
                DialogType = DialogType.Success,
            };

        private static clsToastData _Error(string msg) =>
            new clsToastData
            {
                Message = msg,
                DialogType = DialogType.Error,
            };

        private static clsToastData _Warning(string msg) =>
            new clsToastData
            {
                Message = msg,
                DialogType = DialogType.Warning,
            };

        private static clsToastData _Info(string msg) =>
            new clsToastData
            {
                Message = msg,
                DialogType = DialogType.Info,
            };
    }
}
