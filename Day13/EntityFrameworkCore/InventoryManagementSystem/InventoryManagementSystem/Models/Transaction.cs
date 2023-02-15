using System;
using System.Collections.Generic;

namespace InventoryManagementSystem.Models
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime? TansactionDate { get; set; }
        public int? ProductId { get; set; }
        public string TransactionType { get; set; }
        public int? Qty { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual ProductMaster Product { get; set; }
        public virtual Users UpdatedByNavigation { get; set; }
    }
}
