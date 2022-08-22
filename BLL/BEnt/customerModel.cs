using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
   public  class customerModel
    {
        public int id { get; set; }
        public string password { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> dob { get; set; }
        public string gender { get; set; }
    }
}
