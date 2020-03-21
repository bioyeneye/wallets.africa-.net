using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using WalletDeveloper.Library.Constants;
using WalletDeveloper.Library.Models.Responses;
using WalletDeveloper.Library.Proxy;
using WalletDeveloper.Library.Services.Abstract;

namespace WalletDeveloper.Library.Services
{
    public class WalletService : IWalletService
    {
        private WalletAPIDriver driver;
        private NetworkClient _networkClient;
        public WalletService(WalletAPIDriver driver)
        {
            this.driver = driver;
            _networkClient = new NetworkClient();
        }

        public async Task<WalletGenerateResponse> GenerateWallet(string firstname, string lastname, string email,string dateOfBirth, Currency currency = Currency.NGN)
        {
            //check for null for this properties
            try
            {
                var url = $"{driver.BaseUrl}/{Endpoints.Wallet.GENERATEWALLET}";
                var payload = new
                {
                    firstName =  firstname,
                    lastName = lastname,
                    email  =  email,
                    dateOfBirth =  dateOfBirth,
                    currency = currency.ToString(),
                    SecretKey = this.driver.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.driver.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<WalletGenerateResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<WalletGenerateResponse> CreateWallet(string phonenumber, string firstname, string lastname,string password, string email, string dateOfBirth, Currency currency = Currency.NGN)
        {
            //check for null for this properties
            try
            {
                var url = $"{driver.BaseUrl}/{Endpoints.Wallet.CREATEWALLET}";
                var payload = new
                {
                    phoneNumber = phonenumber,
                    firstName = firstname,
                    lastName = lastname,
                    password = password,
                    email = email,
                    dateOfBirth = dateOfBirth,
                    currency = currency.ToString(),
                    SecretKey = this.driver.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.driver.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<WalletGenerateResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<WalletCreditDataResponse> CreditWallet(string phonenumber, decimal amount, string transactionReference)
        {
            //check for null for this properties
            try
            {
                var url = $"{driver.BaseUrl}/{Endpoints.Wallet.CREDITWALLET}";
                var payload = new
                {
                    phoneNumber = phonenumber,
                    amount = amount,
                    transactionReference = transactionReference,
                    SecretKey = this.driver.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.driver.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<WalletCreditDataResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<WalletDebitDataResponse> DebitWallet(string phonenumber, decimal amount, string transactionReference)
        {
            //check for null for this properties
            try
            {
                var url = $"{driver.BaseUrl}/{Endpoints.Wallet.DEBITWALLET}";
                var payload = new
                {
                    phoneNumber = phonenumber,
                    amount = amount,
                    transactionReference = transactionReference,
                    SecretKey = this.driver.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.driver.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<WalletDebitDataResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<WalletVerifyResponse> Verify(string phonenumber, string otp)
        {
            //check for null for this properties
            try
            {
                var url = $"{driver.BaseUrl}/{Endpoints.Wallet.VERIFYWALLET}";
                var payload = new
                {
                    phoneNumber = phonenumber,
                    otp = otp,
                    SecretKey = this.driver.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.driver.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<WalletVerifyResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
