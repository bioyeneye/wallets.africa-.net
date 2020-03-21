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
    public class BankTransferService : IBankTransferService
    {

        private Driver driver;
        private NetworkClient _networkClient;

        public BankTransferService(Driver driver)
        {
            this.driver = driver;
            _networkClient = new NetworkClient();
        }

        public async Task<List<Banks>> GetBanks()
        {
            try
            {
                var url = $"{driver.BaseUrl}/{Endpoints.Bank.GETBANKS}";
                var payload = new
                {
                    SecretKey = this.driver.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.driver.PublicKey);
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
                var url = $"{driver.BaseUrl}/{Endpoints.Bank.BANKACCOUNTTRANSFER}";
                var payload = new
                {
                    BankCode = bankcode,
                    AccountNumber =  accountnumber,
                    AccountName = accountaname,
                    TransactionReference = reference,
                    Amount =  amount,
                    SecretKey = this.driver.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.driver.PublicKey);
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
                var url = $"{driver.BaseUrl}/{Endpoints.Bank.BANKACCOUNTENQUIRY}";
                var payload = new
                {
                    AccountNumber = accountnumber,
                    BankCode = bankcode,
                    SecretKey = this.driver.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.driver.PublicKey);
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
                var url = $"{driver.BaseUrl}/{Endpoints.Bank.BANKACCOUNTTRANSFERSTATUS}";
                var payload = new
                {
                    TransactionReference = reference,
                    SecretKey = this.driver.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.driver.PublicKey);
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
