using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Asg1.DAL;
using Asg1.Models;

namespace Asg1.Controllers
{
    public class SearchController : Controller
    {
        private ProductContext db = new ProductContext();
        // GET: Search
        public ActionResult Index(string searchString)
        {
            var products = db.Products.ToList();

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString)).ToList();
            }

            return View(products);
        }

    }
}