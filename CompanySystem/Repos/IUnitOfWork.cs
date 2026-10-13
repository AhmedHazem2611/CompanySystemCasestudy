using CompanySystem.Models;

namespace CompanySystem.Repos
{
    public interface IUnitOfWork
    {
        public IGenericRepo<Employee> Employees { get; }
        public IGenericRepo<Project> Projects { get; }
        public IGenericRepo<EmployeeProject> EmployeeProjects { get; } 
        public IGenericRepo<Department> Departments { get; }
        public IGenericRepo<ApplicationUser> Users { get; }
        public void Save();
    }
}
