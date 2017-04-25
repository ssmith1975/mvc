using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using Northwind;
using Northwind.ViewModel;
using AcmeBiz.BL;

namespace AcmeBiz.ViewModel
{
    public partial class ViewModelFactory
    {
        public NorthwindProductListViewModel GetNorthwindProductsViewModel()
        {
            NorthwindProductListViewModel viewmodel = new NorthwindProductListViewModel();

            var products = NorthwindProductsRepository.GetProducts();
            var categories = NorthwindCategoriesRepository.GetCategories();

            List<NorthwindProductViewModel> productList = new List<NorthwindProductViewModel>();
            List<NorthwindCategoryViewModel> categoryList = new List<NorthwindCategoryViewModel>();
            productList = (from product in products
                         select new NorthwindProductViewModel()
                         {
                             ProductID = product.ProductID,
                             ProductName = product.ProductName,
                             UnitPrice = (decimal)product.UnitPrice,
                             QuantityPerUnit = product.QuantityPerUnit,

                             Category = product.Category,
                             CategoryID = (int)product.CategoryID
                         }).ToList<NorthwindProductViewModel>();

            categoryList = (from category in categories
                          select new NorthwindCategoryViewModel()
                          {
                              CategoryID = category.CategoryID,
                              CategoryName = category.CategoryName
                          }).ToList<NorthwindCategoryViewModel>();

            viewmodel.NorthwindProductList = productList;
            viewmodel.NorthwindCategoryList = categoryList;

            return viewmodel;
        } // end GetNorthwindProductsViewModel


        public List<NorthwindProductViewModel> GetNorthwindFeaturedProductsViewModel()
        {

            var products = NorthwindProductsRepository.GetFeaturedProducts();

            List<NorthwindProductViewModel> viewModel = new List<NorthwindProductViewModel>();

            viewModel = (from product in products
                         select new NorthwindProductViewModel()
                         {
                             ProductID = product.ProductID,
                             ProductName = product.ProductName,
                             UnitPrice = (decimal)product.UnitPrice,
                             Category = product.Category,
                             CategoryID = (int)product.CategoryID
                         }).ToList<NorthwindProductViewModel>();

            return viewModel;
        } // end GetNorthwindFeaturedProductsViewModel

        public List<NorthwindProductViewModel> GetNorthwindNewProductsViewModel()
        {

            var products = NorthwindProductsRepository.GetNewProducts();

            List<NorthwindProductViewModel> viewModel = new List<NorthwindProductViewModel>();

            viewModel = (from product in products
                         select new NorthwindProductViewModel()
                         {
                             ProductID = product.ProductID,
                             ProductName = product.ProductName,
                             UnitPrice = (decimal)product.UnitPrice,
                             Category = product.Category,                           
                             CategoryID = (int)product.CategoryID
                         }).ToList<NorthwindProductViewModel>();

            return viewModel;
        } // end GetNorthwindNewProductsViewModel


        public List<NorthwindProductViewModel> GetNorthwindTopSellerProductsViewModel()
        {

            var products = NorthwindProductsRepository.GetTopSellerProducts();

            List<NorthwindProductViewModel> viewModel = new List<NorthwindProductViewModel>();

            viewModel = (from product in products
                         select new NorthwindProductViewModel()
                         {
                             ProductID = product.ProductID,
                             ProductName = product.ProductName,
                             UnitPrice = (decimal)product.UnitPrice,

                             Category = product.Category,
                             CategoryID = (int)product.CategoryID
                         }).ToList<NorthwindProductViewModel>();

            return viewModel;
        } // GetNorthwindTopSellerProductsViewModel 


    } // end class
}