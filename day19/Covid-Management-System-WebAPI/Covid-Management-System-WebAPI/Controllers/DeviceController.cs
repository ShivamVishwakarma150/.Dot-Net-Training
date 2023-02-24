using Covid_Management_System_WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Covid_Management_System_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeviceController : ControllerBase
    {
        private readonly COVID_DBContext _context;
        public DeviceController(COVID_DBContext context)
        {
            _context = context;
        }
        [HttpGet("GetDevice")]
        public List<Device> GetDevice()
        {
            List<Device> devices = _context.Devices.ToList();
            return devices;
        }
        [HttpPost]
        public IActionResult Post([FromBody] Device device)
        {
            _context.Devices.Add(device);
            _context.SaveChanges();
            return Created("Devices Added", device);
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            Device devices = _context.Devices.Find(id);
            devices.IsActive = false;
            _context.SaveChanges();

            return Ok();
        }
    }
}
