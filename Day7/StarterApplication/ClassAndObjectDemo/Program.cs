using System;

namespace ClassAndObjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an object
            Employee empObject =new Employee();
            /*Employee shivam = new Employee(101, "Shivam", "arvind.972176@gmail.com", 9721769360);
            Employee vikas = new Employee(102, "Vikash");*/
            
            // Access using properties
            // get and set using properties example
            empObject.EmployeeId = 1;
            empObject.EmployeeName = "Shivam";
            empObject.Email = "arvind.972176@gmail.com";
            empObject.Contact = 9721769360;

            empObject.PrintDetails();



        }
    }
}
