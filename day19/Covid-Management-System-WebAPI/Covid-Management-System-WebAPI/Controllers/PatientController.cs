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
    public class PatientController : ControllerBase
    {
        private readonly COVID_DBContext dbContext;
        public PatientController(COVID_DBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("GetPatient")]
        public IActionResult GetPatient()
        {
            List<Patient> patients = dbContext.Patients.ToList();

            return StatusCode(200, patients);// success code

        }

        [HttpPost]
        public IActionResult Post([FromBody] Patient patient)
        {
            dbContext.Patients.Add(patient);
            dbContext.SaveChanges();
            return Created("Patient Added", patient);
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            Patient patient = dbContext.Patients.Find(id);
            patient.IsActive = false;
            dbContext.SaveChanges();

            return Ok();
        }

    }
}
