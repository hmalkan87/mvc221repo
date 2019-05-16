using MVC_221.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_221.Controllers
{
    public class SupplierController : Controller
    {
        SupplierBLL sb = new SupplierBLL();
        public ActionResult Index()
        {
            var supplierList = sb.GetSuppliers();

            return View(supplierList);
        }
    }
}