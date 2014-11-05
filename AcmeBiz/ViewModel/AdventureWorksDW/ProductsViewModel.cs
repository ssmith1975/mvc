using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AcmeBiz.DAL;

namespace AcmeBiz.ViewModel
{
    public partial class ProductsViewModel
    {
        public int ProductKey { get; set; }        
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal ListPrice { get; set; }
        public byte[] Photo { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }


        public List<ProductsViewModel> Products { get; set; }
    }
}