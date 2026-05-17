using DevToolkit.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.Core.Results;
using DevToolkit.Core.Common;

namespace DevToolkit.Core
{
    public abstract class BaseBusiness
    {
        public Enums.Mode Mode { get; protected set; }
        public virtual Result Validate() => Result.Success();
        protected abstract bool _AddNew();
        protected abstract bool _Update();
        public Result Save()
        {
            var Result = Validate();
            if (!Result.IsSuccess)
            {
                return Result;
            }
            switch (Mode)
            {
                case Enums.Mode.AddNew:
                    if (_AddNew())
                    {
                        Mode = Enums.Mode.Update;
                        return Result.Success("Saved Successfully");
                    }
                    return Result.Failure("Insert Failed");
                case Enums.Mode.Update:
                    return _Update() ? 
                        Result.Success("Updated Successfully") : 
                        Result.Failure("Update Failed");
                default:
                    return Result.Failure("Invalid Mode");
            }
        }
    }
}
