using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Enums
{
    public enum LoanStatus
    {
        Active,
        Paid,
        Defaulted,
        PendingApproval,
        Cancelled
    }

}
