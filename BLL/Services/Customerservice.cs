using BLL.BEnt;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class Customerservice
    {
        public static customerModel myprofile(int id)
        {
            var data = DataAccessFactory.CustomerProfileDataAccess().Get(id);

            var user = new customerModel();
            user.username = data.username;
            user.email = data.email;
            user.dob = data.dob;
            user.gender = data.gender;
            return user;
        }

        public static List<OrderModel> myorder(int id)
        {
            var data = DataAccessFactory.CustomerOrderDataAccess().findOrder(id);

            var order = new List<OrderModel>();
            foreach (var item in data)
            {
                order.Add(new OrderModel()
                {
                    id = item.id,
                    address = item.address,
                    amount = item.amount,
                    product = item.product
                });
            }
            return order;
        }

        public static bool orderdelete(int id,int id1)
        {
            return DataAccessFactory.CustomerOrderDataAccess().Delete(id,id1);
        }

        public static bool AddtoOrder(int id, int id1)
        {
            return DataAccessFactory.CustomerOrderDataAccess().Add(id, id1);
        }
    }
}
