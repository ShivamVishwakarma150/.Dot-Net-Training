using Covid_Management_System_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Covid_Management_System_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NurseController : ControllerBase
    {
        private readonly COVID_DBContext _context;
        public NurseController(COVID_DBContext context)
        {
            _context = context;
        }

        [HttpGet("GetNurse")]
        public List<Nurse> GetNurse()
        {
            List<Nurse> nurses = _context.Nurses.ToList();
            return nurses;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Nurse nurse)
        {
            _context.Nurses.Add(nurse);
            _context.SaveChanges();
            return Created("Patient Added", nurse);
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            Nurse nurses = _context.Nurses.Find(id);
            nurses.IsActive = false;
            _context.SaveChanges();

            return Ok();
        }
    }
}
