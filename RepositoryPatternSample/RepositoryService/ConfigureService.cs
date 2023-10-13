using Contracts.Services;
using Microsoft.Extensions.DependencyInjection;

namespace RepositoryService
{
    public static class ConfigureService
    {
        public static void ConfigureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUserService,  UserService>();
        }

    }
}