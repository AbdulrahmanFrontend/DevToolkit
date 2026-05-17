using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DevToolkit.Core.Validation.Attributes;
using DevToolkit.Core.Validation.Patterns;

namespace DevToolkit.Core.Validation
{
    public class ObjectValidator
    {
        public static List<ValidationError> ValidateProperty<T>(PropertyInfo Prop, T obj)
        {
            List<ValidationError> Errors = new List<ValidationError>();

            var Value = Prop.GetValue(obj);
            RequiredAttribute RequiredAttr = Prop.GetCustomAttribute<RequiredAttribute>();
            if (RequiredAttr != null)
            {
                if(Value == null ||
                    (Value is string Str && string.IsNullOrEmpty(Str)))
                {
                    _AddError(ref Errors, Prop.Name, RequiredAttr.ErrorMessage);
                }
            }

            RangeAttribute RangeAttr = Prop.GetCustomAttribute<RangeAttribute>();
            if (RangeAttr != null)
            {
                if (Value != null)
                {
                    if (Value is int IntValue && (IntValue < RangeAttr.Min
                        || IntValue > RangeAttr.Max))
                    {
                        _AddError(ref Errors, Prop.Name, RangeAttr.ErrorMessage);
                    }
                }
            }

            var StrValue = Value as string;

            LengthAttribute LengthAttr = Prop.GetCustomAttribute<LengthAttribute>();
            if (LengthAttr != null)
            {
                if (StrValue != null)
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
                if(StrValue != null)
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
                if (StrValue != null)
                {
                    if (StrValue.Length < MinLengthAttr.Length)
                    {
                        _AddError(ref Errors, Prop.Name, MinLengthAttr.ErrorMessage);
                    }
                }
            }

            var NationalNoAttr = Prop.GetCustomAttribute<NationalNoAttribute>();
            if (NationalNoAttr != null)
            {
                if (StrValue != null)
                {
                    if (!Regex.IsMatch(StrValue, ValidationPatterns.NationalNoPattern))
                    {
                        _AddError(ref Errors, Prop.Name, NationalNoAttr.ErrorMessage);
                    }
                }
            }

            var EmailAttr = Prop.GetCustomAttribute<EmailAttribute>();
            if (EmailAttr != null)
            {
                if (StrValue != null)
                {
                    if (!Regex.IsMatch(StrValue, ValidationPatterns.EmailPattern))
                    {
                        _AddError(ref Errors, Prop.Name, EmailAttr.ErrorMessage);
                    }
                }
            }

            var PhoneAttr = Prop.GetCustomAttribute<PhoneAttribute>();
            if (PhoneAttr != null)
            {
                if (StrValue != null)
                {
                    if (!Regex.IsMatch(StrValue, ValidationPatterns.PhonePattern))
                    {
                        _AddError(ref Errors, Prop.Name, PhoneAttr.ErrorMessage);
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

        public static ValidationResult ValidateObject<T>(T obj)
        {
            var Type = typeof(T);
            var Result = new ValidationResult();
            var PropErrors = new List<ValidationError>();
            foreach (var prop in Type.GetProperties())
            {
                PropErrors = ValidateProperty<T>(prop, obj);
                if (PropErrors.Count > 0)
                {
                    Result.Errors.AddRange(PropErrors);
                }
            }
            return Result;
        }
    }
}
