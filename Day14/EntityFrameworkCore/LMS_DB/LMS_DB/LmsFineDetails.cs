using System;
using System.Collections.Generic;

namespace LMS_DB
{
    public partial class LmsFineDetails
    {
        public LmsFineDetails()
        {
            LmsBookIssue = new HashSet<LmsBookIssue>();
        }

        public string FineRange { get; set; }
        public decimal FineAmount { get; set; }

        public virtual ICollection<LmsBookIssue> LmsBookIssue { get; set; }
    }
}
