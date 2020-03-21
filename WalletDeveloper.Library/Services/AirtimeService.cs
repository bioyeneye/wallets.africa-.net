using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WalletDeveloper.Library.Constants;
using WalletDeveloper.Library.Models.Responses;
using WalletDeveloper.Library.Proxy;
using WalletDeveloper.Library.Services.Abstract;

namespace WalletDeveloper.Library.Services
{

    public class AirtimeService : IAirtimeService
    {
        private Driver driver;
        private NetworkClient _networkClient;
        public AirtimeService(Driver driver)
        {
            this.driver = driver;
            _networkClient = new NetworkClient();
        }

        public async Task<AirtimePurchaseResponse> PostAirtime(string phonenumber, decimal amount, string providercode)
        {
            try
            {
                var url = $"{driver.BaseUrl}/{Endpoints.Airtime.PURCHASE}";
                var payload = new
                {
                    Code = providercode,
                    Amount = amount,
                    PhoneNumber = phonenumber,
                    SecretKey = this.driver.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.driver.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<AirtimePurchaseResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<AirtimeProviderResponse> GetProviders()
        {
            try
            {
                var url = $"{driver.BaseUrl}/{Endpoints.Airtime.GETPROVIDERS}";
                var payload = new
                {
                    SecretKey = this.driver.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.driver.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<AirtimeProviderResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public Task<string> PostAirtimeForWallet(string phonenumber, decimal amount, string providercode, string walletid = "")
        {
            throw new NotImplementedException();
        }
    }
}
