using MVC_221.DAL;
using MVC_221.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_221.BLL
{
    public class CustomerBLL
    {
        DataContext dataContext = new DataContext();
        public List<Customers> GetCustomers()
        {
            return dataContext.Customers.ToList();
        }
    }
}
