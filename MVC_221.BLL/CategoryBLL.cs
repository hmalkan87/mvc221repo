using MVC_221.DAL;
using MVC_221.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_221.BLL
{
    public static class CategoryBLL
    {
        public static List<Categories> GetCategories()
        {
            DataContext dataContext = new DataContext();

            return dataContext.Categories.ToList();
        }



    }
}
