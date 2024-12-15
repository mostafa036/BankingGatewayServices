using BankingGatewayServices.Domain.Database.BankClientDB;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Persistence.Data.DataSeeding
{
    public class ClientIdentityDbContextSeed
    {
        public static async Task SeedCleintDataAsync(UserManager<Clientes> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new Clientes()
                {
                    UserName = "Mostafa.omara",
                    DisplayName = "Mostafa Nasser Omara",
                    Email = "mostafa20-02161@student.eelu.edu.eg",
                    PhoneNumber = "1234567890",
                    NationalID = "20302121702324",
                    CountryId = 11,
                    LanguageId = 4
                };
                var result = await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }


}
