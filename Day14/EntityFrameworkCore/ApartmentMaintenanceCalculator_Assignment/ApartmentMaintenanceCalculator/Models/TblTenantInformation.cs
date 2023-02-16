using System;
using System.Collections.Generic;

namespace ApartmentMaintenanceCalculator.Models
{
    public partial class TblTenantInformation
    {
        public TblTenantInformation()
        {
            TblApartmentInformation = new HashSet<TblApartmentInformation>();
        }
        public void DisplayTenantInfo(List<TblTenantInformation> list)
        {
            Console.WriteLine("Display Tenants Infromation ");
            Console.WriteLine("Tenant Name      Adhar Number    EmailId     MobileNumber ");
            foreach (TblTenantInformation item in list)
            {
                Console.WriteLine(item.OccupantName + "     " + item.AdhaarNumber + " " + item.EmailId + " " + item.PhoneNumber);
            }
        }

        public string OccupantName { get; set; }
        public string EmailId { get; set; }
        public string AdhaarNumber { get; set; }
        public long? PhoneNumber { get; set; }

        public virtual ICollection<TblApartmentInformation> TblApartmentInformation { get; set; }
    }
}
