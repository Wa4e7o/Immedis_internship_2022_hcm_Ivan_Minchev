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

        public DbSet<Employee> Employee { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<PreviousExperience> PreviousExperiences { get; set; }

        public DbSet<SkillsAssessment> SkillsAssessments { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
               .Entity<Employee>()
               .HasOne(e => e.Position)
               .WithMany(s => s.EmployeeRecords)
               .HasForeignKey(s => s.PositionId)
               .OnDelete(DeleteBehavior.Restrict);


            builder
               .Entity<SkillsAssessment>()
               .HasOne(e => e.Employee)
               .WithMany(s => s.SkillsAssessments)
               .HasForeignKey(s => s.EmployeeId)
               .OnDelete(DeleteBehavior.Restrict);


            builder
                .Entity<PreviousExperience>()
               .HasOne(e => e.Employee)
               .WithMany(s => s.PreviousExperiences)
               .HasForeignKey(s => s.EmployeеId)
               .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}
