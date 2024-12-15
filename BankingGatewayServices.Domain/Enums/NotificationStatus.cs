using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Enums
{
    public enum NotificationStatus
    {
        /// <summary>
        /// Notification has not been sent yet and is awaiting action.
        /// </summary>
        Pending,

        /// <summary>
        /// Notification has been sent successfully.
        /// </summary>
        Sent,

        /// <summary>
        /// Notification has been viewed by the recipient.
        /// </summary>
        Viewed,

        /// <summary>
        /// Notification was not delivered successfully.
        /// </summary>
        Failed,

        /// <summary>
        /// Notification has been sent Archived.
        /// </summary>
        Archived
    }
}