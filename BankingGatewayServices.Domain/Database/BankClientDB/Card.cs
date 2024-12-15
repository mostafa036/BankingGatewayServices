using BankingGatewayServices.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Database.BankClientDB
{
    /// <summary>
    /// Represents a payment card used for transactions, such as credit or debit cards.
    /// Includes information about the card, such as the card number, expiration date, and cardholder details.
    /// </summary>
    public class Card
    {
        public Guid CardID { get; set; }
        public string CardNumber { get; set; } = string.Empty;
        public CardType CardType { get; set; } = CardType.Credit;
        public DateTime ExpiryDate { get; set; }
        public string CardHolderName { get; set; } = string.Empty;
        public string SecurityCode { get; set; } = string.Empty;
        public string IssuingBank { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public string BillingAddress { get; set; } = string.Empty;
        public string ClientID { get; set; } = string.Empty;
        public Clientes Clientes { get; set; } = null!;
    }
}