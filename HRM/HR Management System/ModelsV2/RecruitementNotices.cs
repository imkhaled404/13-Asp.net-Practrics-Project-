using System;
using System.Collections.Generic;

namespace HR_Management_System.ModelsV2
{
    public partial class RecruitementNotices
    {
        public RecruitementNotices()
        {
            Users = new HashSet<Users>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastDate { get; set; }
        public bool IsPublished { get; set; }
        public int NumberOfVacancy { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
