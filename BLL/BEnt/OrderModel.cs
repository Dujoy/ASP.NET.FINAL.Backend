using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL.BEnt
{
    public class OrderModel
    {
        public int id { get; set; }
        public string customer_name { get; set; }
        public string address { get; set; }
        public Nullable<double> amount { get; set; }
        public string product { get; set; }
    }
}
