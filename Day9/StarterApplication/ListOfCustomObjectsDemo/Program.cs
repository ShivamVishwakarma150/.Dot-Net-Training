using System;
using System.Collections.Generic;
using System.Linq;
namespace ListOfCustomObjectsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List of Integers
            List<int> listOfNumbers = new List<int>();
            listOfNumbers.Add(100);
            listOfNumbers.Add(25);
            listOfNumbers.Add(90);

            Employee john = new Employee();
            john.EmployeeName = "John Math";
            john.EmployeeAge = 45;
            john.EmployeeDept = "IT";

            // List of Employee
            // syntax for List List<T>  , T -> Type
            List<Employee> listOfEmployees = new List<Employee>();

            listOfEmployees.Add(john);

            Employee prem = new Employee();
            prem.EmployeeName = "Prem Kumar";
            prem.EmployeeAge = 33;
            prem.EmployeeDept = "Accounts";

            listOfEmployees.Add(prem);

            listOfEmployees.Add(new Employee() { EmployeeName = "Aabha", EmployeeAge = 35, EmployeeDept = "Training" });
            listOfEmployees.Add(new Employee() { EmployeeName = "Shivam", EmployeeAge = 22, EmployeeDept = "Training" });

            Console.WriteLine("Name       Dept       Age");
            foreach(Employee item in listOfEmployees)
            {
                Console.WriteLine(item.EmployeeName + "   " + item.EmployeeDept + "   " + item.EmployeeAge);
            }

            Console.WriteLine("Display the Employees from training department");

            foreach(Employee item in listOfEmployees)
            {
                if (item.EmployeeDept == "Training")
                {
                    Console.WriteLine(item.EmployeeName);
                }
            }

            // SQL Query structure - Select temp.Name from listOfEmployees as temp where temp.Dept="Training";

            // LINQ - Lnaguage integrated query

            var query = from temp in listOfEmployees where temp.EmployeeDept == "Training" select temp.EmployeeName;

            foreach(var item in query)
            {
                Console.WriteLine(item);
            }

            // Data Sources - List (C#) , Tables(SQL) , Access table (SQL) , XML , JSON

            Console.WriteLine("Display data of employees names starting with A");
            var query1 = from t in listOfEmployees where t.EmployeeName.StartsWith("A") select t;

            foreach(var item in query1)
            {
                Console.WriteLine(item.EmployeeName);
            }

            // Count Employees in each dept using Linq or extension methods
            var q2 = listOfEmployees.GroupBy(e => e.EmployeeDept).ToDictionary(e => e.Key, count => count.Count());

            foreach(KeyValuePair<String,int> item in q2)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }

        }
    }
}
