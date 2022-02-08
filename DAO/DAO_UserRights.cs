using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DAO_UserRights
    {
        public BindingList<DTO_UserRights> listUserRights(string username)
        {
            BindingList<DTO_UserRights> list = new BindingList<DTO_UserRights>();
            string proc = "myproject_LoadUserRight";
            try
            {
                DataTable dt = Util.GetStoredData(proc, new SqlParameter("@username", username));
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        list.Add(new DTO_UserRights(
                            Convert.ToString(item["Menu"])
                            , Convert.ToString(item["Account"])
                            , Convert.ToString(item["U_Description"])
                            , Convert.ToBoolean(item["AllowAddNew"])
                            , Convert.ToBoolean(item["AllowEdit"])
                            , Convert.ToBoolean(item["AllowDelete"])
                            , Convert.ToBoolean(item["U_Disable"])
                            , Convert.ToString(item["ParentMenu"])
                            , Convert.ToString(item["U_Type"])
                            , Convert.ToString(item["FormName"])
                            ));
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return list;
        }
        public Tuple<bool, string> f_SaveFuncUser(string jsData)
        {
            string proc = "mp_SaveUserRight";
            DataTable dt = new DataTable();
            bool result = false;
            string msg = "Lưu thông tin không thành công";
            try
            {
                dt = Util.GetStoredData(proc, new SqlParameter("@funcuser", jsData));
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        result = Convert.ToString(dt.Rows[0]["Result"]).Equals(Commond.Success);
                        msg = Convert.ToString(dt.Rows[0]["Msg"]);
                    }
                }
            }
            catch (Exception)
            {

            }
            return new Tuple<bool, string>(result, msg);
        }    
        
    }
}
