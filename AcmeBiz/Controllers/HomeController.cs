using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcmeBiz.BL;
using AcmeBiz.ViewModel;

namespace AcmeBiz.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ProductNamesViewModel viewModel = new ProductNamesViewModel()
            {
                ProductNameList = ProductsRepository.GetProductNames()
            };
            
            return View(viewModel);
        }

    }
}
