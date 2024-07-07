using Fastorant.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Fastorant.Host.Configuration;

public static class SqLiteConfig
{
    public static IServiceCollection AddFastorantDB(this IServiceCollection services) 
    {
        services.AddDbContext<FastorantContext>(
            options => options.UseSqlite("Data Source=fastorantDB.db"));

        return services;
    }
}
