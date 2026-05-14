using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevToolkit.Core;
using DevToolkit.BasicUI.Forms;

namespace DevToolkit.BasicUI.Utils
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

        private static clsMessageBoxData _Success(string msg)
        {
            return new clsMessageBoxData
            {
                Message = msg,
                DialogType = Enums.DialogType.Success
            };
        }

        private static clsMessageBoxData _Error(string msg)
        {
            return new clsMessageBoxData
            {
                Message = msg,
                DialogType = Enums.DialogType.Error
            };
        }

        private static clsMessageBoxData _Warning(string msg)
        {
            return new clsMessageBoxData
            {
                Message = msg,
                DialogType = Enums.DialogType.Warning
            };
        }

        private static clsMessageBoxData _Info(string msg)
        {
            return new clsMessageBoxData
            {
                Message = msg,
                DialogType = Enums.DialogType.Info
            };
        }

        private static clsMessageBoxData _Confirm(string msg)
        {
            return new clsMessageBoxData
            {
                Message = msg,
                Buttons = MessageBoxButtons.YesNo,
                DialogType = Enums.DialogType.Confirm
            };
        }
    }
}
