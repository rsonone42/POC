using Entities;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace RepositoryPatternSample.Extensions
{
    public static class ServiceExtension
    {

        public static void ConfigureSQLDBContext(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("MyConnectionString");
            services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
