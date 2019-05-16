using MVC_221.BLL;
using MVC_221.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_221.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            List<Categories> categoryList = CategoryBLL.GetCategories();

            return View(categoryList);
        }
    }
}