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
        [HttpGet]
        public IActionResult Index()
        {
            List<Trainer>  trainers = dbContext.Trainers.ToList();


            return View(trainers);  
        }
        [HttpGet]
        public IActionResult GetTrainerDetail(int trainerID)
        {
            Trainer trainer = dbContext.Trainers.Find(trainerID);
            return View(trainer);
        }
        [HttpGet]
        public IActionResult DeleteTrainer (int trainerId)
        {
            Trainer trainer = dbContext.Trainers.Find(trainerId);
            dbContext.Trainers.Remove(trainer);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddNewTrainer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewTrainer(Trainer trainer)
        {
            dbContext.Trainers.Add(trainer);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
