using BankingGatewayServices.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace BankingGatewayServices.Domain.Database.BankClientDB
{
    /// <summary>
    /// Represents a beneficiary for financial transactions, such as transfers or payouts.
    /// Includes information like name, account details, and bank information.
    /// </summary>
    public class Beneficiary
    {
        [Key]
        public Guid BeneficiaryID { get; set; }
        public string BeneficiaryName { get; set; } = string.Empty;
        public string AccountNumber { get; set; } = string.Empty;
        public string BankName { get; set; } = string.Empty;
        public BeneficiaryType BeneficiaryType { get; set; } = BeneficiaryType.Individual;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }

        public string ClientID { get; set; } = null!;
        public Clientes Clientes { get; set; } = null!;
    }
}