using BankingGatewayServices.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Database.BankClientDB
{
    /// <summary>
    /// Represents a message sent or received by a client.
    /// </summary>
    public class Message
    {

        public Guid MessageID { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime SentDate { get; set; } = DateTime.Now;
        public MessageStatus Status { get; set; } = MessageStatus.Sent;

        // Foreign key for Clientes
        public string ClientID { get; set; } = string.Empty;

        // Navigation property
        public Clientes Clientes { get; set; } = null!;
    }
}
