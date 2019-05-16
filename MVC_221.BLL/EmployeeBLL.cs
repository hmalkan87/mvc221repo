using MVC_221.DAL;
using MVC_221.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_221.BLL
{
    public class EmployeeBLL
    {
        DataContext db = new DataContext();
        public List<Employees> GetEmployees()
        {
            return db.Employees.ToList();
        }
    }
}
