using System;
using System.Collections.Generic;

namespace HR_Management_System.ModelsV2
{
    public partial class Salaries
    {
        public Salaries()
        {
            Users = new HashSet<Users>();
        }

        public long Id { get; set; }
        public double GrossSalary { get; set; }
        public double NetSalary { get; set; }
        public double TotalDeduction { get; set; }
        public double BasicSalary { get; set; }
        public double HouseRent { get; set; }
        public double MobileBill { get; set; }
        public double MedicalBill { get; set; }
        public double Other { get; set; }
        public double ProvidentFundDeduction { get; set; }
        public double TaxDeduction { get; set; }
        public double OtherDeduction { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
