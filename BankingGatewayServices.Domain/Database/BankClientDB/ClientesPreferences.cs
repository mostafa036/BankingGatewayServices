using BankingGatewayServices.Domain.Enums;


namespace BankingGatewayServices.Domain.Database.BankClientDB
{
    /// <summary>
    /// Represents customer preferences for receiving communications and notifications.
    /// Includes settings for email, SMS, promotional messages, language, contact method, 
    /// notification frequency, and audit fields.
    /// </summary>
    public class ClientesPreferences
    {
        public Guid PreferenceID { get; set; }
        public bool ReceiveEmails { get; set; } = true;
        public bool ReceiveSMS { get; set; } = true;
        public bool ReceivePromotionalEmails { get; set; } = false;
        public bool ReceivePromotionalSMS { get; set; } = false;
        public ContactMethod PreferredContactMethod { get; set; } = ContactMethod.Email;
        public NotificationFrequency NotificationFrequency { get; set; } = NotificationFrequency.Weekly;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime LastModifiedDate { get; set; } = DateTime.UtcNow;

        public string CientID { get; set; } = string.Empty;
        public Clientes Clientes { get; set; } = null!;
    }
}
