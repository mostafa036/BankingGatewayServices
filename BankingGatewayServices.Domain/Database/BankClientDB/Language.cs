using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Database.BankClientDB
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; } = string.Empty;
        public ICollection<Clientes> Clientes { get; set; } = new HashSet<Clientes>();

    }
}
