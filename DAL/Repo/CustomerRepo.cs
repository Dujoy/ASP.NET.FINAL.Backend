using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class CustomerRepo : ICustomer<customer, int, bool>
    {
        private MIDEntities db;

        public CustomerRepo(MIDEntities db)
        {
            this.db = db;
        }

        public bool Create(customer obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<customer> Get()
        {
            throw new NotImplementedException();
        }

        public customer Get(int id)
        {
            return db.customers.Find(id);
        }

        public bool Update(customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
