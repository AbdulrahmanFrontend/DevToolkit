using DevToolkit.Core.Validation.Attributes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevToolkit.Data.Utilities
{
    public static class DataTableConverter
    {
        public static DataTable ToDataTable<T>(IEnumerable<T> items)
        {
            DataTable dt = new DataTable();

            var properties = typeof(T).GetProperties();

            foreach (var prop in properties)
            {
                string columnName =
                    prop.GetCustomAttributes(false)
                    .OfType<ColumnAttribute>()
                    .FirstOrDefault()?.ColumnName
                    ?? prop.Name;

                Type columnType =
                    Nullable.GetUnderlyingType(prop.PropertyType)
                    ?? prop.PropertyType;

                dt.Columns.Add(columnName, columnType);
            }

            foreach (var item in items)
            {
                DataRow row = dt.NewRow();

                foreach (var prop in properties)
                {
                    string columnName =
                        prop.GetCustomAttributes(false)
                        .OfType<ColumnAttribute>()
                        .FirstOrDefault()?.ColumnName
                        ?? prop.Name;

                    row[columnName] =
                        prop.GetValue(item) ?? DBNull.Value;
                }

                dt.Rows.Add(row);
            }

            return dt;
        }
    }
}
