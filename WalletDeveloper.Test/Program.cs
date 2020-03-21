using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletDeveloper.Library;
using WalletDeveloper.Library.Services;

namespace WalletDeveloper.Test
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var manager = new WalletAPIManager("https://sandbox.wallets.africa", "hfucj5jatq8h", "uvjqzm5xl6bw");
            try
            {
                var airtimeProviders = await manager.AirtimeService.GetProviders();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
