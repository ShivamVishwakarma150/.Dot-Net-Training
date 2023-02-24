using System;
using System.Collections.Generic;

#nullable disable

namespace Covid_Management_System_WebAPI.Models
{
    public partial class Device
    {
        public Device()
        {
            Nurses = new HashSet<Nurse>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? PatientId { get; set; }
        public string PatientInfo { get; set; }
        public bool? IsActive { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual ICollection<Nurse> Nurses { get; set; }
    }
}
