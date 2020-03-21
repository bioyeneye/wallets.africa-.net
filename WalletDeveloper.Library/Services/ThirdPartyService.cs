using System;
using System.Collections.Generic;
using System.Text;

namespace WalletDeveloper.Library.Services
{
    public class ThirdPartyService
    {
        private WalletAPIDriver driver;
        public ThirdPartyService(WalletAPIDriver driver)
        {
            this.driver = driver;
        }
    }
}
