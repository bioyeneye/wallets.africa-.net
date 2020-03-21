using System;
using System.Collections.Generic;
using System.Text;
using WalletDeveloper.Library.Proxy;
using WalletDeveloper.Library.Services;
using WalletDeveloper.Library.Services.Abstract;

namespace WalletDeveloper.Library
{
    /// <summary>
    /// Initiate the library's credential and base url to use in access in the APIs 
    /// </summary>
    public class WalletAPIManager
    {
        private string PublicKey { get; set; }
        private string SecretKey { get; set; }
        private string BaseUrl { get; set; }
        
        /// <summary>
        /// Base Constructor for the driver
        /// </summary>
        /// <param name="baseUrl">API base url which is usually staging and production</param>
        /// <param name="secretKey">Secret/Private key</param>
        /// <param name="publicKey">Public Key</param>
        public WalletAPIManager(string baseUrl, string secretKey, string publicKey)
        {
            this.BaseUrl = baseUrl;
            this.SecretKey = secretKey;
            this.PublicKey = publicKey;
        }

        public IAccountService AccountService { 
            get
            {
                return new AccountService(BaseUrl, SecretKey, PublicKey);
            } 
        }

        public IAirtimeService AirtimeService
        {
            get
            {
                return new AirtimeService(BaseUrl, SecretKey, PublicKey);
            }
        }

        public IBankTransferService BankTransferService
        {
            get
            {
                return new BankTransferService(BaseUrl, SecretKey, PublicKey);
            }
        }
        
        public ICardService CardService
        {
            get
            {
                return new CardService(BaseUrl, SecretKey, PublicKey);
            }
        }
        
        public ISelfService SelfService
        {
            get
            {
                return new SelfService(BaseUrl, SecretKey, PublicKey);
            }
        }

        public IWalletService WalletService
        {
            get
            {
                return new WalletService(BaseUrl, SecretKey, PublicKey);
            }
        }
    }
}
