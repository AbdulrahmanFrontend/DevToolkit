using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.Core.Validation.Attributes;
using DevToolkit.Logging.Managers;

namespace DevToolkit.Data.Mapping
{
    public static class DataMapper
    {
        public static T Map<T>(DataRow row) where T : new()
        {
            T obj = new T();
            foreach (var prop in typeof(T).GetProperties())
            {
                var Attr = prop.GetCustomAttribute<ColumnAttribute>();
                string ColumnName = Attr != null ? Attr.ColumnName : prop.Name;

                if (row.Table.Columns.Contains(ColumnName))
                {
                    var Value = row[ColumnName];
                    Type PropertyType = prop.PropertyType;

                    Type TargetType =
                        Nullable.GetUnderlyingType(PropertyType) ?? PropertyType;

                    if (Value == DBNull.Value)
                    {
                        if (!PropertyType.IsValueType ||
                            Nullable.GetUnderlyingType(PropertyType) != null)
                            prop.SetValue(obj, null);
                        else
                            prop.SetValue(obj, Activator.CreateInstance(PropertyType));

                        continue;
                    }

                    if (TargetType.IsEnum)
                    {
                        var SafeValue = Enum.ToObject(TargetType, Value);
                        prop.SetValue(obj, SafeValue);
                    }
                    else if (TargetType == typeof(Guid))
                    {
                        var SafeValue = Guid.Parse(Value.ToString());
                        prop.SetValue(obj, SafeValue);
                    }
                    else
                    {
                        try
                        {
                            var SafeValue = Convert.ChangeType(Value, TargetType);
                            prop.SetValue(obj, SafeValue);
                        }
                        catch(Exception ex)
                        {
                            LogManager.LogError($"Error converting value '{Value}' to type " +
                                $"'{TargetType.Name}' for property '{prop.Name}': {ex.Message}", ex);

                            continue;
                        }
                    }
                }
            }
            return obj;
        }
    }
}
