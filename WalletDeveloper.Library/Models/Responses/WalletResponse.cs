using System;
using System.Collections.Generic;
using System.Text;

namespace WalletDeveloper.Library.Models.Responses
{
    public class WalletGenerateData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public object BVN { get; set; }
        public string Password { get; set; }
        public string DateOfBirth { get; set; }
        public string DateSignedup { get; set; }
        public string AccountNo { get; set; }
        public string Bank { get; set; }
        public string AccountName { get; set; }
        public double AvailableBalance { get; set; }
    }

    public class WalletGenerateResponse
    {
        public APIResponse Response { get; set; }
        public WalletGenerateData Data { get; set; }
        public bool WalletGeneratedSuccessful
        {
            get
            {
                return Response == null ? false :  string.IsNullOrWhiteSpace(Response.ResponseCode) ? false : (Response.ResponseCode == "200" ? true : false);
            }
        }
    }

    public class WalletCreditData
    {
        public double AmountCredited { get; set; }
        public double RecipientWalletBalance { get; set; }
        public double SenderWalletBalance { get; set; }
    }

    public class WalletCreditDataResponse
    {
        public APIResponse Response { get; set; }
        public WalletCreditData Data { get; set; }
        public bool WalletCreditedSuccessful
        {
            get
            {
                return Response == null ? false : string.IsNullOrWhiteSpace(Response.ResponseCode) ? false : (Response.ResponseCode == "200" ? true : false);
            }
        }
    }

    public class WalletDebitData
    {
        public double AmountCredited { get; set; }
        public double CustomerWalletBalance { get; set; }
        public double DeveloperWalletBalance { get; set; }
    }

    public class WalletDebitDataResponse
    {
        public APIResponse Response { get; set; }
        public WalletDebitData Data { get; set; }
        public bool WalletDebitSuccessful
        {
            get
            {
                return Response == null ? false : string.IsNullOrWhiteSpace(Response.ResponseCode) ? false : (Response.ResponseCode == "200" ? true : false);
            }
        }
    }

    public class WalletVerifyResponse : APIResponse
    {
        public bool WalletDebitSuccessful
        {
            get
            {
                return string.IsNullOrWhiteSpace(ResponseCode) ? false : (ResponseCode == "200" ? true : false);
            }
        }
    }
}
