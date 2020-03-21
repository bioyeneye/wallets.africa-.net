﻿using System;
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
            var driver = new WalletAPIDriver("https://sandbox.wallets.africa", "hfucj5jatq8h", "uvjqzm5xl6bw");
            var airtimeService = new AirtimeService(driver);
            var accountService = new AccountService(driver);
            var selfService = new SelfService(driver);
            var bankService = new BankTransferService(driver);
            var walletService = new WalletService(driver);

            try
            {
                //airtime
                //var getProviders = await airtimeService.GetProviders();
                //var purchaseAirtime = await airtimeService.PostAirtime("08062986510", 200, "mtn");

                //AccountService
                //var bvnResolveResponse = await accountService.ResolveBVN("00000000000");

                //self
                //var verifybvn = await selfService.VerifyBVN("22231485915", "14-04-1992");
                //var balance = await selfService.GetBalance();
                //var transaction = await selfService.GetTransactions(DateTime.Now.AddDays(-20), DateTime.Now, Library.Constants.TransactionType.ALL, Library.Constants.Currency.NGN, 0, 40);


                //bank
                //var banks = await bankService.GetBanks();
                //var accountEnquiry = await bankService.PostAccountEnquiry("0114003495", "058");
                //var transfer = await bankService.PostDisburse("0114003495", "JOHN DOE", "058", 100, "", "123456781UIH");
                //var transferStatus = await bankService.PostStatusCheck("123456781UIH");


                //var generateWallet = await walletService.GenerateWallet("oyeneye", "simi", "bioyeneye+new@gmail.com", "1992-06-13", Library.Constants.Currency.NGN);
                //var createWallet = await walletService.CreateWallet("2348062986510", "oyeneye", "simi", "password", "bioyeneye+new@gmail.com", "1992-06-13", Library.Constants.Currency.NGN);
                //var creditResponse = await walletService.CreditWallet("2348062986510", 100, "1234567Q78AW");
                //var debitResponse = await walletService.DebitWallet("2348062986510", 100, "1234567Q78AW");
                //var debitResponse = await walletService.Verify("01047658843", "607014");

                //var setPassword = await walletService.SetPassword("13990205533", "QWASWE1223@");
                //var setPin = await walletService.SetPin("13990205533", "1234");
                //var verifyBVN = await walletService.VerifyBVN("08057898539", "22231485913", "14-04-1992");

                //var wallet = await walletService.GetWallet("08057898539");
                //var walletBalance = await walletService.GetBalance("08057898539");

                //var transaction = await walletService.GetTransactions("08062986510", DateTime.Now.AddDays(-20), DateTime.Now, Library.Constants.TransactionType.ALL, Library.Constants.Currency.NGN, 0, 40);
                var generateAccountNumber = await walletService.GenerateAccountNumber("08062986510");
                var retrieveAccountNumber = await walletService.RetrieveAccountNumber("08062986510");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
