using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asg1.DAL;

namespace Asg1.Controllers
{
    public class HomeController : Controller
    {
        private ProductContext db = new ProductContext();

        public ActionResult Index(string searchString)
        {
            var products = db.Products.ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString)).ToList();
            }

            return View(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}