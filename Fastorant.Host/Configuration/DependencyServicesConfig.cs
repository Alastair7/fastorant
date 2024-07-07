using Fastorant.Business.Provinces;

namespace Fastorant.Host.Configuration
{
    public static class DependencyServicesConfig
    {
        public static IServiceCollection AddDependencyServices(this IServiceCollection services)
        {
            // Add here dependencies
            services.AddScoped<IProvinceBusiness, ProvinceBusiness>();
            return services;
        }
    }
}