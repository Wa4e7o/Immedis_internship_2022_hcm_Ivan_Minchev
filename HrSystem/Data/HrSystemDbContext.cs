namespace HrSystem.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using ManagmentSystem.Data.Models;

    public class HrSystemDbContext : IdentityDbContext<ApplicationUser>
    {
        public HrSystemDbContext(DbContextOptions options) 
            : base(options)
        {

        }

        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }

        public DbSet<EmployeePosition> EmployeePositions { get; set; }

        public DbSet<PreviousExperience> PreviousExperiences { get; set; }

        public DbSet<SkillsAssessment> SkillsAssessments { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
               .Entity<EmployeeDetails>()
               .HasOne(e => e.EmployeePosition)
               .WithMany(s => s.EmployeeRecords)
               .HasForeignKey(s => s.EmployeePositionId)
               .OnDelete(DeleteBehavior.Restrict);


            builder
               .Entity<SkillsAssessment>()
               .HasOne(e => e.EmployeeDetails)
               .WithMany(s => s.SkillsAssessments)
               .HasForeignKey(s => s.EmployeeDetailsId)
               .OnDelete(DeleteBehavior.Restrict);


            builder
                .Entity<PreviousExperience>()
               .HasOne(e => e.EmployeeDetails)
               .WithMany(s => s.PreviousExperiences)
               .HasForeignKey(s => s.EmployeeDetailsId)
               .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}
