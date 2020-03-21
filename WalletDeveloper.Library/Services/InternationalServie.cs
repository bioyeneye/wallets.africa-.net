using WalletDeveloper.Library.Services.Abstract;

namespace WalletDeveloper.Library.Services
{
    public class InternationalServie : IInternationalServie
    {
        private WalletAPIDriver driver;
        public InternationalServie(WalletAPIDriver driver)
        {
            this.driver = driver;
        }
    }
}
