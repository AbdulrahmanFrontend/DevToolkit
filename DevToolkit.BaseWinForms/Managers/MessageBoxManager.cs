using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevToolkit.Core.Common;
using DevToolkit.BaseWinForms.Models;
using DevToolkit.BaseWinForms.Forms;

namespace DevToolkit.BaseWinForms.Managers
{
    public class MessageBoxManager
    {
        public static DialogResult ShowSuccess(string message, Language lang)
            => Show(_Success(message, lang));

        public static DialogResult ShowError(string message, Language lang)
            => Show(_Error(message, lang));

        public static DialogResult ShowWarning(string Message, Language lang)
            => Show(_Warning(Message, lang));

        public static DialogResult ShowConfirm(string Message, Language lang)
            => Show(_Confirm(Message, lang));

        public static DialogResult ShowInfo(string Message, Language lang)
            => Show(_Info(Message, lang));

        public static DialogResult Show(MessageBoxModel MessageBoxData)
        {
            var messageBox = new frmUIMessageBox(MessageBoxData);
            return messageBox.ShowDialog();
        }

        private static MessageBoxModel _Success(string msg, Language lang) =>
            new MessageBoxModel
            {
                Message = msg,
                DialogType = DialogType.Success,
                Lang = lang,
            };

        private static MessageBoxModel _Error(string msg, Language lang) =>
            new MessageBoxModel
            {
                Message = msg,
                DialogType = DialogType.Error,
                Lang = lang,
            };

        private static MessageBoxModel _Warning(string msg, Language lang) =>
            new MessageBoxModel
            {
                Message = msg,
                DialogType = DialogType.Warning,
                Lang = lang,
            };

        private static MessageBoxModel _Info(string msg, Language lang) =>
            new MessageBoxModel
            {
                Message = msg,
                DialogType = DialogType.Info,
                Lang = lang,
            };

        private static MessageBoxModel _Confirm(string msg, Language lang) => 
            new MessageBoxModel
            {
                Message = msg,
                Buttons = MessageBoxButtons.YesNo,
                DialogType = DialogType.Confirm,
                Lang = lang,
            };
    }
}
