using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Enums
{
    /// <summary>
    /// Enum representing the different types of alerts that can be raised.
    /// </summary>
    public enum AlertType
    {
        /// <summary>
        /// Indicates a fraud alert.
        /// </summary>
        Fraud,

        /// <summary>
        /// Indicates a security breach alert.
        /// </summary>
        Security,

        /// <summary>
        /// Indicates an alert related to an expired session.
        /// </summary>
        SessionExpiry,

        /// <summary>
        /// Indicates a suspicious activity alert.
        /// </summary>
        SuspiciousActivity,

        /// <summary>
        /// Represents any custom alert type.
        /// </summary>
        Custom
    }
}
