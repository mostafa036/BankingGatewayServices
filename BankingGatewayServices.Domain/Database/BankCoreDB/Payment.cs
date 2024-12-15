using BankingGatewayServices.Domain.Database.Common;
using BankingGatewayServices.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Database.BankCoreDB
{
    public class Payment : BaseEntity
    {
        public int LoanId { get; set; }
        public decimal Amount { get; set; } // Amount paid in this transaction
        public DateTime PaymentDate { get; set; } // Date of the payment
        public PaymentMethod PaymentMethod { get; set; } // Enum for the method of payment
        public string ReferenceNumber { get; set; } = string.Empty; // Unique identifier for the payment transaction
        public decimal LateFee { get; set; } // Late fee applied to the payment (if any)
        public decimal PrincipalPaid { get; set; } // Portion of the payment that goes toward the principal
        public PaymentStatus Status { get; set; } // Enum for payment status
        public Loan Loan { get; set; } = null!; // Navigation property to the associated loan


    }
}
