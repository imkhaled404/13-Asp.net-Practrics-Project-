using System;
using System.Collections.Generic;

namespace HR_Management_System.ModelsV2
{
    public partial class Departments
    {
        public Departments()
        {
            Designations = new HashSet<Designations>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Designations> Designations { get; set; }
    }
}
