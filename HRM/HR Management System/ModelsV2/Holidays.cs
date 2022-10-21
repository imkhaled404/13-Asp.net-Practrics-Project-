using System;
using System.Collections.Generic;

namespace HR_Management_System.ModelsV2
{
    public partial class Holidays
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
