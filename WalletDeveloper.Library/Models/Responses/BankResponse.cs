using System;
using System.Collections.Generic;
using System.Text;

namespace WalletDeveloper.Library.Models.Responses
{
    public class BankResponse
    {

    }

    public class Banks
    {
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string BankSortCode { get; set; }
        public object PaymentGateway { get; set; }
    }

    public class BankAccountEnquiryResponse : APIResponse
    {
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string BankCode { get; set; }
        public bool AccountEnquirySuccessful
        {
            get
            {
                return string.IsNullOrWhiteSpace(ResponseCode) ? false : (ResponseCode == "200" ? true : false);
            }
        }
    }

    public class BankTransferResponse : APIResponse
    {
        public bool TransferSuccessful
        {
            get
            {
                return string.IsNullOrWhiteSpace(ResponseCode) ? false : (ResponseCode == "100" ? true : false);
            }
        }
    }

    public class BankTransferStatusResponse : APIResponse
    {
        public string Bank { get; set; }
        public string AccountNumber { get; set; }
        public string DateTransferred { get; set; }
        public double Amount { get; set; }
        public string RecipientName { get; set; }
        public object SessionId { get; set; }
        public bool TransferSuccessful
        {
            get
            {
                return string.IsNullOrWhiteSpace(ResponseCode) ? false : (ResponseCode == "100" ? true : false);
            }
        }
    }
}
