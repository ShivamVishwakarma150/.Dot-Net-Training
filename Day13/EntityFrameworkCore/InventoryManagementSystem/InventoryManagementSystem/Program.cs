using System;
using System.Collections.Generic;
using System.Linq;
using InventoryManagementSystem.Models;
namespace InventoryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InventoryManagementSystemContext userDb = new InventoryManagementSystemContext();
            List<Users> users = userDb.Users.ToList();


            Console.WriteLine("UserID" + "  " + "UserName");
            Console.WriteLine("-----   --------");
            foreach (Users item in users)
            {
                Console.WriteLine("   "+item.UserId+ "     " + item.UserName);
            }

            // LINQ
            /*var result = users.Where(employees => employees.UserName.StartsWith("S"));

            foreach(Users item in result)
            {
                Console.WriteLine(item.UserName+" "+item.UserId);
            }
            */

            // CRUD - Create read Update Delete

            Console.WriteLine("Enter the details");
            Users user = new Users();
            Console.WriteLine("Enter UserName : ");
            user.UserName = Console.ReadLine();

            Console.WriteLine("Enter Password : ");
            user.Password = Console.ReadLine();

            Console.WriteLine("Enter FullName : ");
            user.FullName = Console.ReadLine();

            Console.WriteLine("Enter isActive : ");
            user.IsActive= bool.Parse(Console.ReadLine());

            Console.WriteLine("Enter Category : ");
            user.Category = Console.ReadLine();

            Console.WriteLine("Enter UserEmail : ");
            user.UserEmail = Console.ReadLine();

            userDb.Users.Add(user); // insert query

           int rowsAffected =  userDb.SaveChanges(); // execute the insert query
            if(rowsAffected> 0)
            {
                Console.WriteLine("employee Datails Added");
            }
            else
            {

                Console.WriteLine("Something went wrong Try Again");
            }


            // Delete Query
            Console.WriteLine("Enter the employee id for delete: ");
            int userId = int.Parse(Console.ReadLine());

            Users user2 = userDb.Users.Find(userId);

            // Delete
            userDb.Users.Remove(user2);// will create delete query
            userDb.SaveChanges();


            // Update Query
            Console.WriteLine("For Update");

            Console.WriteLine("Enter the user Id");
            userId = int.Parse(Console.ReadLine());
            user2 = userDb.Users.Find(userId);
            Console.WriteLine("Enter the new Password ");
            user2.Password = Console.ReadLine();
            rowsAffected = userDb.SaveChanges();

            if (rowsAffected > 0)
            {
                Console.WriteLine("Phone Number for userID " + userId);
            }
            else
            {
                Console.WriteLine("BINGO :)");
            }






        }
    }
}
