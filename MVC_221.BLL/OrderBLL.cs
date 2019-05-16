using MVC_221.DAL;
using MVC_221.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_221.BLL
{
    public class OrderBLL
    {
        DataContext db = new DataContext();

        public List<Orders> GetOrders()
        {
            return db.Orders.ToList();
        }

    }
}
