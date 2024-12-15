﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingGatewayServices.Domain.Enums
{
    public enum TransactionType
    {
        Deposit,
        Withdrawal,
        Transfer,
        Payment,
        Refund,
        Chargeback
    }
}