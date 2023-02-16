using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;

namespace ApartmentMaintenanceCalculator.Models
{
    public class MaintenanceCalculation
    {
        public double MaintenanceAmountCalculation(double amount)
        {
            double monthlyMaintenance=0.0f;
            if (amount <= 5000) 
            {
                monthlyMaintenance = monthlyMaintenance + monthlyMaintenance * 0.05; 
            }
            else if (amount>5000 && amount <=10000)
            {
                monthlyMaintenance += monthlyMaintenance * 0.08;
            }
            else
            {
                monthlyMaintenance += monthlyMaintenance * 0.1;
            }
            return monthlyMaintenance;
        }
    }
}
