using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Enums
{
    public enum PaymentStatus
    {
        Completed,
        Pending,
        Failed,
        Refunded
    }
}
