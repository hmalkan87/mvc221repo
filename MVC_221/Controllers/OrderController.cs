using MVC_221.BLL;
using MVC_221.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_221.Controllers
{
    public class OrderController : Controller
    {
        OrderBLL orderBLL = new OrderBLL();
        public ActionResult Index()
        {
            List<Orders> orderList = orderBLL.GetOrders();

            return View(orderList);
        }
    }
}