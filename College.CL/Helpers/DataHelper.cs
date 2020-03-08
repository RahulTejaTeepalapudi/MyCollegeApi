using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College.CL.Helpers
{
    public class DataHelper
    {
        public static bool TryValidateDataSource(DataSet ds, int index, out DataTable dt)
        {
            dt = null;
            if (ds == null || (ds != null && ds.Tables.Count == 0))
                return false;
            if (index >= ds.Tables.Count)
                return false;
            dt = ds.Tables[index];
            return true;
        }
    }
}
