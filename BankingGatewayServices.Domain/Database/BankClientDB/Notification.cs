using BankingGatewayServices.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Database.BankClientDB
{
    /// <summary>
    /// Represents a notification that can be sent to a user.
    /// Contains the title, message, sent date, and the current status of the notification.
    /// </summary>

    public class Notification
    {

        public Guid NotificationID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime SentDate { get; set; } = DateTime.Now;
        public NotificationStatus Status { get; set; } = NotificationStatus.Pending;

        // Foreign key for Clientes
        public string CientID { get; set; } = string.Empty;

        // Navigation property
        public Clientes Clientes { get; set; } = null!;
    }
}
