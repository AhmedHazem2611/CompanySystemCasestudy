using CompanySystem.Models;

namespace CompanySystem.Repos
{
    public class UnitOfWork : IUnitOfWork
    {
        public IGenericRepo<Employee> Employees { get; }

        public IGenericRepo<Project> Projects { get; }

        public IGenericRepo<EmployeeProject> EmployeeProjects { get; }

        public IGenericRepo<Department> Departments { get; }

        public IGenericRepo<ApplicationUser> Users { get; }
        private readonly AppDbContext context;
        public UnitOfWork(AppDbContext context, IGenericRepo<Project> Project, IGenericRepo<Employee> Employees, IGenericRepo<EmployeeProject> EmployeeProject, IGenericRepo<Department> Departments, IGenericRepo<ApplicationUser> Users)
        {
            this.context = context;
            this.Employees = Employees;
            this.EmployeeProjects = EmployeeProject;
            this.Projects = Project;
            this.Users = Users;
            this.Departments = Departments;
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
