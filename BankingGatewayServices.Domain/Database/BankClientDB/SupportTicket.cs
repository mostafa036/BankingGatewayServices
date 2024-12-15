using BankingGatewayServices.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Database.BankClientDB
{
    /// <summary>
    /// Represents a support ticket submitted by a client or user.
    /// Contains details such as subject, description, and the current status of the ticket.
    /// </summary>
    public class SupportTicket
    {
        public Guid TicketID { get; set; }
        public string Subject { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public SupportTicketStatus Status { get; set; } = SupportTicketStatus.Open;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public string? ResolvedBy { get; set; }

        // Foreign key for Clientes
        public string CientID { get; set; } = string.Empty;

        // Navigation property
        public Clientes Clientes { get; set; } = null!;
    }
}