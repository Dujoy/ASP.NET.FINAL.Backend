using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
   public  interface IOrder<CLASS,ID,RT>
    {
        List<CLASS> findOrder(ID id);
        RT Delete(ID id, ID id1);
        RT Add(ID id, ID id1);

    }
}
