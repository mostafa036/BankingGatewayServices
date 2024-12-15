using BankingGatewayServices.Domain.Enums;

namespace BankingGatewayServices.Domain.Database.BankClientDB
{
    /// <summary>
    /// Represents the Know Your Customer (KYC) details for a client, including information on the document type, its validity, and status.
    /// </summary>
    public class KYCDetails
    {
        public Guid KYCID { get; set; }

        /// <summary>
        /// Type of document used for KYC (e.g., Passport, National ID).
        /// Default is set to 'Passport'.
        /// </summary>
        public DocumentType DocumentType { get; set; } = DocumentType.Passport;
        public string DocumentNumber { get; set; } = string.Empty;
        public DateTime IssuedDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        /// <summary>
        /// The authority that issued the KYC document (e.g., government agency).
        /// </summary>
        public string IssuingAuthority { get; set; } = string.Empty;
        public DocumentStatus DocumentStatus { get; set; } = DocumentStatus.Pending;

        public string UploadPath { get; set; } = string.Empty; // Path to the scanned document
        public string NameFile { get; set; } = string.Empty;

        public string ClientID { get; set; } = string.Empty;
        public Clientes Clientes { get; set; } = null!;
    }
}