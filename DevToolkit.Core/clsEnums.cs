using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Core
{
    public class clsEnums
    {
        public enum enMode { enAddNew, enEdit, enUpdate }
        public enum enDialogType 
        { 
            enSuccess, enWarning, enError, enInfo, enConfirm
        }
        public enum enStatus { Active, Inactive }
    }
}
