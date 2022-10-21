using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HR_Management_System.ModelsV2
{
    public partial class HRMSV2_DB_Context : DbContext
    {
        public HRMSV2_DB_Context()
        {
        }

        public HRMSV2_DB_Context(DbContextOptions<HRMSV2_DB_Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Applicants> Applicants { get; set; }
        public virtual DbSet<Attendances> Attendances { get; set; }
        public virtual DbSet<DegreeDetails> DegreeDetails { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Designations> Designations { get; set; }
        public virtual DbSet<Holidays> Holidays { get; set; }
        public virtual DbSet<LeaveApplications> LeaveApplications { get; set; }
        public virtual DbSet<LeaveCategories> LeaveCategories { get; set; }
        public virtual DbSet<Notices> Notices { get; set; }
        public virtual DbSet<ProfessionalExperience> ProfessionalExperience { get; set; }
        public virtual DbSet<RecruitementNotices> RecruitementNotices { get; set; }
        public virtual DbSet<Resumes> Resumes { get; set; }
        public virtual DbSet<Salaries> Salaries { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<WeekDays> WeekDays { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-O3AGVTM;Database=CoreEhrmsDB;user id =sa;password=1234567890;Trusted_Connection=True;MultipleActiveResultSets=true;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Attendances>(entity =>
            {
                entity.HasIndex(e => e.UserModelId);

                entity.HasOne(d => d.UserModel)
                    .WithMany(p => p.Attendances)
                    .HasForeignKey(d => d.UserModelId);
            });

            modelBuilder.Entity<DegreeDetails>(entity =>
            {
                entity.HasIndex(e => e.ResumeId);

                entity.HasOne(d => d.Resume)
                    .WithMany(p => p.DegreeDetails)
                    .HasForeignKey(d => d.ResumeId);
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Designations>(entity =>
            {
                entity.HasIndex(e => e.DepartmentModelId);

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.DepartmentModel)
                    .WithMany(p => p.Designations)
                    .HasForeignKey(d => d.DepartmentModelId);
            });

            modelBuilder.Entity<Holidays>(entity =>
            {
                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<LeaveApplications>(entity =>
            {
                entity.HasIndex(e => e.LeaveCategoryId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.LeaveCategory)
                    .WithMany(p => p.LeaveApplications)
                    .HasForeignKey(d => d.LeaveCategoryId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LeaveApplications)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<LeaveCategories>(entity =>
            {
                entity.Property(e => e.Title).IsRequired();
            });

            modelBuilder.Entity<Notices>(entity =>
            {
                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Title).IsRequired();
            });

            modelBuilder.Entity<ProfessionalExperience>(entity =>
            {
                entity.HasIndex(e => e.ResumeId);

                entity.HasOne(d => d.Resume)
                    .WithMany(p => p.ProfessionalExperience)
                    .HasForeignKey(d => d.ResumeId);
            });

            modelBuilder.Entity<RecruitementNotices>(entity =>
            {
                entity.Property(e => e.Department).IsRequired();

                entity.Property(e => e.Designation).IsRequired();

                entity.Property(e => e.Title).IsRequired();
            });

            modelBuilder.Entity<Resumes>(entity =>
            {
                entity.Property(e => e.NationalId).HasColumnName("NationalID");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasIndex(e => e.RecruitementNoticeModelId);

                entity.HasIndex(e => e.ResumeId);

                entity.HasIndex(e => e.SalaryId);

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.UserName).IsRequired();

                entity.HasOne(d => d.RecruitementNoticeModel)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RecruitementNoticeModelId);

                entity.HasOne(d => d.Resume)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ResumeId);

                entity.HasOne(d => d.Salary)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.SalaryId);
            });
        }
    }
}
