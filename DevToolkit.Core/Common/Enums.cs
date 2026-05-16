using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Core.Common
{
    public class Enums
    {
        public enum Mode { AddNew, Edit, Update }
        public enum DialogType 
        { 
            Success, Warning, Error, Info, Confirm
        }
        public enum Status { Active, Inactive }
    }
}
