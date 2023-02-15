using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryManagementSystem.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            string pageTitle = "Product Details";

            ViewBag.Title = pageTitle;

            List<string> productNames = new List<string>() { "Light", "Switch", "Nails", "Screws" };

            ViewBag.Products = productNames;

            return View();
        }
    }
}