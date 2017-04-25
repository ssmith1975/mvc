using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Northwind;
using Northwind.Custom;
using System.ComponentModel.DataAnnotations;

namespace Northwind.ViewModel
{

    public partial class NorthwindCategoryViewModel
    {
        public NorthwindCategoryViewModel()
        {
            this.Products = new HashSet<Product>();
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }


}