using System;
using System.Collections.Generic;

namespace HR_Management_System.ModelsV2
{
    public partial class DegreeDetails
    {
        public long Id { get; set; }
        public string Qualification { get; set; }
        public string Subject { get; set; }
        public string Institute { get; set; }
        public string PassingYear { get; set; }
        public string Grade { get; set; }
        public long? ResumeId { get; set; }

        public virtual Resumes Resume { get; set; }
    }
}
