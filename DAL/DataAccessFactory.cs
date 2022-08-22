using DAL.EF;
using DAL.Interface;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static MIDEntities db = new MIDEntities();
        public static ICustomer<customer, int, bool> CustomerProfileDataAccess()
        {
            return new CustomerRepo(db);
        }

        public static IOrder<Order, int, bool> CustomerOrderDataAccess()
        {
            return new OrderRepo(db);
        }
    }
}
