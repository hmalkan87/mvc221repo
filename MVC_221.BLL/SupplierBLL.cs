using MVC_221.DAL;
using MVC_221.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_221.BLL
{
    public class SupplierBLL
    {
        DataContext dataContext = new DataContext();

        public List<Suppliers> GetSuppliers()
        {
            return dataContext.Suppliers.ToList();
        }

    }
}
