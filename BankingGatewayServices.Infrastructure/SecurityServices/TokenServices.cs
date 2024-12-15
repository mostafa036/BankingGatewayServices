
using BankingGatewayServices.Application.IServices;
using BankingGatewayServices.Domain.Database.BankClientDB;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Infrastructure.SecurityServices
{
    public class TokenServices : ITokenServices
    {
        private readonly IConfiguration _configuration;
        private readonly SymmetricSecurityKey _key;

        public TokenServices(IConfiguration configuration)
        {
            _configuration = configuration;
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:Secret"]));
        }

        public async Task<string> CreateToken(Clientes user, UserManager<Clientes> userManager)
        {
            var authClaims = new List<Claim>()
               {
                   new Claim(ClaimTypes.Email, user.Email),

                   new Claim(ClaimTypes.GivenName, user.DisplayName)
               };

            var userRoles = await userManager.GetRolesAsync(user);

            foreach (var role in userRoles)
            {
                authClaims.Add(new Claim(ClaimTypes.Role, role));
            }

            var signingCredentials = new SigningCredentials(_key, SecurityAlgorithms.HmacSha256Signature);

            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                expires: DateTime.Now.AddMinutes(double.Parse(_configuration["JwtSettings:ExpirationInMinutes"])),
                claims: authClaims,
                signingCredentials: signingCredentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
