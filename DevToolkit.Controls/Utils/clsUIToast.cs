using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.Core;

namespace DevToolkit.Controls.Utils
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
        
        private static clsToastData _Success(string msg)
        {
            return new clsToastData
            {
                Message = msg,
                DialogType = clsEnums.enDialogType.enSuccess,
            };
        }

        private static clsToastData _Error(string msg)
        {
            return new clsToastData
            {
                Message = msg,
                DialogType = clsEnums.enDialogType.enError,
            };
        }

        private static clsToastData _Warning(string msg)
        {
            return new clsToastData
            {
                Message = msg,
                DialogType = clsEnums.enDialogType.enWarning,
            };
        }

        private static clsToastData _Info(string msg)
        {
            return new clsToastData
            {
                Message = msg,
                DialogType = clsEnums.enDialogType.enInfo,
            };
        }
    }
}
