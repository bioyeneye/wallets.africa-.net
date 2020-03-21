using WalletDeveloper.Library.Services.Abstract;

namespace WalletDeveloper.Library.Services
{
    public class CardService : ICardService
    {
        private Driver driver;
        public CardService(Driver driver)
        {
            this.driver = driver;
        }
    }
}
