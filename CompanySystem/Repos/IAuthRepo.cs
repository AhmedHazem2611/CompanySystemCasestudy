using CompanySystem.Models;

namespace CompanySystem.Repos
{
    public interface IAuthRepo: IGenericRepo<ApplicationUser>
    {
        public string Login(ApplicationUser user);
    }
}
