using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using Northwind;
using Northwind.ViewModel;
namespace AcmeBiz.ViewModel
{
    public partial class HomeViewModel
    {
        public List<NorthwindProductViewModel> FeaturedProductsList { get; set; }
        public List<NorthwindProductViewModel> NewProductsList { get; set; }
        public List<NorthwindProductViewModel> TopSellerProductsList { get; set; }

    }
}