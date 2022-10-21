using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.ModelsV2
{
    public class SalaryViewModel
    {
        public List<Users> UserLst { get; set; }
        public List<Departments> DeptLst { get; set; }
        public List<Salaries> SalaryLst { get; set; }
    }
}
