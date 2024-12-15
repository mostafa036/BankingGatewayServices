using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Enums
{
    public enum SupportTicketStatus
    {
        /// <summary>
        /// The ticket has been created but not yet processed.
        /// </summary>
        Open,

        /// <summary>
        /// The ticket is being actively worked on by support.
        /// </summary>
        InProgress,

        /// <summary>
        /// The ticket has been resolved and closed.
        /// </summary>
        Closed,

        /// <summary>
        /// The ticket has been canceled or rejected.
        /// </summary>
        Canceled
    }
}
