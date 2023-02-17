using Microsoft.AspNetCore.Mvc;
using AspNetCorePractice_WebApp_MVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCorePractice_WebApp_MVC.Controllers
{
    public class TrainerController : Controller
    {
        private readonly AspNetCorePracticeDbContext dbContext;
        public TrainerController(AspNetCorePracticeDbContext dbContext) {
            this.dbContext = dbContext;        
        }
        public IActionResult Index()
        {
            List<Trainer>  trainers = dbContext.Trainers.ToList();


            return View(trainers);  
        }
    }
}
