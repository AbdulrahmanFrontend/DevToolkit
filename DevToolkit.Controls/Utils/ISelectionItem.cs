using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Controls.Utils
{
    public interface ISelectionItem
    {
        int ItemId { get; set; }
        string ItemText { get; set; }
        bool Checked { get; set; }
        event EventHandler CheckedChanged;
    }
}
