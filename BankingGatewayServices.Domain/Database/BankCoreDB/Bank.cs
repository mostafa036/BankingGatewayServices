using BankingGatewayServices.Domain.Database.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Database.BankCoreDB
{
    public class Bank : BaseEntity
    {
        public string BankName { get; set; } = string.Empty; // Name of the bank
        public string SwiftCode { get; set; } = string.Empty; // SWIFT/BIC code for international transfers
        public string Country { get; set; } = string.Empty; // Country where the bank operates
        public string HeadquartersAddress { get; set; } = string.Empty; // Address of the bank's headquarters
        public string ContactNumber { get; set; } = string.Empty; // Primary contact number for the bank
        public string Email { get; set; } = string.Empty; // Official email address
        public decimal TotalAssets { get; set; } // Total assets of the bank for financial reporting
        public ICollection<Branch> Branches { get; set; } = new HashSet<Branch>(); // Collection of branches under the bank
        public string? Notes { get; set; }
    }
}
