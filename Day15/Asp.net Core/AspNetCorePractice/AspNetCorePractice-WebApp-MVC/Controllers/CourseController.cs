using AspNetCorePractice_WebApp_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCorePractice_WebApp_MVC.Controllers
{
    public class CourseController : Controller
    {
        private readonly AspNetCorePracticeDbContext dbContext;
        public CourseController(AspNetCorePracticeDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Course> courses = dbContext.Courses.ToList();
            return View(courses);
        }
    }
}
