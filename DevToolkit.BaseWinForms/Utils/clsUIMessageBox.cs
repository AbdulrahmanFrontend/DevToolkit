using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevToolkit.Core.Common;
using DevToolkit.BaseWinForms.Forms;

namespace DevToolkit.BaseWinForms.Utils
{
    public class clsUIMessageBox
    {
        public static DialogResult ShowSuccess(string Message)
            => Show(_Success(Message));

        public static DialogResult ShowError(string Message)
            => Show(_Error(Message));

        public static DialogResult ShowWarning(string Message)
            => Show(_Warning(Message));

        public static DialogResult ShowConfirm(string Message)
            => Show(_Confirm(Message));

        public static DialogResult ShowInfo(string Message)
            => Show(_Info(Message));

        public static DialogResult Show(clsMessageBoxData MessageBoxData)
        {
            var messageBox = new frmUIMessageBox(MessageBoxData);
            return messageBox.ShowDialog();
        }

        private static clsMessageBoxData _Success(string msg) =>
            new clsMessageBoxData
            {
                Message = msg,
                DialogType = DialogType.Success
            };

        private static clsMessageBoxData _Error(string msg) =>
            new clsMessageBoxData
            {
                Message = msg,
                DialogType = DialogType.Error
            };

        private static clsMessageBoxData _Warning(string msg) =>
            new clsMessageBoxData
            {
                Message = msg,
                DialogType = DialogType.Warning
            };

        private static clsMessageBoxData _Info(string msg) =>
            new clsMessageBoxData
            {
                Message = msg,
                DialogType = DialogType.Info
            };

        private static clsMessageBoxData _Confirm(string msg) => 
            new clsMessageBoxData
            {
                Message = msg,
                Buttons = MessageBoxButtons.YesNo,
                DialogType = DialogType.Confirm
            };
    }
}
