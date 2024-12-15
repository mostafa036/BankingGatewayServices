using BankingGatewayServices.Domain.Database.Common;
using BankingGatewayServices.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Database.BankCoreDB
{
    public class Loan : BaseEntity
    {
        public int ClientSSN { get; set; }
        public decimal LoanAmount { get; set; } // Total loan amount
        public decimal InterestRate { get; set; } // Interest rate as a percentage
        public DateTime LoanDate { get; set; } // Date the loan was issued
        public DateTime DueDate { get; set; } // Final repayment date
        public decimal MonthlyInstallment { get; set; } // Amount to be paid monthly
        public decimal OutstandingBalance { get; set; } // Remaining loan balance
        public LoanStatus Status { get; set; }
        public PaymentMethod PaymentMethod { get; set; } // Enum for payment method
        public string LoanPurpose { get; set; } = string.Empty;// Purpose of the loan (e.g., Personal, Business)
        public string Notes { get; set; } = string.Empty; // Additional remarks or details about the loan
        public ICollection<Payment> Payments { get; set; } // List of payments made towards the loan
    }
}
