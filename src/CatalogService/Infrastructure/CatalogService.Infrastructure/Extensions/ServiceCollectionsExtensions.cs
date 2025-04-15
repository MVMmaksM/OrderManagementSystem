using CatalogService.Infrastructure.Database;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CatalogService.Infrastructure.Extensions;

public static class ServiceCollectionsExtensions
{
    /// <summary>
    /// добавляем сервисы слоя infrastructure
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>();
        return services;
    }
}