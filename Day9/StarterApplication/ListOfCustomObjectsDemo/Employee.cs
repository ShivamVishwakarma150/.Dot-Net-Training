using System;
using System.Collections.Generic;
using System.Text;

namespace ListOfCustomObjectsDemo
{
    internal class Employee
    {
        private String Name;
        private int Age;
        private String Dept;



        // for initialize private variables we use constructor
        // this conecpt is called constructor overloading
        /*public Employee() 
        { 
            
        }
        public Employee(int _id,String _name,String _email, long _employeeContact)
        {
            this.employeeId = _id;
            this.employeeName = _name;
            this.email = _email;
            this.employeeContact = _employeeContact;

        }

        public Employee(int _id,String _name)
        {
            this.employeeId = _id;
            this.employeeName = _name;
        }*/

        // Properties

        public String EmployeeName
        {
            set { Name = value; }
            get { return Name; }
        }

        public int EmployeeAge
        {
            set { Age = value; }
            get { return Age; }
        }
        public String EmployeeDept
        {
            set { Dept = value; }
            get { return Dept; }
        }
        public void PrintDetails()
        {
            Console.WriteLine(this.Name);
            Console.WriteLine(this.Age);
            Console.WriteLine(this.Dept);
           
        }

    }
}
