﻿using Newtonsoft.Json;
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

        public async Task<WalletAccountResponse> GenerateWallet(string firstname, string lastname, string email,string dateOfBirth, Currency currency = Currency.NGN)
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

                return JsonConvert.DeserializeObject<WalletAccountResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<WalletAccountResponse> CreateWallet(string phonenumber, string firstname, string lastname,string password, string email, string dateOfBirth, Currency currency = Currency.NGN)
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

                return JsonConvert.DeserializeObject<WalletAccountResponse>(response);
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
        
        public async Task<WalletSetPasswordResponse> SetPassword(string phonenumber, string password)
        {
            //check for null for this properties
            try
            {
                var url = $"{driver.BaseUrl}/{Endpoints.Wallet.SETPASSWORD}";
                var payload = new
                {
                    phoneNumber = phonenumber,
                    password = password,
                    SecretKey = this.driver.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.driver.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<WalletSetPasswordResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
        public async Task<WalletSetPinResponse> SetPin(string phonenumber, string pin)
        {
            //check for null for this properties
            try
            {
                var url = $"{driver.BaseUrl}/{Endpoints.Wallet.SETPIN}";
                var payload = new
                {
                    phoneNumber = phonenumber,
                    transactionPin = pin,
                    SecretKey = this.driver.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.driver.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<WalletSetPinResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
        public async Task<WalletAccountData> VerifyBVN(string phonenumber, string bvn, string dob)
        {
            //check for null for this properties
            try
            {
                var url = $"{driver.BaseUrl}/{Endpoints.Wallet.VERIFYBVN}";
                var payload = new
                {
                    phoneNumber = phonenumber,
                    dateOfBirth = dob,
                    bvn = bvn,
                    SecretKey = this.driver.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.driver.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<WalletAccountData>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
        public async Task<WalletUserDataResponse> GetWallet(string phonenumber)
        {
            //check for null for this properties
            try
            {
                var url = $"{driver.BaseUrl}/{Endpoints.Wallet.GETUSER}";
                var payload = new
                {
                    phoneNumber = phonenumber,
                    SecretKey = this.driver.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.driver.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<WalletUserDataResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<WalletBalanceResponse> GetBalance(string phoneNumber, Currency currency = Currency.NGN)
        {
            try
            {
                var url = $"{driver.BaseUrl}/{Endpoints.Wallet.GETBALANCE}";
                var payload = new
                {
                    phoneNumber = phoneNumber,
                    Currency = currency.ToString(),
                    SecretKey = this.driver.SecretKey
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.driver.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<WalletBalanceResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<WalletTransactionResponse> GetTransactions(string phoneNumber, DateTime from, DateTime to, TransactionType transactionType = TransactionType.ALL, Currency currency = Currency.NGN, int skip = 0, int take = 10)
        {
            try
            {
                var url = $"{driver.BaseUrl}/{Endpoints.Wallet.WALLETTRANSACTIONS}";
                var payload = new
                {
                    phoneNumber,
                    skip = skip,
                    take = take,
                    dateFrom = from.ToString("yyyy-MM-dd"),
                    dateTo = to.ToString("yyyy-MM-dd"),
                    transactionType = transactionType,
                    secretKey = this.driver.SecretKey,
                    currency = currency.ToString()
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.driver.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<WalletTransactionResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
        public async Task<WalletAccountNumberDataResponse> GenerateAccountNumber(string phoneNumber)
        {
            try
            {
                var url = $"{driver.BaseUrl}/{Endpoints.Wallet.GENERATEACCOUNTNUMBER}";
                var payload = new
                {
                    phoneNumber,
                    secretKey = this.driver.SecretKey,
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.driver.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<WalletAccountNumberDataResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        
        public async Task<WalletAccountNumberDataResponse> RetrieveAccountNumber(string phoneNumber)
        {
            try
            {
                var url = $"{driver.BaseUrl}/{Endpoints.Wallet.RETRIEVEACCOUNTNUMBER}";
                var payload = new
                {
                    phoneNumber,
                    secretKey = this.driver.SecretKey,
                };
                var header = HtttpHelper.GeneratedAuthorizationHeader(this.driver.PublicKey);
                var response = await _networkClient.PostAsync(url, payload, headers: header);

                return JsonConvert.DeserializeObject<WalletAccountNumberDataResponse>(response);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
