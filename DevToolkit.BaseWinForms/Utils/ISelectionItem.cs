using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.BaseWinForms.Utils
{
    public interface ISelectionItem
    {
        int ItemID { get; set; }
        string ItemText { get; set; }
        bool Checked { get; set; }
    }
}
