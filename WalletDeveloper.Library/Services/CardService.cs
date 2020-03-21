using WalletDeveloper.Library.Services.Abstract;

namespace WalletDeveloper.Library.Services
{
    public class CardService : BaseService, ICardService
    {
        public CardService(string baseurl, string secret, string publickey) : base(baseurl, secret, publickey)
        {

        }
    }
}
