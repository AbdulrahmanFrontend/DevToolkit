using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DevToolkit.Core.Validation.Attributes;

namespace DevToolkit.Data.Mapping
{
    public class DataMapper
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
                        {
                            prop.SetValue(obj, null);
                        }
                        else
                        {
                            prop.SetValue(obj, Activator.CreateInstance(PropertyType));
                        }

                        continue;
                    }

                    var SafeValue = Convert.ChangeType(Value, TargetType);
                    prop.SetValue(obj, SafeValue);
                }
            }
            return obj;
        }
    }
}
