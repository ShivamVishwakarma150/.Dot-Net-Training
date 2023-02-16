using System;
using System.Collections.Generic;

namespace InventoryManagementSystem.Models
{
    public partial class ProductMaster
    {
        public ProductMaster()
        {
            Transaction = new HashSet<Transaction>();
        }

        public int Productid { get; set; }
        public string ProductName { get; set; }
        public long AvialableQty { get; set; }

        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
