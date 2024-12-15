using BankingGatewayServices.Domain.Database.Common;
using BankingGatewayServices.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Database.BankCoreDB
{
    public class LoanRequest : BaseEntity
    {
        public int ClientSSN { get; set; }
        public decimal RequestedAmount { get; set; } // Amount requested by the client
        public DateTime RequestDate { get; set; } // Date the request was made
        public decimal ApprovedAmount { get; set; } // Amount approved by the bank (if applicable)
        public LoanRequestStatus Status { get; set; } // Enum indicating the status of the request
        public string Purpose { get; set; } = string.Empty; // Purpose for which the loan is being requested
        public int LoanTermInMonths { get; set; } // Duration of the loan in months
        public decimal ProposedInterestRate { get; set; } // Proposed interest rate for the loan
        public DateTime? ApprovalDate { get; set; } // Date the loan was approved (if applicable)
        public string Notes { get; set; } = string.Empty; // Additional remarks or details about the loan request

    }
}
