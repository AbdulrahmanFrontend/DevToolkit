using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.Core.Common;

namespace DevToolkit.BaseWinForms.Models
{
    public class ToastModel
    {
        public string Message { get; set; }
        public DialogType DialogType { get; set; }
    }
}
