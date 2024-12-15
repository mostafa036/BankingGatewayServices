using BankingGatewayServices.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Database.BankClientDB
{
    /// <summary>
    /// Represents an alert generated for a customer or system event.
    /// The alert can be of different types (e.g., fraud, security) and may require user or admin attention.
    /// </summary>
    public class Alert
    {

        public Guid AlertID { get; set; }
        public AlertType AlertType { get; set; } = AlertType.Fraud;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? ResolvedAt { get; set; } = DateTime.Now;
        public AlertStatus Status { get; set; } = AlertStatus.Open;

        /// <summary>
        /// Navigational Property
        /// </summary>
        public string ClientID { get; set; } = null!;
        public Clientes Clientes { get; set; } = null!;
    }
}
