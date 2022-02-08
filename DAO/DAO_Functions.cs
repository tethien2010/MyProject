using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_Functions
    {
        public bool f_SaveFunc(string jsFunc)
        {
            string proc = "mp_SaveFunc";
            bool _result = false;
            try
            {

                DataTable dt = Util.GetStoredData(proc, new SqlParameter("@func", jsFunc));
                if (dt != null && dt.Rows.Count > 0)
                {
                    _result = Convert.ToString(dt.Rows[0]["Result"]).Equals(Commond.Success);
                }
            }
            catch (Exception ex)
            {

            }
            return _result;
        }
    }
}
