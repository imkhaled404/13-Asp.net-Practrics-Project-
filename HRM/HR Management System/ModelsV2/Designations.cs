using System;
using System.Collections.Generic;

namespace HR_Management_System.ModelsV2
{
    public partial class Designations
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? DepartmentModelId { get; set; }

        public virtual Departments DepartmentModel { get; set; }
    }
}
