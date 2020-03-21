using System;
using System.Threading.Tasks;
using WalletDeveloper.Library.Constants;
using WalletDeveloper.Library.Models.Responses;

namespace WalletDeveloper.Library.Services.Abstract
{
    public interface ISelfService
    {
        Task<SelfBalanceResponse> GetBalance(Currency currency = Currency.NGN);
        Task<SelfTransactionResponse> GetTransactions(DateTime from, DateTime to, TransactionType transactionType = TransactionType.ALL, Currency currency = Currency.NGN, int skip = 0, int take = 10);
        Task<SelfVerifyBVNResponse> VerifyBVN(string bvn, string dateOfBirth);
    }
}