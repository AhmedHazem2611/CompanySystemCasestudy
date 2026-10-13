using Microsoft.EntityFrameworkCore;

namespace CompanySystem.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeProject> EmployeeProjects { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<ApplicationUser> Users { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(e => e.Employees)
                .WithOne(e => e.Department)
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Department>()
                .HasMany(e => e.Projects)
                .WithOne(e => e.Department)
                .HasForeignKey(e => e.DepartmentId)
                                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmployeeProjects)
                .WithOne(e => e.Employee)
                .HasForeignKey(e => e.EmployeeId)
                                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Project>()
                .HasMany(e => e.EmployeeProjects)
                .WithOne(e => e.Project)
                .HasForeignKey(e => e.ProjectId)
                                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<EmployeeProject>()
                .HasKey(e => new { e.ProjectId, e.EmployeeId });

            modelBuilder.Entity<ApplicationUser>().HasData
            (
                new ApplicationUser { Id = 1, Email = "test@gamil.com", Password = "123", Role = "Admin" }
            );
            modelBuilder.Entity<Department>().HasData
            (
                new Department { Id =1 , Location= "Vietnam", Name="CS"}
            );
            modelBuilder.Entity<Employee>().HasData
            (
                new Employee { Id = 1, DepartmentId = 1, Email = "adads@gamil.com", FullName = "ahioas", HireDate = DateTime.Parse("10-10-2026"), Salary = 1000 }
            );
            modelBuilder.Entity<Project>().HasData
                (
                    new Project { Id = 1, Budget = 1000, DepartmentId = 1, Description = "zaa", Name = "lifa tag", StartDate = DateTime.Parse("10-10-2026") }
                );
            modelBuilder.Entity<EmployeeProject>().HasData
                (
                    new EmployeeProject { Id = 1, AssignedDate = DateTime.Parse("10-10-2026"), AssignedRole = "engineer", ProjectId = 1, EmployeeId = 1 }
                );
        }
    }
}
