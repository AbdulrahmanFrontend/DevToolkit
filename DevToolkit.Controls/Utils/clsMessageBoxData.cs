using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevToolkit.Core;

namespace DevToolkit.Controls.Utils
{
    public class clsMessageBoxData
    {
        public string Message { get; set; }
        public MessageBoxButtons Buttons { get; set; } = MessageBoxButtons.OK;
        public clsEnums.enDialogType DialogType { get; set; }
    }
}
