using MVC_221.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_221.Controllers
{
    public class CustomerController : Controller
    {
        CustomerBLL customerBLL = new CustomerBLL();
        public ActionResult Index()
        {
            var customerList = customerBLL.GetCustomers();

            return View(customerList);
        }
    }
}