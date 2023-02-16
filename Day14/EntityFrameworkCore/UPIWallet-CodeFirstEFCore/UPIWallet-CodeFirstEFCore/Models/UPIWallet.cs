using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UPIWallet_CodeFirstEFCore.Models
{
    public class UPIWallet 
    {
        
        public string FaouriteUPI()
        {
            UPIWalletContext context = new UPIWalletContext();
            List<TransactionModel> transactionList = context.TransactionModels.ToList() ;

            string higest = transactionList
                .GroupBy(t => t.UPI)
                .Select(g => new { UPI = g.Key, TotalDebit = g.Sum(t => t.Amount) })
                .OrderByDescending(g => g.TotalDebit).
                FirstOrDefault().UPI.ToString();

            Console.WriteLine(higest);

            return higest;
        }

        public Dictionary<DateTime,int> GetPerDateTransactions()
        {
            UPIWalletContext context = new UPIWalletContext();
            List<TransactionModel> transactionList = context.TransactionModels.ToList();

            var result = transactionList.GroupBy(t => t.TransactionDate).Select(g => new { Date = g.Key, TransactionCount = g.Count() }).
                OrderBy(g => g.Date).ToDictionary(g => g.Date, g => g.TransactionCount);

            return result;

        } 
    }
}
