using AspNetCorePractice_WebApp_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCorePractice_WebApp_MVC.Controllers
{
    public class BatchController : Controller
    {
        private readonly AspNetCorePracticeDbContext _context;
        public BatchController(AspNetCorePracticeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Batch> batchList = _context.Batches.ToList();
            return View(batchList);
        }
    }
}
