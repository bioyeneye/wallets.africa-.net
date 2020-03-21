using WalletDeveloper.Library.Services.Abstract;

namespace WalletDeveloper.Library.Services
{
    public class TransactionService : BaseService, ITransactionService
    {
        public TransactionService(string baseurl, string secret, string publickey) : base(baseurl, secret, publickey)
        {

        }
    }
}
