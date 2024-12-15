using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Database.BankCoreDB
{
    public class ScheduledPayment
    {
        public int ScheduledPaymentId { get; set; } // Unique identifier
        public int AccountId { get; set; } // Foreign key to Account
        public decimal Amount { get; set; } // Amount to be paid
        public string PayeeDetails { get; set; } // Details of the payee
        public DateTime ScheduleDate { get; set; } // Date for the scheduled payment
        public string Frequency { get; set; } // Payment frequency (e.g., Monthly, Weekly)
        public bool IsActive { get; set; } // Whether the payment is still active
        public ClientesAccounts Account { get; set; } // Navigation property for the Account
    }
}
