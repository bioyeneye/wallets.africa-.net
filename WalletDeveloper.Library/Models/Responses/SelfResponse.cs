using System;
using System.Collections.Generic;
using System.Text;

namespace WalletDeveloper.Library.Models.Responses
{
    public class SelfBalance
    {
        public double WalletBalance { get; set; }
        public string WalletCurrency { get; set; }
    }

    public class SelfBalanceResponse
    {
        public APIResponse Response { get; set; }
        public SelfBalance Data { get; set; }
        public bool BalanceRetrieveSuccessfully
        {
            get
            {
                return Response == null ? false : (Response.ResponseCode == "200" ? true : false);
            }
        }
    }


    public class SelfTransaction
    {
        public double Amount { get; set; }
        public string Currency { get; set; }
        public string Category { get; set; }
        public string Narration { get; set; }
        public string DateTransacted { get; set; }
        public double PreviousBalance { get; set; }
        public double NewBalance { get; set; }
        public string Type { get; set; }
    }

    public class SelTransactionData
    {
        public List<SelfTransaction> Transactions { get; set; }
    }

    public class SelfTransactionResponse
    {
        public APIResponse Response { get; set; }
        public SelTransactionData Data { get; set; }
        public bool TransactionsSucceesful
        {
            get
            {
                return Response == null ? false : (Response.ResponseCode == "200" ? true : false);
            }
        }
    }

    public class SelfVerifyBVNResponse
    {
        public string Message { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public double WalletBalance { get; set; }
        public string BVN { get; set; }
        public bool HasBVN { get; set; }
        public bool PassCodeSet { get; set; }
        public object DisplayPicture { get; set; }
        public object Username { get; set; }
        public int UserProgress { get; set; }
        public int AccountType { get; set; }
    }
}
