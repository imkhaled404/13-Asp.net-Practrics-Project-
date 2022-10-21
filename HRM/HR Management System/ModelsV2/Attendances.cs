using System;
using System.Collections.Generic;

namespace HR_Management_System.ModelsV2
{
    public partial class Attendances
    {
        public long Id { get; set; }
        public int Status { get; set; }
        public DateTime Date { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int Day { get; set; }
        public long? UserModelId { get; set; }

        public virtual Users UserModel { get; set; }
    }
}
