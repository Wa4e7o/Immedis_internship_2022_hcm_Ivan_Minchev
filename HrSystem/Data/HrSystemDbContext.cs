namespace HrSystem.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using ManagmentSystem.Data.Models;
    using HrSystem.Data.Models;

    public class HrSystemDbContext : IdentityDbContext<ApplicationUser>
    {
        public HrSystemDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<PreviousExperience> PreviousExperiences { get; set; }

        public DbSet<EmployeePreviousExperienceConnection> EmployeePreviousExperienceConnections { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
               .Entity<Position>()
               .HasMany (e => e.EmployeeRecords)
               .WithOne(s => s.Position)
               .HasForeignKey(s => s.PositionId)
               .OnDelete(DeleteBehavior.Restrict);

            builder
        .Entity<EmployeePreviousExperienceConnection>()
        .HasKey(e => new
        {
            e.EmployeeId,
            e.PreviousExperienceId
        });

            builder
               .Entity<EmployeePreviousExperienceConnection>()
               .HasOne(e => e.Employee)
               .WithMany(c => c.EmployeePreviousExperiences)
               .HasForeignKey(e => e.EmployeeId)
               .OnDelete(DeleteBehavior.Restrict);


            builder
               .Entity<EmployeePreviousExperienceConnection>()
               .HasOne(p => p.PreviousExperience)
               .WithMany(c => c.EmployeePreviousExperiences)
               .HasForeignKey(p => p.EmployeeId)
               .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}
