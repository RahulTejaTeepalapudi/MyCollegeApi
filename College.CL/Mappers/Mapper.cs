using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace College.CL.Mappers
{
    public class Mapper<TEntity> where TEntity : class, new() 
    {
        public List<TEntity> Map(DataTable table)
        {
            List<TEntity> entities = new List<TEntity>();
            var columns = table.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToList();
            var PropertyInfo = (typeof(TEntity)).GetProperties();
            var properties = PropertyInfo.Where(x => x.GetCustomAttributes(typeof(SourceNameAttribute), true).Any()).ToList();

            foreach (DataRow row in table.Rows)
            {
                TEntity entity = new TEntity();
                foreach (var prop in properties)
                {
                    Map(typeof(TEntity),row, prop, entity);
                }
                entities.Add(entity);
            }
            return entities;
        }

        public void Map(Type type, DataRow dataRow, PropertyInfo property, object entity)
        {
            List<string> columnNames = MappingHelper.GetSourceNames(type, property.Name);
            foreach (var columnName in columnNames)
            {
                if (!string.IsNullOrWhiteSpace(columnName) && dataRow.Table.Columns.Contains(columnName))
                {
                    var propertyValue = dataRow[columnName];
                    if (propertyValue != DBNull.Value)
                    {
                        MappingHelper.ParsePrimitive(property, entity, dataRow[columnName]);
                        break;
                    }
                }
            }
        }
    }
}
