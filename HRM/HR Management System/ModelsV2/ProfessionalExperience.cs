using System;
using System.Collections.Generic;

namespace HR_Management_System.ModelsV2
{
    public partial class ProfessionalExperience
    {
        public long Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string Role { get; set; }
        public DateTime? DurationFrom { get; set; }
        public DateTime? DurationTo { get; set; }
        public long? ResumeId { get; set; }

        public virtual Resumes Resume { get; set; }
    }
}
