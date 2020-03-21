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
    public class BankTransferService : BaseService, IBankTransferService
    {
        public BankTransferService(string baseurl, string secret, string publickey) : base(baseurl, secret, publickey)
        {

        }

        public async Task<List<Banks>> GetBanks()
        {
            try
            {
                var url = $"{BaseUrl}/{Endpoints.Bank.GETBANKS}";
                var payload = new
                {
                    SecretKey = this.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<List<Banks>>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<BankTransferResponse> PostDisburse(string accountnumber, string accountaname, string bankcode, decimal amount, string narration, string reference)
        {
            try
            {
                var url = $"{BaseUrl}/{Endpoints.Bank.BANKACCOUNTTRANSFER}";
                var payload = new
                {
                    BankCode = bankcode,
                    AccountNumber =  accountnumber,
                    AccountName = accountaname,
                    TransactionReference = reference,
                    Amount =  amount,
                    SecretKey = this.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.PublicKey);
                var response =  await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<BankTransferResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<BankAccountEnquiryResponse> PostAccountEnquiry(string accountnumber, string bankcode)
        {
            try
            {
                var url = $"{BaseUrl}/{Endpoints.Bank.BANKACCOUNTENQUIRY}";
                var payload = new
                {
                    AccountNumber = accountnumber,
                    BankCode = bankcode,
                    SecretKey = this.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<BankAccountEnquiryResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<BankTransferStatusResponse> PostStatusCheck(string reference)
        {
            try
            {
                var url = $"{BaseUrl}/{Endpoints.Bank.BANKACCOUNTTRANSFERSTATUS}";
                var payload = new
                {
                    TransactionReference = reference,
                    SecretKey = this.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<BankTransferStatusResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
