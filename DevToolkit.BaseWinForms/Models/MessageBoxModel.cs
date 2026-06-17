using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevToolkit.Core.Common;

namespace DevToolkit.BaseWinForms.Models
{
    public class MessageBoxModel
    {
        public Language Lang { get; set; } = Language.ar;
        public string Message { get; set; }
        public MessageBoxButtons Buttons { get; set; } = MessageBoxButtons.OK;
        public DialogType DialogType { get; set; }
    }
}
