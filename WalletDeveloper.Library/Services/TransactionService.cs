using WalletDeveloper.Library.Services.Abstract;

namespace WalletDeveloper.Library.Services
{
    public class TransactionService : ITransactionService
    {
        private WalletAPIDriver driver;
        public TransactionService(WalletAPIDriver driver)
        {
            this.driver = driver;
        }
    }
}
