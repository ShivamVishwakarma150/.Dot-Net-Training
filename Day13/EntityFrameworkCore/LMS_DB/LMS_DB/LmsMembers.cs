using System;
using System.Collections.Generic;

namespace LMS_DB
{
    public partial class LmsMembers
    {
        public LmsMembers()
        {
            LmsBookIssue = new HashSet<LmsBookIssue>();
        }

        public string MemberId { get; set; }
        public string MemberName { get; set; }
        public string City { get; set; }
        public DateTime DateRegister { get; set; }
        public DateTime? DateExpire { get; set; }
        public string MembershipStatus { get; set; }

        public virtual ICollection<LmsBookIssue> LmsBookIssue { get; set; }
    }
}
