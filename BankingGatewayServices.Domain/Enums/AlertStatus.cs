using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Enums
{
    /// <summary>
    /// Enum representing the possible statuses of an alert.
    /// </summary>
    public enum AlertStatus
    {
        /// <summary>
        /// The alert is still open and needs to be addressed.
        /// </summary>
        Open,

        /// <summary>
        /// The alert has been resolved.
        /// </summary>
        Resolved,

        /// <summary>
        /// The alert has been dismissed.
        /// </summary>
        Dismissed
    }
}
