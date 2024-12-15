using BankingGatewayServices.Domain.Database.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Database.BankCoreDB
{
    public class Branch : BaseEntity
    {
        public string BranchName { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string BranchCode { get; set; } = string.Empty; // Unique code assigned to the branch
        public string ContactNumber { get; set; } = string.Empty; // Phone number for the branch
        public string Email { get; set; } = string.Empty; // Contact email for the branch
        public DateTime EstablishedDate { get; set; } // Date the branch was established
        public string OpeningHours { get; set; } = string.Empty; // Operating hours of the branch

    }
}
