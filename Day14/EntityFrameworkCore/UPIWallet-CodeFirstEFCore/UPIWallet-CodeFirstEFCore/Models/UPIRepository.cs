using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPIWallet_CodeFirstEFCore.Models
{
    public class UPIRepository
    {
        public int AddUPI(UPIModel upi)
        {
            UPIWalletContext context = new UPIWalletContext();
            Console.WriteLine("Enter UPI Details");
            Console.Write("Enter the UPI : ");
            upi.UPI = Console.ReadLine();
            Console.Write("\nEnter Name : ");
            upi.Name = Console.ReadLine();
            Console.Write("\nEnter Mobile Number : "); 
            upi.Mobile = long.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter Email : ");
            upi.Email = Console.ReadLine();
            Console.Write("\nJoined on: ");
            upi.JoinedOn = DateTime.Parse(Console.ReadLine());

            context.UPIModels.Add(upi);
            int rowsAffected = context.SaveChanges();
            if (rowsAffected > 0)
            {
                Console.WriteLine("UPI Details Added");
            }
            else
            {
                Console.WriteLine("UPI Details Not Added");
            }
            return rowsAffected;
        }

        public List<UPIModel> GetUPIs()
        {
            UPIWalletContext context = new UPIWalletContext();
            List<UPIModel> lst = context.UPIModels.ToList();
            return lst;

        }

        public int AddTransactions (TransactionModel transactions)
        {
            UPIWalletContext context = new UPIWalletContext();
            Console.WriteLine("Enter Transaction Details ");
            Console.WriteLine("Enter the UPI :  ");
            transactions.UPI = new UPIModel();
            string upi = Console.ReadLine();
            transactions.UPI = context.UPIModels.Find(upi);

            Console.Write("\nEnter the Amount : ");
            transactions.Amount = long.Parse(Console.ReadLine());
            Console.Write("\nEnter Type of transaction : ");
            transactions.Type = Console.ReadLine();
            Console.Write("transaction Date : ");
            transactions.TransactionDate = DateTime.Parse(Console.ReadLine());


            List<UPIModel> lst = context.UPIModels.ToList();

            bool result = lst.Select(t => t.UPI == transactions.UPI.UPI).First();
            context.TransactionModels.Add(transactions);
            

            int rowsAffected = context.SaveChanges();
            if (rowsAffected > 0)
            {
                Console.WriteLine("Transaction Added Successfully");
            }
            else
            {
                Console.WriteLine("Transaction Details Not Added");
            }
            return rowsAffected;
        }

    }
}
