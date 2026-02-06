using System.Collections.Generic;
using System.Web.Mvc;
using EcommerceApp.Models;

namespace EcommerceApp.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name="Mobile",Price=12000},
                new Product{Id=2,Name="Laptop",Price=50000}
            };

            return View(products);
        }
    }
}
