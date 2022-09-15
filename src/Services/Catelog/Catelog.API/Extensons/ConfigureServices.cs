using Catalog.API.Data;
using Catalog.API.Repositories;

namespace Catelog.API.Extensons
{
    public static class ConfigureServices
    {
        public static IServiceCollection ServiceConfig(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICatalogContext, CatalogContext>();

            return services;
        }
    }
}
