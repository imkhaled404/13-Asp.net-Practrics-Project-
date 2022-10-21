using System;
using System.Collections.Generic;

namespace HR_Management_System.ModelsV2
{
    public partial class Notices
    {
        public long Id { get; set; }
        public bool Published { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
