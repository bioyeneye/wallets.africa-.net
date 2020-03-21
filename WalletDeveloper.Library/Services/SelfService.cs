using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using WalletDeveloper.Library.Constants;
using WalletDeveloper.Library.Models.Responses;
using WalletDeveloper.Library.Proxy;
using WalletDeveloper.Library.Services.Abstract;

namespace WalletDeveloper.Library.Services
{

    public class SelfService : BaseService, ISelfService
    {
        public SelfService(string baseurl, string secret, string publickey) : base(baseurl, secret, publickey)
        {

        }

        public async Task<SelfBalanceResponse> GetBalance(Currency currency = Currency.NGN)
        {
            try
            {
                var url = $"{BaseUrl}/{Endpoints.Self.GETBALANCE}";
                var payload = new
                {
                    Currency = currency.ToString(),
                    SecretKey = this.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<SelfBalanceResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<SelfTransactionResponse> GetTransactions(DateTime from, DateTime to, TransactionType transactionType = TransactionType.ALL, Currency currency = Currency.NGN, int skip = 0, int take = 10)
        {
            try
            {
                var url = $"{BaseUrl}/{Endpoints.Self.GETTRANSACTION}";
                var payload = new
                {
                    skip = skip,
                    take = take,
                    dateFrom = from.ToString("yyyy-MM-dd"),
                    dateTo = to.ToString("yyyy-MM-dd"),
                    transactionType = transactionType,
                    secretKey = this.SecretKey,
                    currency = currency.ToString()
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<SelfTransactionResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<SelfVerifyBVNResponse> VerifyBVN(string bvn, string dateOfBirth)
        {
            try
            {
                var url = $"{BaseUrl}/{Endpoints.Self.VERIFYBVN}";
                var payload = new
                {
                    bvn = bvn,
                    dateOfBirth = dateOfBirth,
                    secretKey = this.SecretKey,
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<SelfVerifyBVNResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
