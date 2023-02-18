using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerProj
{
    public class EmployeeManager
    {
        private readonly List<Employee> employees;
        public int HeadCount { get; set; }
        public EmployeeManager()
        {
            employees = new List<Employee>();
            HeadCount = employees.Count;
        }
        public void AddEmployee(Employee empObj) 
        {
            employees.Add(empObj);
            HeadCount++;
        }
        public static void Main()
        {
           
        }
    }
}
