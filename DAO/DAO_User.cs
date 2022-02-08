using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_User
    {
        public DataTable GetAll()
        {
            string proc = "mp_Account_GetAll";
            return Util.GetStoredData(proc);
        }
        public DataTable getByID(string Acc)
        {
            string proc = "mp_Account_GetById";
            return Util.GetStoredData(proc,new SqlParameter("@acc", Acc));
        }
        public DataTable f_Login(string userName, string pass)
        {
            string sql = "mp_Login";
            return Util.GetStoredData(sql
                    , new SqlParameter("@username", userName)
                    , new SqlParameter("@pass", pass)
                    );
        }    
    }
}
