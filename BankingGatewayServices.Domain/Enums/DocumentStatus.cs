﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Enums
{
    public enum DocumentStatus
    {
        Pending,
        Verified,
        Rejected,
        UnderReview,
        Expired
    }
}
