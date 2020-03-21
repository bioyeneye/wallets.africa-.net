using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WalletDeveloper.Library.Constants
{
    public enum Currency
    {
        [Description("NGN")]
        NGN = 0,
        [Description("USD")]
        USD,
        [Description("GHS")]
        GHS,
        [Description("KES")]
        KES
    }

    public enum TransactionType
    {
        CREDIT = 1,
        DEBIT = 2,
        ALL
    }
}
