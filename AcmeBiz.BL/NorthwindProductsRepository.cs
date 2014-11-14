using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind;
using Northwind.Custom;

namespace AcmeBiz.BL
{
    public partial class NorthwindProductsRepository
    {

        static public List<Product> GetProducts()
        {
            List<Product> products;

            using (var ctx = new NorthwindEntities())
            {
               
                //var q = from product in ctx.Products
                //        orderby product.ProductName
                //        select product;

                products = ctx.Products.Include("Category").ToList<Product>();
                    
                    //q.Include(b => b.Category).ToList<Product>();
               
            }

            return products;
        } // end GetProducts


        static public Product GetProductByID(int productID)
        {
            Product product;
            using (var ctx = new NorthwindEntities())
            {
                var q = from p in ctx.Products
                        where p.ProductID == productID
                        select p;
                product = q.SingleOrDefault<Product>();
            }
            return product;
            
        } // GetProductByID
        static public List<Product> GetFeaturedProducts()
        {
            List<Product> products = new  List<Product>() ;

            using (var ctx = new NorthwindEntities())
            {

                var q =  ctx.Products.Include("Category");
                int skip = (DateTime.Now.Month - 1) * 5;

                
                products = q.OrderBy(p => p.ProductID).Skip(skip).Take(5).ToList<Product>();
                //q.Include(b => b.Category).ToList<Product>();
            }

            return products;

        } // end GetFeaturedProducts


        static public List<Product> GetNewProducts()
        {
            List<Product> products;

            using (var ctx = new NorthwindEntities())
            {

                //var q = from product in ctx.Products
                //        orderby product.ProductName
                //        select product;

                products = ctx.Products.Include("Category").OrderByDescending(p => p.ProductID).Take(5).ToList<Product>();

                //q.Include(b => b.Category).ToList<Product>();
            }
            return products;
        } // end GetNewProducts

        static public List<Product> GetTopSellerProducts()
        {
            List<Product> products;

            using (var ctx = new NorthwindEntities())
            {

                //var q = from product in ctx.Products
                //        orderby product.ProductName
                //        select product;

                products = ctx.GetTopSellerProducts().ToList <Product>();
                  

                //q.Include(b => b.Category).ToList<Product>();
            }
            return products;
        } // end GetNewProducts


        static public byte[] GetCategoryPictureByID(int categoryID)
        {
            byte[] byteArray;
            
            using (var ctx = new NorthwindEntities())
            {
                var q = from c in ctx.Categories
                        where c.CategoryID == categoryID
                        select c.Picture;
                byteArray = q.SingleOrDefault<byte[]>();
            }
            return byteArray;

        } // end GetCategoryPictureByID

    }
}
