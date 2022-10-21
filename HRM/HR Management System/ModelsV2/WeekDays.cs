using System;
using System.Collections.Generic;

namespace HR_Management_System.ModelsV2
{
    public partial class WeekDays
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsWorkingDay { get; set; }
    }
}
