using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Database.BankCoreDB
{
    public class Deposit
    {
        public int DepositId { get; set; } // Unique identifier for each deposit
        public int ClientId { get; set; } // Foreign key to Client
        public decimal DepositAmount { get; set; } // Amount deposited
        public DateTime StartDate { get; set; } // Start date of the deposit
        public DateTime? MaturityDate { get; set; } // Date of maturity (null for flexible deposits)
        public decimal InterestRate { get; set; } // Annual interest rate
        public bool IsPrematureWithdrawalAllowed { get; set; } // Whether early withdrawal is allowed
        public decimal PenaltyForPrematureWithdrawal { get; set; } // Penalty percentage for premature withdrawal
        public decimal CurrentBalance { get; set; } // Current balance including interest
        public bool IsActive { get; set; } // Whether the deposit is still active
        public string ClientSSN { get; set; } = string.Empty;  // Navigation property for the Client
    }
}
