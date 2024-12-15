﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Enums
{
    public enum TransactionStatus
    {
        Pending,
        Completed,
        Failed,
        Cancelled,
        Reversed
    }

}
