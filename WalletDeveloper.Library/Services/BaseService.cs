using System;
using System.Collections.Generic;
using System.Text;
using WalletDeveloper.Library.Proxy;

namespace WalletDeveloper.Library.Services
{
    public class BaseService
    {
        public string PublicKey { get; private set; }
        public string SecretKey { get; private set; }
        public string BaseUrl { get; private set; }
        public NetworkClient _networkClient;


        public BaseService(string baseUrl, string secretKey, string publicKey)
        {
            this.BaseUrl = baseUrl;
            this.SecretKey = secretKey;
            this.PublicKey = publicKey;
            _networkClient = new NetworkClient();
        }
    }
}
