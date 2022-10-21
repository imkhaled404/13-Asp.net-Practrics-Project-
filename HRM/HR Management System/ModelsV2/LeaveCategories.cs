using System;
using System.Collections.Generic;

namespace HR_Management_System.ModelsV2
{
    public partial class LeaveCategories
    {
        public LeaveCategories()
        {
            LeaveApplications = new HashSet<LeaveApplications>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public int Days { get; set; }

        public virtual ICollection<LeaveApplications> LeaveApplications { get; set; }
    }
}
