using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Northwind;
using Northwind.Custom;
using System.ComponentModel.DataAnnotations;
using Northwind.ViewModel;

namespace AcmeBiz.ViewModel
{
    public class NorthwindProductListViewModel
    {
        public List<NorthwindProductViewModel> NorthwindProductList { get; set; }
        public List<NorthwindCategoryViewModel> NorthwindCategoryList { get; set; }
    }
}