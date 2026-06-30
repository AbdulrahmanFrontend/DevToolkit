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

namespace DevToolkit.Core.Validation
{
    public static class ObjectValidator
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
                    Result.Errors.AddRange(PropErrors);
            }

            return Result;
        }

        public static List<ValidationError> ValidateProperty<T>(PropertyInfo Prop,
            T obj)
        {
            List<ValidationError> Errors = new List<ValidationError>();

            var Value = Prop.GetValue(obj);
            var RequiredAttr = Prop.GetCustomAttribute<RequiredAttribute>();
            if (RequiredAttr != null)
            {
                if(Value == null || 
                    (Value is string Str && !Guard.HasValue(Str)))
                {
                    _AddError(ref Errors, Prop.Name, RequiredAttr.ErrorMessage);
                    return Errors; // No need to check other attributes if required validation fails
                }
            }

            RangeAttribute RangeAttr = Prop.GetCustomAttribute<RangeAttribute>();
            if (RangeAttr != null && Value != null)
                try
                {
                    IComparable valueComparable = (IComparable)Value;

                    IComparable minComparable = (IComparable)RangeAttr.Min;

                    IComparable maxComparable = (IComparable)RangeAttr.Max;

                    if (valueComparable.CompareTo(minComparable) < 0 ||
                        valueComparable.CompareTo(maxComparable) > 0)
                        _AddError(ref Errors, Prop.Name, RangeAttr.ErrorMessage);
                }
                catch
                {
                    _AddError(ref Errors, Prop.Name,
                        "Invalid RangeAttribute configuration.");
                }

            var StrValue = Value as string;
            bool HasValue = Guard.HasValue(StrValue);

            var LengthAttr = Prop.GetCustomAttribute<LengthAttribute>();
            if (LengthAttr != null)
            {
                if (HasValue)
                {
                    if (LengthAttr is MaxLengthAttribute)
                    {
                        if (StrValue.Length > LengthAttr.Length)
                            _AddError(
                                ref Errors,
                                Prop.Name,
                                LengthAttr.ErrorMessage);
                    }
                    else if (LengthAttr is MinLengthAttribute)
                    {
                        if (StrValue.Length > LengthAttr.Length)
                            _AddError(
                                ref Errors,
                                Prop.Name,
                                LengthAttr.ErrorMessage);
                    }
                    else
                    {
                        if (StrValue.Length != LengthAttr.Length)
                            _AddError(
                                ref Errors,
                                Prop.Name,
                                LengthAttr.ErrorMessage);
                    }
                }
            }

            RegexAttribute RegexAttr = Prop.GetCustomAttribute<RegexAttribute>();
            if (RegexAttr != null)
            {
                if (!RegexAttr.IsValid(StrValue))
                    _AddError(ref Errors, Prop.Name, RegexAttr.ErrorMessage);
            }

            return Errors;
        }

        private static void _AddError(
            ref List<ValidationError> Errors,
            string PropertyName,
            string errorMessage)
        {
            Errors.Add(new ValidationError
            {
                PropertyName = PropertyName,
                ErrorMessage = errorMessage
            });
        }
    }
}
