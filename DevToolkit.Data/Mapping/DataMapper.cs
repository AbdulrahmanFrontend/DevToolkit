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
                    var PropType = Nullable.GetUnderlyingType(prop.PropertyType) ?? 
                        prop.PropertyType;
                    if (Value == DBNull.Value)
                    {
                        if (Nullable.GetUnderlyingType(prop.PropertyType) != null
                            || !prop.PropertyType.IsValueType)
                        {
                            prop.SetValue(obj, null);
                        }

                        continue;
                    }
                    var SafeValue = Convert.ChangeType(Value, PropType);
                    prop.SetValue(obj, SafeValue);
                }
            }
            return obj;
        }
    }
}
