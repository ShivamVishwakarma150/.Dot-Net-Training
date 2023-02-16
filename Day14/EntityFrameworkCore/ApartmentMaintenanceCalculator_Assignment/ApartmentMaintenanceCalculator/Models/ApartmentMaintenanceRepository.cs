using System;
using System.Collections.Generic;
using System.Text;

namespace ApartmentMaintenanceCalculator.Models
{
    public class ApartmentMaintenanceRepository
    {
        public TblTenantInformation AddTenantInfo(TblTenantInformation tenantInfo)
        {
            Console.WriteLine("Enter OccupantName : ");
            tenantInfo.OccupantName=Console.ReadLine();
            Console.WriteLine("Enter EmailId: ");
            tenantInfo.EmailId=Console.ReadLine();
            Console.WriteLine("Enter Adhar Number ");
            tenantInfo.AdhaarNumber=Console.ReadLine();
            Console.WriteLine("Enter PhoneNumber");
            tenantInfo.PhoneNumber =  long.Parse(Console.ReadLine());


            return tenantInfo;
        }
        public TblApartmentInformation AddApartmentMaintenanceInfo(TblApartmentInformation apartmentInfo)
        {
            Console.WriteLine("Enter FlatNumber ");
            apartmentInfo.FlatNumber = Console.ReadLine();
            Console.WriteLine("Enter FloorNumber");
            apartmentInfo.FloorNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Tenant AdharNumber ");
            apartmentInfo.TenantAdhaarNumber = Console.ReadLine();
            Console.WriteLine("Enter Monthaly Rent");
            apartmentInfo.MonthlyRent = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Monthaly Maintenance Amount");
            apartmentInfo.MonthlyMaintenanceAmount= float.Parse(Console.ReadLine());


            return apartmentInfo;
        }

    }
}
