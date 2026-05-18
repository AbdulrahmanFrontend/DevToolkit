using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DevToolkit.Core.Guards;
using DevToolkit.Core.Validation.Attributes;
using DevToolkit.Core.Validation.Patterns;

namespace DevToolkit.Core.Validation
{
    public class ObjectValidator
    {
        public static ValidationResult ValidateObject<T>(T obj)
        {
            Type type = typeof(T);
            ValidationResult Result = new ValidationResult();
            List<ValidationError> PropErrors = new List<ValidationError>();
            foreach (PropertyInfo prop in type.GetProperties())
            {
                PropErrors = ValidateProperty<T>(prop, obj);
                if (PropErrors.Count > 0)
                {
                    Result.Errors.AddRange(PropErrors);
                }
            }
            return Result;
        }

        public static List<ValidationError> ValidateProperty<T>(PropertyInfo Prop, T obj)
        {
            List<ValidationError> Errors = new List<ValidationError>();

            var Value = Prop.GetValue(obj);
            RequiredAttribute RequiredAttr = Prop.GetCustomAttribute<RequiredAttribute>();
            if (RequiredAttr != null)
            {
                if(Value == null || (Value is string Str && !Guard.HasValue(Str)))
                {
                    _AddError(ref Errors, Prop.Name, RequiredAttr.ErrorMessage);
                }
            }

            RangeAttribute RangeAttr = Prop.GetCustomAttribute<RangeAttribute>();
            if (RangeAttr != null)
            {
                if (Value != null)
                {
                    if (Value is int IntValue && !Guard.InRange(IntValue, RangeAttr.Min, RangeAttr.Max))
                    {
                        _AddError(ref Errors, Prop.Name, RangeAttr.ErrorMessage);
                    }
                }
            }

            var StrValue = Value as string;
            bool HasValue = Guard.HasValue(StrValue);

            LengthAttribute LengthAttr = Prop.GetCustomAttribute<LengthAttribute>();
            if (LengthAttr != null)
            {
                if (HasValue)
                {
                    if (StrValue.Length != LengthAttr.Length)
                    {
                        _AddError(ref Errors, Prop.Name, LengthAttr.ErrorMessage);
                    }
                }
            }

            var MaxLengthAttr = Prop.GetCustomAttribute<MaxLengthAttribute>();
            if (MaxLengthAttr != null)
            {
                if (HasValue)
                {
                    if (StrValue.Length > MaxLengthAttr.Length)
                    {
                        _AddError(ref Errors, Prop.Name, MaxLengthAttr.ErrorMessage);
                    }
                }
            }

            var MinLengthAttr = Prop.GetCustomAttribute<MinLengthAttribute>();
            if (MinLengthAttr != null)
            {
                if (HasValue)
                {
                    if (StrValue.Length < MinLengthAttr.Length)
                    {
                        _AddError(ref Errors, Prop.Name, MinLengthAttr.ErrorMessage);
                    }
                }
            }

            PhoneNoAttribute PhoneNoAttr = Prop.GetCustomAttribute<PhoneNoAttribute>();
            if (PhoneNoAttr != null)
            {
                if (HasValue)
                {
                    if (!Guard.MatchesPattern(StrValue, PhoneNoAttr.Pattern))
                    {
                        _AddError(ref Errors, Prop.Name, PhoneNoAttr.ErrorMessage);
                    }
                }
            }

            var NationalNoAttr = Prop.GetCustomAttribute<NationalNoAttribute>();
            if (NationalNoAttr != null)
            {
                if (HasValue)
                {
                    if (!Guard.MatchesPattern(StrValue, NationalNoAttr.Pattern))
                    {
                        _AddError(ref Errors, Prop.Name, NationalNoAttr.ErrorMessage);
                    }
                }
            }

            var EmailAttr = Prop.GetCustomAttribute<EmailAddrAttribute>();
            if (EmailAttr != null)
            {
                if (HasValue)
                {
                    if (!Guard.MatchesPattern(StrValue, EmailAttr.Pattern))
                    {
                        _AddError(ref Errors, Prop.Name, EmailAttr.ErrorMessage);
                    }
                }
            }

            return Errors;
        }

        private static void _AddError(ref List<ValidationError> Errors, 
            string PropertyName, string errorMessage)
        {
            Errors.Add(new ValidationError
            {
                PropertyName = PropertyName,
                ErrorMessage = errorMessage
            });
        }
    }
}
