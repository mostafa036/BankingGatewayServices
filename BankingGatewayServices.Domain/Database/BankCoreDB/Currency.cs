using BankingGatewayServices.Domain.Database.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Database.BankCoreDB
{
    public class Currency : BaseEntity
    {
        public string CurrencyCode { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public decimal ExchangeRate { get; set; }
        public bool IsActive { get; set; }

    }
}
