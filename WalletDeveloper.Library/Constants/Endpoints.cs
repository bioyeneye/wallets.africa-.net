using System;
using System.Collections.Generic;
using System.Text;

namespace WalletDeveloper.Library.Constants
{
    public class Endpoints
    {
        public class Airtime
        {
            public const string GETPROVIDERS = "bills/airtime/providers";
            public const string PURCHASE = "bills/airtime/purchase";
        }

        public class Account
        {
            public const string RESOLVEBVN = "account/resolvebvn";
        }

        public class Self
        {
            public const string GETBALANCE = "self/balance";
            public const string GETTRANSACTION = "self/transactions";
            public const string VERIFYBVN = "self/verifybvn";
        }

        public class Bank
        {
            public const string GETBANKS = "transfer/banks/all";
            public const string BANKACCOUNTENQUIRY = "transfer/bank/account/enquire";
            public const string BANKACCOUNTTRANSFER = "transfer/bank/account";
            public const string BANKACCOUNTTRANSFERSTATUS = "transfer/bank/details";
        }

        public class Wallet
        {
            public const string GENERATEWALLET = "wallet/generate";
            public const string CREATEWALLET = "wallet/create";
            public const string CREDITWALLET = "wallet/credit";
            public const string DEBITWALLET = "wallet/debit";
            public const string GETBALANCE = "wallet/balance";
            public const string GETUSER = "wallet/getuser";
            public const string WALLETTRANSACTIONS = "wallet/transactions";
            public const string GENERATEACCOUNTNUMBER = "wallet/generateaccountnumber";
            public const string RETRIEVEACCOUNTNUMBER = "wallet/nuban";
            public const string VERIFYWALLET = "wallet/verify";
            public const string SETPASSWORD = "wallet/password";
            public const string SETPIN = "wallet/pin";
            public const string VERIFYBVN = "wallet/verifybvn";  
        }
    }
}
