using WalletDeveloper.Library.Services.Abstract;

namespace WalletDeveloper.Library.Services
{
    public class InternationalServie : IInternationalServie
    {
        private Driver driver;
        public InternationalServie(Driver driver)
        {
            this.driver = driver;
        }
    }
}
