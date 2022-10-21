using System;
using System.Collections.Generic;

namespace HR_Management_System.ModelsV2
{
    public partial class Applicants
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public DateTime? DateOfApplication { get; set; }
        public DateTime? DateOfInterview { get; set; }
    }
}
