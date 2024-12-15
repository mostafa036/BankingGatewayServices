using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Enums
{
    public enum LoanRequestStatus
    {
        Pending,
        Approved,
        Rejected,
        Cancelled,
        UnderReview
    }
}
