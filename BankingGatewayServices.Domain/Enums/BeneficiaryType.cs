using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Enums
{
    /// <summary>
    /// Enum to represent the type of the beneficiary.
    /// </summary>
    public enum BeneficiaryType
    {
        /// <summary>
        /// Represents an individual beneficiary.
        /// </summary>
        Individual,

        /// <summary>
        /// Represents a corporate or organizational beneficiary.
        /// </summary>
        Organization
    }
}
