﻿/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. 
If a copy of the MPL was not distributed  with this file, You can obtain one at 
http://mozilla.org/MPL/2.0/.
***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MixERP.Net.Common.Models.Transactions
{
    public static class TransactionTypeDomain
    {
        public static string GetDomain(TransactionType type)
        {
            if(type == TransactionType.Debit)
                return "Dr";
            else if(type == TransactionType.Credit)
                return "Cr";
            else
                throw new InvalidOperationException(MixERP.Net.Common.Helpers.LocalizationHelper.GetResourceString("Warnings", "UnknownTransactionType"));
        }

    }
}
