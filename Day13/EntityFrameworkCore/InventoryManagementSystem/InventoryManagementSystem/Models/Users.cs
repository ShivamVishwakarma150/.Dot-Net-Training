using System;
using System.Collections.Generic;

namespace InventoryManagementSystem.Models
{
    public partial class Users
    {
        public Users()
        {
            Transaction = new HashSet<Transaction>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool? IsActive { get; set; }
        public string Category { get; set; }
        public string UserEmail { get; set; }

        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
