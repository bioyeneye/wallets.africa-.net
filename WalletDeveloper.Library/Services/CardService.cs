using WalletDeveloper.Library.Services.Abstract;

namespace WalletDeveloper.Library.Services
{
    public class CardService : ICardService
    {
        private WalletAPIDriver driver;
        public CardService(WalletAPIDriver driver)
        {
            this.driver = driver;
        }
    }
}
