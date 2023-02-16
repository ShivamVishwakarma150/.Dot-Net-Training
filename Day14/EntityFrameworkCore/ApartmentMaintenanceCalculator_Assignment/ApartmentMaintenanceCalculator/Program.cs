using ApartmentMaintenanceCalculator.Models;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;

namespace ApartmentMaintenanceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApartmentMaintenanceCalculatorContext aps = new ApartmentMaintenanceCalculatorContext();
            TblTenantInformation tblTenantInformation = new TblTenantInformation();
            ApartmentMaintenanceRepository method = new ApartmentMaintenanceRepository();
            List<TblTenantInformation> tbl = aps.TblTenantInformation.ToList();

            tblTenantInformation = method.AddTenantInfo(tblTenantInformation);


            aps.TblTenantInformation.Add(tblTenantInformation);

            int rowsAffected = aps.SaveChanges(); // execute the insert query
            if (rowsAffected > 0)
            {
                Console.WriteLine("Tenant Datails Added");
            }
            else
            {

                Console.WriteLine("Something went wrong Try Again");
            }
            tblTenantInformation.DisplayTenantInfo(tbl);
        }
    }
}
