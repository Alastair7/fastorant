namespace Fastorant.Host.Configuration.Swagger
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddCustomSwaggerGen(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.DescribeAllParametersInCamelCase();
                c.DocumentFilter<CamelCasePathDocumentFilter>();
            });

            return services;
        }
    }
}
