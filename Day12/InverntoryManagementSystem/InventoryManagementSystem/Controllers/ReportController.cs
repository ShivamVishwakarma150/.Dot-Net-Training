using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryManagementSystem.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        //Action Method
        //Defualt action method
        public ActionResult Index()
        {
            string pageTitle = "Report Details";

            ViewBag.Title = pageTitle;

            Dictionary<string,string> result = new Dictionary<string,string>();
            result.Add("Shivam", "Pass");
            result.Add("Vikash", "Pass");
            result.Add("Prashant", "Pass");
            result.Add("Ratan", "Not Pass");

            ViewData["Result"] = result;
            return View();
        }
    }
}