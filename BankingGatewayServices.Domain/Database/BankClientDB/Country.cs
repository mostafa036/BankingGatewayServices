using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Database.BankClientDB
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string IsoCode { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string Capital { get; set; } = string.Empty;
        public string TimeZone { get; set; } = string.Empty;

        // Navigation property for one-to-many relationship
        public ICollection<Clientes> Clientes { get; set; } = new HashSet<Clientes>();
    }
}
