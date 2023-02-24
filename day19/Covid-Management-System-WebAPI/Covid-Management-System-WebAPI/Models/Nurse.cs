using System;
using System.Collections.Generic;

#nullable disable

namespace Covid_Management_System_WebAPI.Models
{
    public partial class Nurse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public long Mobile { get; set; }
        public string Email { get; set; }
        public int? PatientId { get; set; }
        public int? DeviceId { get; set; }
        public string Result { get; set; }
        public bool? IsActive { get; set; }

        public virtual Device Device { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
