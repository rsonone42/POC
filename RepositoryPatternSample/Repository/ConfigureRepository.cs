using Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public static class ConfigureRepository
    {
        public static void ConfigureRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUserRepository, UserRepository>();
            serviceCollection.AddScoped<IUserAddressRepository, UserAddrssRepository>();
            serviceCollection.AddScoped<ICardPaymentDetailRepository, CardPaymentDetailRepository>();
        }
    }
}
