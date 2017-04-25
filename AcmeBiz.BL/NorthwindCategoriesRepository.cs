using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind;

namespace AcmeBiz.BL
{
    public partial class NorthwindCategoriesRepository
    {
        static public List<Category> GetCategories()
        {
            List<Category> categories;
            
            using (var ctx = new NorthwindEntities())
            {

                categories = ctx.Categories.Include("Products").ToList<Category>();
            }

            return categories;

        } // end GetCategories

        static public Category GetCategoryByName(string categoryName)
        {
            Category category = null;

            using (var ctx = new NorthwindEntities())
            {
                //var q = from cat in ctx.Categories
                //        where cat.CategoryName == categoryName
                //        select cat;

                category = ctx.Categories
                    .Where(c => c.CategoryName == categoryName)                   
                    .FirstOrDefault<Category>();
                
            }

            return category;
        }
        static public Category GetCategoryById(int id)
        {
            Category category = null;

            using (var ctx = new NorthwindEntities())
            {
                //var q = from cat in ctx.Categories
                //        where cat.CategoryName == categoryName
                //        select cat;

                category = ctx.Categories
                    .Where(c => c.CategoryID == id)
                    .FirstOrDefault<Category>();

            }

            return category;
        }



    }
}
