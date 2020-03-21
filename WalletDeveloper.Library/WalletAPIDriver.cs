using System;
using System.Collections.Generic;
using System.Text;

namespace WalletDeveloper.Library
{
    /// <summary>
    /// Initiate the library's credential and base url to use in access in the APIs 
    /// </summary>
    public class WalletAPIDriver
    {
        public string PublicKey { get; private set; }
        public string SecretKey { get; private set; }
        public string BaseUrl { get; private set; }
        /// <summary>
        /// Base Constructor for the driver
        /// </summary>
        /// <param name="baseUrl">API base url which is usually staging and production</param>
        /// <param name="secretKey">Secret/Private key</param>
        /// <param name="publicKey">Public Key</param>
        public WalletAPIDriver(string baseUrl, string secretKey, string publicKey)
        {
            this.BaseUrl = baseUrl;
            this.SecretKey = secretKey;
            this.PublicKey = publicKey;
        }
    }
}
