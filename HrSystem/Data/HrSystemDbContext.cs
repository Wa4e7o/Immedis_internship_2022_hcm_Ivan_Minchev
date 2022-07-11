namespace HrSystem.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using HrSystem.Data.Models;
    using ManagmentSystem.Data.Models;

    public class HrSystemDbContext : IdentityDbContext<ApplicationUser>
    {
        public HrSystemDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Position> Positions { get; set; }

        public DbSet<PreviousExperience> PreviousExperiences { get; set; }





        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder
               .Entity<Employee>()
               .HasOne(e => e.Position)
               .WithMany(c => c.EmployeeRecords)
               .HasForeignKey(e => e.PositionId)
               .OnDelete(DeleteBehavior.Restrict);


            builder
               .Entity<PreviousExperience>()
               .HasMany(p => p.EmployeePreviousExperience)
               .WithOne(c => c.PreviousExperience)
               .HasForeignKey(p => p.PreviousExperienceId)
               .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}
