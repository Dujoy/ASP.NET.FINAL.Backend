using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class OrderRepo : IOrder<Order, int, bool>, IOrder<Product, int, bool>
    {
        private MIDEntities db;

        public OrderRepo(MIDEntities db)
        {
            this.db = db;
        }

        public bool Add(int id, int id1)
        {
            var cus = db.customers.Find(id);

            var product = db.Products.Find(id1);
            var order = new Order();
            order.customer_name = cus.username;
            order.address = "Dhaka";
            order.amount = product.price;
            order.product = product.name;
            db.Orders.Add(order);
            var x = db.SaveChanges();
            return x > 0;
        }

        public bool Delete(int id, int id1)
        {
            var cus = db.customers.Find(id);
            var order = (from e in db.Orders
                         where e.customer_name.Equals(cus.username) && e.id==id1
                         select e).SingleOrDefault();
            db.Orders.Remove(order);
            var x= db.SaveChanges();
            return x>0;
        }

        public List<Order> findOrder(int id)
        {
            var cus = db.customers.Find(id);
            var order = (from e in db.Orders
                            where e.customer_name.Equals(cus.username)
                            select e).ToList();

            return order;
        }

        List<Product> IOrder<Product, int, bool>.findOrder(int id)
        {
            throw new NotImplementedException();
        }
    }
}
