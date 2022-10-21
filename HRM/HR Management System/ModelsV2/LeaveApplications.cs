using System;
using System.Collections.Generic;

namespace HR_Management_System.ModelsV2
{
    public partial class LeaveApplications
    {
        public long Id { get; set; }
        public long LeaveCategoryId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime AppliedDate { get; set; }
        public int Days { get; set; }
        public string Reason { get; set; }
        public int Status { get; set; }
        public long? UserId { get; set; }

        public virtual LeaveCategories LeaveCategory { get; set; }
        public virtual Users User { get; set; }
    }
}
