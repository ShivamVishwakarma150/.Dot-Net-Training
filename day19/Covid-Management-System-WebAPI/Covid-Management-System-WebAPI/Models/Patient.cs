using System;
using System.Collections.Generic;

#nullable disable

namespace Covid_Management_System_WebAPI.Models
{
    public partial class Patient
    {
        public Patient()
        {
            Devices = new HashSet<Device>();
            Nurses = new HashSet<Nurse>();
        }

        public int Id { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Address { get; set; }
        public long Mobile { get; set; }
        public DateTime Date { get; set; }
        public string Email { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Device> Devices { get; set; }
        public virtual ICollection<Nurse> Nurses { get; set; }
    }
}
