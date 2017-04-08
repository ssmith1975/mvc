using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Northwind;
using Northwind.Custom;
using System.ComponentModel.DataAnnotations;
using Northwind.ViewModel;
using AcmeBiz.BL;

namespace AcmeBiz.ViewModel
{
    public class CategoryViewModelFactory
    {
        public static List<Category> GetCategories()
        {

            //var categories = NorthwindProductsRepository.GetProducts();

            List<Category> viewmodel = NorthwindCategoriesRepository.GetCategories();
            return viewmodel;

        }
    }
}