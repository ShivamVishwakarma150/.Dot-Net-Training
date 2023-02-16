using System;
using System.Collections.Generic;

namespace ApartmentMaintenanceCalculator.Models
{
    public partial class TblApartmentInformation
    {
        public string FlatNumber { get; set; }
        public int FloorNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string TenantAdhaarNumber { get; set; }
        public double MonthlyRent { get; set; }
        public double? MonthlyMaintenanceAmount { get; set; }

        public void DisplayApartmentMaintenanceInfo(List<TblApartmentInformation> list)
        {
            foreach (TblApartmentInformation item in list)
            {
                Console.WriteLine("Display Aprtment maintenance Infromation of Tenants:");
                Console.WriteLine("Tenant Name      AdharNumber     Flat No     Apartment No    Monthly Rent     Monthly Maintenance");
                Console.WriteLine(item.TenantAdhaarNumberNavigation.OccupantName + "        " + item.TenantAdhaarNumber + "         " + item.FlatNumber + "         " + item.ApartmentNumber + "    " + item.MonthlyRent + "    " + item.MonthlyMaintenanceAmount);

            }
        }

        public virtual TblTenantInformation TenantAdhaarNumberNavigation { get; set; }
    }
}
