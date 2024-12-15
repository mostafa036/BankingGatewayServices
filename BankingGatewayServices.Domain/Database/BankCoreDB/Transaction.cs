using BankingGatewayServices.Domain.Database.Common;
using BankingGatewayServices.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Database.BankCoreDB
{
    public class Transaction : BaseEntity
    {
        public TransactionType TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;
        public TransactionStatus Status { get; set; } // Enum for transaction status
        public string Currency { get; set; } = "USD";
        public decimal TransactionFee { get; set; } // Fee charged for the transaction
        public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.CreditCard;
        public string ReferenceNumber { get; set; } = string.Empty;
    }
}
