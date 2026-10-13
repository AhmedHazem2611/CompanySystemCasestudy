using CompanySystem.Models;
using Microsoft.IdentityModel.JsonWebTokens;
using System.IdentityModel.Tokens.Jwt;

namespace CompanySystem.Repos
{
    public class AuthRepo : GenericRepo<ApplicationUser>, IAuthRepo
    {
        private readonly AppDbContext context;
        private readonly IConfiguration configuration;
        public AuthRepo(AppDbContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
        public string Login(ApplicationUser user)
        {
            var Userr = context.Users.FirstOrDefault(e => e.Email == user.Email);
            if (Userr == null)
            {
                return null;
            }
            return null;

        }

        private string GenerateJwtToken(ApplicationUser User)
        {
            JwtSecurityToken token = new JwtSecurityToken
            (
               issuer: configuration["JWT:Issuer"]
            );

            return null;
        }
    }
}
