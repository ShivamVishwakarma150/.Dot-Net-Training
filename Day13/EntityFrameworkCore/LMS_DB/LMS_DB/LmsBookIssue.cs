using System;
using System.Collections.Generic;

namespace LMS_DB
{
    public partial class LmsBookIssue
    {
        public int BookIssueNo { get; set; }
        public string MemberId { get; set; }
        public string BookCode { get; set; }
        public DateTime DateIssue { get; set; }
        public DateTime DateReturn { get; set; }
        public DateTime? DateReturned { get; set; }
        public string FineRange { get; set; }

        public virtual LmsBookDetails BookCodeNavigation { get; set; }
        public virtual LmsFineDetails FineRangeNavigation { get; set; }
        public virtual LmsMembers Member { get; set; }
    }
}
