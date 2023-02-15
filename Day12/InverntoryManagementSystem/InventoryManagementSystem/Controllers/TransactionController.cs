using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryManagementSystem.Controllers
{
    public class TransactionController : Controller
    {
        // GET: Transaction
        public ActionResult Index()
        {
            string pageTitle = "Transaction Details";

            ViewBag.Title = pageTitle;

            Dictionary<string, string> transaction = new Dictionary<string, string>();
            transaction.Add("Shivam", "Cash");
            transaction.Add("Vikash", "Debit");
            transaction.Add("Prashant", "Credit");
            transaction.Add("Ratan", "Credit");

            ViewBag.Transaction = transaction;

            return View();
        }
    }
}