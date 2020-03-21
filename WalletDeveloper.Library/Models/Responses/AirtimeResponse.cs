using System;
using System.Collections.Generic;
using System.Text;

namespace WalletDeveloper.Library.Models.Responses
{
    public class AirtimeProvider
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public  class AirtimeProviderResponse : APIResponse
    {
        public List<AirtimeProvider> Providers { get; set; }
    }

    public class AirtimePurchaseResponse : APIResponse
    {
        public string TransactionReference { get; set; }
        public bool PurchaseSuccessful { 
            get
            {
                return string.IsNullOrWhiteSpace(ResponseCode) ? false : (ResponseCode == "100" ? true : false);
            }
        }
    }
}
