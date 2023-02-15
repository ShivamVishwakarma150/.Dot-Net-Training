using System;
using System.Collections.Generic;

namespace LMS_DB
{
    public partial class LmsSuppliersDetails
    {
        public LmsSuppliersDetails()
        {
            LmsBookDetails = new HashSet<LmsBookDetails>();
        }

        public string SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Address { get; set; }
        public long Contact { get; set; }
        public string Email { get; set; }

        public virtual ICollection<LmsBookDetails> LmsBookDetails { get; set; }
    }
}
