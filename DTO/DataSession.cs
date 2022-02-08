using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DataSession
    {
        public static string UserName = "";
        public static string HoTen = "";
        public static string ChucDanh = "";
        public static bool isLoginSuccessfull = false;
        public static BindingList<DTO_UserRights> g_list_phanquyen = null;
        //public static Dictionary<string,DTO_UserRights> g_list_phanquyen = null;
        public DataSession()
        {
            UserName = HoTen = ChucDanh = "";
            isLoginSuccessfull = false;
            g_list_phanquyen = null;
        }
        
    }
}
