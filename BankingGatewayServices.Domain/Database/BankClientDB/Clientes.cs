using BankingGatewayServices.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace BankingGatewayServices.Domain.Database.BankClientDB
{
    /// <summary>
    /// Represents a client in the system, extending identity functionality and including various profile attributes and relationships.
    /// </summary>
    public class Clientes : IdentityUser
    {
        public string DisplayName { get; set; } = string.Empty;
        public string NationalID { get; set; } = string.Empty;
        public Gender Gender { get; set; } = Gender.NotSpecified;
        public MaritalStatus MaritalStatus { get; set; } = MaritalStatus.Single;
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public string NationalPath { get; set; } = string.Empty;
        public string NationalPathName { get; set; } = string.Empty;


        //Navigation Properties [Many]
        public ICollection<Alert> Alerts { get; set; } = new HashSet<Alert>();
        public ICollection<Address> Addresses { get; set; } = new List<Address>();  // Collection of Addresses
        public ICollection<Beneficiary> Beneficiaries { get; set; } = new HashSet<Beneficiary>();
        public ICollection<ClientesPreferences> ClientesPreferences { get; set; } = new HashSet<ClientesPreferences>();
        public ICollection<ClientFeedback> ClientFeedbacks { get; set; } = new HashSet<ClientFeedback>();
        public ICollection<KYCDetails> KYCs { get; set; } = new HashSet<KYCDetails>();
        public ICollection<Message> Messages { get; set; } = new List<Message>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
        public ICollection<SupportTicket> SupportTickets { get; set; } = new HashSet<SupportTicket>();

        /// <summary>
        ///     Navigation Properties[One]
        /// </summary>
        public Card Card { get; set; } = null!;
        public LoginCredential? LoginCredential { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; } = null!;

        public int CountryId { get; set; }
        public Country Country { get; set; } = null!;
    }
}