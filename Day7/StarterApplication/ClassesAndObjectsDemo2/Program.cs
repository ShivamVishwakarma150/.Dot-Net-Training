using System;

namespace ClassesAndObjectsDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp;
            char choice;
            do
            {
                emp= new Employee();
                Console.Write("Enter Employee Id: ");
                emp.EmployeeId=int.Parse(Console.ReadLine());
                Console.Write("Enter EmployeeName : ");
                emp.EmployeeName=Console.ReadLine();
                Console.Write("Enter EmployeeEmail : ");
                emp.Email=Console.ReadLine();
                Console.Write("Enter EmployeeMob : ");
                emp.Contact=long.Parse(Console.ReadLine());
                Console.WriteLine("You Entered : ");

                emp.PrintDetails();

                Console.Write("Do you want to continue Y/N : ");
                choice = char.Parse(Console.ReadLine());



            }while(choice=='Y' || choice=='y');
        }
    }
}
