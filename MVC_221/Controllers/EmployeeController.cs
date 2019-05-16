using MVC_221.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_221.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeBLL employeeBLL = new EmployeeBLL();
        public ActionResult Index()
        {
            var employeeList = employeeBLL.GetEmployees();

            return View(employeeList);
        }
    }
}