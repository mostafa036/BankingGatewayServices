using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingGatewayServices.Domain.Enums;

namespace BankingGatewayServices.Domain.Database.BankClientDB
{
    /// <summary>
    /// Represents an address associated with a specific client.
    /// Inherits from Address to include address details and adds a navigation property
    /// to link the address to a specific client.
    /// </summary>
    public class Address
    {
        [Key]
        public Guid AddressID { get; set; }

        [Required]
        [MaxLength(200)]
        public string AddressName { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string City { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string State { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string PostalCode { get; set; } = string.Empty;

        [Required]
        public bool IsPrimary { get; set; } = false;

        [Required]
        public AddressType AddressType { get; set; } = AddressType.Residential;

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public string ClientID { get; set; } = string.Empty;  // Unique ClientID here
        public Clientes Client { get; set; } = null!;  // Navigation property to Clientes
    }

}
