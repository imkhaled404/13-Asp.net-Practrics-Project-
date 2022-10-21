using System;
using System.Collections.Generic;

namespace HR_Management_System.ModelsV2
{
    public partial class Users
    {
        public Users()
        {
            Attendances = new HashSet<Attendances>();
            LeaveApplications = new HashSet<LeaveApplications>();
        }

        public long Id { get; set; }
        public byte[] ProfileImage { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public int UserType { get; set; }
        public bool RememberMe { get; set; }
        public long? ResumeId { get; set; }
        public DateTime? DateOfApplication { get; set; }
        public DateTime? InterviewDate { get; set; }
        public bool SelectedForInterview { get; set; }
        public DateTime? JoiningDate { get; set; }
        public bool Status { get; set; }
        public long? SalaryId { get; set; }
        public long? RecruitementNoticeModelId { get; set; }

        public virtual RecruitementNotices RecruitementNoticeModel { get; set; }
        public virtual Resumes Resume { get; set; }
        public virtual Salaries Salary { get; set; }
        public virtual ICollection<Attendances> Attendances { get; set; }
        public virtual ICollection<LeaveApplications> LeaveApplications { get; set; }
    }
}
