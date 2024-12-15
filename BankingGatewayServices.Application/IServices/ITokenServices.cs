using BankingGatewayServices.Domain.Database.BankClientDB;
using Microsoft.AspNetCore.Identity;


namespace BankingGatewayServices.Application.IServices
{
    public interface ITokenServices
    {
        Task<string> CreateToken(Clientes user, UserManager<Clientes> userManager);

    }
}
