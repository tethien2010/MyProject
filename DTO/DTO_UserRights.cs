using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_UserRights
    {
        public string Menu { get; set; }
        public string Account { get; set; }
        public string Description { get; set; }
        public bool AllowAdd { get; set; }
        public bool AllowEdit { get; set; }
        public bool AllowDel { get; set; }
        public bool Disable { get; set; }
        public string  ParentMenu { get; set; }
        public string U_Type { get; set; }
        public string FormName { get; set; }
        public DTO_UserRights()
        {
            Menu = ParentMenu = Account = FormName = U_Type = "";
            AllowAdd = AllowEdit = AllowDel = Disable = false;
            Description = "Không có gì";
        }
        public DTO_UserRights(string menu, string account, string description, bool allowadd, bool allowedit, bool allowdel, bool disbale
            , string parentMenu, string uType, string formName )
        {
            Menu = menu;
            Account = account;
            Description = description;
            AllowAdd = allowadd;
            AllowEdit = allowedit;
            AllowDel = allowdel;
            Disable = disbale;
            ParentMenu = parentMenu;
            U_Type = uType;
            FormName = formName;
        }
    }
}
