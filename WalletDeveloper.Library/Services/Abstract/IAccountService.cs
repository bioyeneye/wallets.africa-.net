using System.Threading.Tasks;
using WalletDeveloper.Library.Models.Responses;

namespace WalletDeveloper.Library.Services.Abstract
{
    public interface IAccountService
    {
        Task<AccountBVNResolveReponse> ResolveBVN(string bvn);
    }
}