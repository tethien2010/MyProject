using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_UserFunction
    {
        public string UserName { get; set; }
        public string Menu { get; set; }
        public bool AllowAddNew { get; set; }
        public bool AllowEdit { get; set; }
        public bool AllowDelete { get; set; }
        public bool Disable { get; set; }
    }
}
