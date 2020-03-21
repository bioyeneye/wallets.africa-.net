using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using WalletDeveloper.Library.Services;
using WalletDeveloper.Library.Services.Abstract;

namespace WalletDeveloper.Library.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddWalletAuthentication(this IServiceCollection services)
        {

            services.AddTransient<Driver>(c=>
            {
                return new Driver("", "", "");
            });
            services.AddTransient<IAirtimeService, AirtimeService>();
            services.AddTransient<IBankTransferService, BankTransferService>();
            services.AddTransient<IInternationalServie, InternationalServie>();
            services.AddTransient<IWalletService, WalletService>();
            return services;
        }
    }
}
