using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Core.Common
{
    public enum Mode
    {
        AddNew,
        Update
    }

    public enum DialogType
    {
        Success,
        Warning,
        Error,
        Info,
        Confirm
    }

    public enum Status { Active, Inactive }

    public enum LogLevel
    {
        Info,
        Warning,
        Error,
        Debug
    }

    public enum Language { ar, en }
}
