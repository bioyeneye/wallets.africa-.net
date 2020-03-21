using WalletDeveloper.Library.Services.Abstract;

namespace WalletDeveloper.Library.Services
{
    public class InternationalServie : BaseService, IInternationalServie
    {
        public InternationalServie(string baseurl, string secret, string publickey) : base(baseurl, secret, publickey)
        {

        }
    }
}
