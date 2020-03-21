using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using WalletDeveloper.Library.Constants;
using WalletDeveloper.Library.Models.Responses;
using WalletDeveloper.Library.Proxy;
using WalletDeveloper.Library.Services.Abstract;

namespace WalletDeveloper.Library.Services
{

    public class AccountService : IAccountService
    {
        private Driver driver;
        private NetworkClient _networkClient;

        public AccountService(Driver driver)
        {
            this.driver = driver;
            _networkClient = new NetworkClient();
        }

        public async Task<AccountBVNResolveReponse> ResolveBVN(string bvn)
        {
            try
            {
                var url = $"{driver.BaseUrl}/{Endpoints.Account.RESOLVEBVN}";
                var payload = new
                {
                    bvn = bvn,
                    SecretKey = this.driver.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.driver.PublicKey);
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
