
using BankingGatewayServices.Domain.Database.Common;
using BankingGatewayServices.Domain.Enums;
using BankingGatewayServices.Domain.Security.Encryption;

namespace BankingGatewayServices.Domain.Database.BankCoreDB
{
    /// <summary>
    /// Represents a client's account information, including account details and sensitive data encryption for SSN.
    /// </summary>
    public class ClientesAccounts : BaseEntity
    {
        public string AccountNumber { get; set; } = string.Empty;
        public AccountType AccountType { get; set; } = AccountType.Savings;
        public bool IsActive { get; set; } = true;
        public decimal CurrentBalance { get; set; } = 0m;
        public DateTime OpenedDate { get; set; } = DateTime.Now;
        public string Currency { get; set; } = "EGP";
        public DateTime? LastTransactionDate { get; set; }

        /// <summary>
        /// The Social Security Number (SSN) of the client, encrypted for security.
        /// </summary>
        [Encryption]
        public string SSN
        {
            get { return _ssn; }
            set { _ssn = SensitiveDataEncryption.Encrypt(value); }
        }

        private string _ssn = null!;

        /// <summary>
        /// Decrypts the SSN for usage in a secure context.
        /// </summary>
        public string GetDecryptedSSN() => SensitiveDataEncryption.Decrypt(_ssn);

    }
}