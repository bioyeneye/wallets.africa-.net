using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using WalletDeveloper.Library.Constants;
using WalletDeveloper.Library.Models.Responses;
using WalletDeveloper.Library.Proxy;
using WalletDeveloper.Library.Services.Abstract;

namespace WalletDeveloper.Library.Services
{

    public class AccountService : BaseService, IAccountService
    {
        public AccountService(string baseurl, string secret, string publickey) : base(baseurl, secret, publickey)
        {

        }

        public async Task<AccountBVNResolveReponse> ResolveBVN(string bvn)
        {
            try
            {
                var url = $"{BaseUrl}/{Endpoints.Account.RESOLVEBVN}";
                var payload = new
                {
                    bvn = bvn,
                    SecretKey = this.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<AccountBVNResolveReponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
