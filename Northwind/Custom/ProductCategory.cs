using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Custom
{
    public partial class ProductCategory
    {
        Product Product { get; set; }
        Category Category { get; set; }
    }
}
