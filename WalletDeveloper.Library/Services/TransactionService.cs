using WalletDeveloper.Library.Services.Abstract;

namespace WalletDeveloper.Library.Services
{
    public class TransactionService : ITransactionService
    {
        private Driver driver;
        public TransactionService(Driver driver)
        {
            this.driver = driver;
        }
    }
}
