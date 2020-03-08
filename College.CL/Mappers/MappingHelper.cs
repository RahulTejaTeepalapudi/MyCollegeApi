using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace College.CL.Mappers
{
    public static class MappingHelper
    {
        public static List<string> GetSourceNames(Type type, string propertyName)
        {
            var property = type.GetProperty(propertyName)
                .GetCustomAttributes(false)
                .Where(x => x.GetType() == typeof(SourceNameAttribute)).FirstOrDefault();
            if (property != null)
                return ((SourceNameAttribute)property).ColumnNames;
            return new List<string>();
        }

        public static void ParsePrimitive(PropertyInfo property, object entity, object value)
        {
            if (property.PropertyType == typeof(string))
            {
                property.SetValue(entity, value.ToString().Trim(), null);
            }
        }

        public static List<TEntity> MapToEntity<TEntity>(DataTable dt) where TEntity : class, new()
        {
            Mapper<TEntity> m = new Mapper<TEntity>();
            return m.Map(dt);
        }
    }
}
