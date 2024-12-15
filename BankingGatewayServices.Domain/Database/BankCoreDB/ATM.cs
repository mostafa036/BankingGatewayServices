using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Database.BankCoreDB
{
    public class ATM
    {
        public int AtmId { get; set; } // Unique identifier
        public string Location { get; set; } = string.Empty; // Address of the ATM
        public string AtmType { get; set; } = string.Empty; // Type (e.g., Cash Deposit, Withdrawal)
        public bool IsOperational { get; set; } // Whether the ATM is currently operational
        public DateTime LastServicedDate { get; set; } // Last maintenance date
        public decimal CashAvailable { get; set; } // Current cash available in the ATM
    }

}
