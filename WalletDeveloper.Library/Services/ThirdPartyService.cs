using System;
using System.Collections.Generic;
using System.Text;

namespace WalletDeveloper.Library.Services
{
    public class ThirdPartyService : BaseService
    {
        public ThirdPartyService(string baseurl, string secret, string publickey) : base(baseurl, secret, publickey)
        {

        }
    }
}
