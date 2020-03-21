using System.Collections.Generic;
using System.Threading.Tasks;
using WalletDeveloper.Library.Models.Responses;

namespace WalletDeveloper.Library.Services.Abstract
{
    public interface IBankTransferService
    {
        Task<List<Banks>> GetBanks();
        Task<BankAccountEnquiryResponse> PostAccountEnquiry(string accountnumber, string bankcode);
        Task<BankTransferResponse> PostDisburse(string accountnumber, string accountaname, string bankcode, decimal amount, string narration, string reference);
    }
}