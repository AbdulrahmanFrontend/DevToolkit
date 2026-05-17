using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.Core.Validation.Attributes;

namespace DevToolkit.Core.Validation
{
    public class ObjectValidator
    {
        public static List<ValidationError> ValidateProperty<T>(PropertyInfo Prop, T obj)
        {
            var Errors = new List<ValidationError>();

            var Value = Prop.GetValue(obj);
            var RequiredAttr = Prop.GetCustomAttribute<RequiredAttribute>();
            if (RequiredAttr != null)
            {
                if(Value == null ||
                    (Value is string Str && string.IsNullOrWhiteSpace(Str)))
                {
                    Errors.Add(new ValidationError 
                        { 
                            PropertyName = Prop.Name,
                            ErrorMessage = RequiredAttr.ErrorMessage
                        });
                }
            }

            var RangeAttr = Prop.GetCustomAttribute<RangeAttribute>();
            if (RangeAttr != null)
            {
                if (Value != null)
                {
                    if (Value is int IntValue && (IntValue < RangeAttr.Min
                        || IntValue > RangeAttr.Max))
                    {
                        Errors.Add(new ValidationError 
                            { 
                                PropertyName = Prop.Name,
                                ErrorMessage = RangeAttr.ErrorMessage
                            });
                    }
                }
            }

            var StrValue = Value as string;
            var MaxLengthAttr = Prop.GetCustomAttribute<MaxLengthAttribute>();
            if (MaxLengthAttr != null)
            {
                if(StrValue != null)
                {
                    if (StrValue.Length > MaxLengthAttr.Length)
                    {
                        Errors.Add(new ValidationError 
                            { 
                                PropertyName = Prop.Name,
                                ErrorMessage = MaxLengthAttr.ErrorMessage
                            });
                    }
                }
            }

            return Errors;
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
