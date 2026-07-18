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
        protected Result _ValidateProperty<TObj>(string propName, TObj obj)
        {
            var ValResult = ObjectValidator.ValidateProperty<TObj>(
                typeof(TObj).GetProperty(propName), obj);

            if (ValResult.Any())
                return Result.Failure(
                    string.Join(", ",
                    ValResult.Select(x => x.ErrorMessage)) + "!");

            return Result.Success();
        }
        public virtual Result Valid()
        {
            var ValResult = _Validate();

            if (!ValResult.IsValid)
                return Result.Failure(
                    string.Join(", ",
                    ValResult.Errors.Select(x => x.ErrorMessage)) + "!");

            return Result.Success();
        }
        protected virtual ValidationResult _Validate() => new ValidationResult();
        protected abstract Result _AddNew();
        protected abstract Result _Update();
        protected static void _ThrowException(Result result)
        {
            if (!result.IsSuccess)
                throw new InvalidOperationException(result?.Message ?? "خطأ غير متوقع!");
        }
        protected static void _ThrowException<T>(Result<T> result)
        {
            if (!result.IsSuccess)
                throw new InvalidOperationException(result?.Message ?? "خطأ غير متوقع!");
        }
        public virtual Result Save()
        {
            Result result = Valid();

            if (!result.IsSuccess)
                return result;

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
                    return Result.Failure("Invalid Mode!");
            }
        }
    }
}
