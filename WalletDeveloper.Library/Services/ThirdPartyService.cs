using System;
using System.Collections.Generic;
using System.Text;

namespace WalletDeveloper.Library.Services
{
    public class ThirdPartyService
    {
        private Driver driver;
        public ThirdPartyService(Driver driver)
        {
            this.driver = driver;
        }
    }
}
