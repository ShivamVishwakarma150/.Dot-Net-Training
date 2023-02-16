using System;
using System.Collections.Generic;
using System.Linq;
using UPIWallet_CodeFirstEFCore.Models;

namespace UPIWallet_CodeFirstEFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------UPI Wallet--------------");
            Console.WriteLine("Select from the Given option");
            Console.WriteLine("1.Register your upi");
            Console.WriteLine("2.Get Upi Details");
            Console.WriteLine("3.Make a Transaction");
            Console.WriteLine("4.Favourite Upi");
            Console.WriteLine("5.Get the transactions per date");
            Console.Write("Enter the Choice: ");
            int choice = int.Parse(Console.ReadLine());
            UPIWalletContext context = new UPIWalletContext();

            List<UPIModel> model = context.UPIModels.ToList();
            List<TransactionModel> m = context.TransactionModels.ToList();
            UPIRepository upi = new UPIRepository();
            UPIWallet upiFinal = new UPIWallet();
            switch (choice)
            {

                case 1:
                    UPIModel u = new UPIModel();
                    upi.AddUPI(u);
                    break;
                case 2:
                    upi.GetUPIs();
                    foreach(var item in upi.GetUPIs()) { 
                        Console.WriteLine(item.UPI+" "+item.Name+" "+item.Mobile+" "+item.Email+" "+item.JoinedOn);

                    }
                    break;
                case 3:
                    TransactionModel t = new TransactionModel();
                    upi.AddTransactions(t);
                    break;

                case 4:

                    Console.WriteLine("Favrouite UPI : "+upiFinal.FaouriteUPI());
                    break;

                case 5:
                        foreach(var item in upiFinal.GetPerDateTransactions())
                        {
                        Console.WriteLine(item.Key + " " + item.Value);
                        }
                    break;

                default:
                    Console.WriteLine("You selected a wrong choice");
                    break;
                }




        }
    }
}
