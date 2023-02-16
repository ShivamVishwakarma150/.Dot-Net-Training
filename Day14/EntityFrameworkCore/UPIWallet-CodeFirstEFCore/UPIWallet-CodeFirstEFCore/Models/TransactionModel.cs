using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UPIWallet_CodeFirstEFCore.Models
{
    public class TransactionModel
    {
        [Key]
        public int TransactionId { get; set; }
        public string Type { get; set; }
        public Double Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public virtual UPIModel UPI { get; set; } 
    }
}
