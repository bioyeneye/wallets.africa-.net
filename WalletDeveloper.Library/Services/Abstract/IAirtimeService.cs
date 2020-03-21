using System.Collections.Generic;
using System.Threading.Tasks;
using WalletDeveloper.Library.Models.Responses;

namespace WalletDeveloper.Library.Services.Abstract
{
    public interface IAirtimeService
    {
        Task<AirtimeProviderResponse> GetProviders();
        Task<AirtimePurchaseResponse> PostAirtime(string phonenumber, decimal amount, string providercode);
        Task<string> PostAirtimeForWallet(string phonenumber, decimal amount, string providercode, string walletid = "");
    }
}
