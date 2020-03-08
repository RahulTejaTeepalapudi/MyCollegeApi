using College.CL.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.CL.Mappers
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SourceNameAttribute : Attribute
    {
        protected List<string> _columnNames {get; set;}

        public List<string> ColumnNames
        {
            get
            {
                return _columnNames;
            }
            set
            {
                _columnNames = value;
            }
        }

        public SourceNameAttribute()
        {
            _columnNames = new List<string>();
        }

        public SourceNameAttribute(params string[] columnNames)
        {
            if (!columnNames.IsNullOrEmpty())
                _columnNames = columnNames.ToList();
        }
    }
}
