using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Database.BankClientDB
{
    /// <summary>
    /// Represents feedback provided by a client, including comments and ratings.
    /// </summary>
    public class ClientFeedback
    {
        public Guid FeedbackID { get; set; }
        public string Comments { get; set; } = string.Empty;

        [Required]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int Rating { get; set; }

        // Navigation property
        public string CientID { get; set; } = string.Empty;
        public Clientes Clientes { get; set; } = null!;
    }
}
