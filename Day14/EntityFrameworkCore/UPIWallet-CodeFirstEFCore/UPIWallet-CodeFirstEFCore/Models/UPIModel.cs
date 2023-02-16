using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UPIWallet_CodeFirstEFCore.Models
{
    public class UPIModel
    {
        [Key]
        public string UPI { get; set; }
        public string Name { get; set; }
        public long Mobile { get; set; }
        public string Email { get; set; }
        public DateTime JoinedOn { get; set; }
        public ICollection<TransactionModel> TransactionModel { get; set; }
    }
}
