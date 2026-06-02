using DevToolkit.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.Core.Results;
using DevToolkit.Core.Common;
using DevToolkit.Core.Validation;

namespace DevToolkit.Core
{
    public abstract class BaseBusiness
    {
        public Mode Mode { get; protected set; }
        public virtual ValidationResult Validate() => new ValidationResult();
        protected abstract Result _AddNew();
        protected abstract Result _Update();
        public Result Save()
        {
            var validationResult = Validate();
            if (!validationResult.IsValid)
            {
                return Result.Failure(
                    string.Join(
                        Environment.NewLine,
                        validationResult.Errors.Select(e => $"{e.PropertyName}: {e.ErrorMessage}")));
            }
            switch (Mode)
            {
                case Mode.AddNew:
                    var addResult = _AddNew();
                    if (addResult.IsSuccess)
                        Mode = Mode.Update;
                    return addResult;
                case Mode.Update:
                    return _Update();
                default:
                    return Result.Failure("Invalid Mode");
            }
        }
    }
}
