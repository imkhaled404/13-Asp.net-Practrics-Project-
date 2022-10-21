using System;
using System.Collections.Generic;

namespace HR_Management_System.ModelsV2
{
    public partial class Resumes
    {
        public Resumes()
        {
            DegreeDetails = new HashSet<DegreeDetails>();
            ProfessionalExperience = new HashSet<ProfessionalExperience>();
            Users = new HashSet<Users>();
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public byte[] ProfileImage { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string MarritualStatus { get; set; }
        public string NationalId { get; set; }
        public string Religion { get; set; }
        public string Nationality { get; set; }
        public string Email { get; set; }

        public virtual ICollection<DegreeDetails> DegreeDetails { get; set; }
        public virtual ICollection<ProfessionalExperience> ProfessionalExperience { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
