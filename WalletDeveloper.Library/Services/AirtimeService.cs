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

    public sealed class AirtimeService : BaseService, IAirtimeService
    {
        public AirtimeService(string baseurl, string secret, string publickey) : base(baseurl, secret, publickey)
        {

        }

        public async Task<AirtimePurchaseResponse> PostAirtime(string phonenumber, decimal amount, string providercode)
        {
            try
            {
                var url = $"{BaseUrl}/{Endpoints.Airtime.PURCHASE}";
                var payload = new
                {
                    Code = providercode,
                    Amount = amount,
                    PhoneNumber = phonenumber,
                    SecretKey = this.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<AirtimePurchaseResponse>(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<AirtimeProviderResponse> GetProviders()
        {
            try
            {
                var url = $"{BaseUrl}/{Endpoints.Airtime.GETPROVIDERS}";
                var payload = new
                {
                    SecretKey = this.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<AirtimeProviderResponse>(response);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Task<string> PostAirtimeForWallet(string phonenumber, decimal amount, string providercode, string walletid = "")
        {
            throw new NotImplementedException();
        }
    }
}
