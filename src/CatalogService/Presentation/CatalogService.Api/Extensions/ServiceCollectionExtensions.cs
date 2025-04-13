using CatalogService.Infrastructure.Database;

namespace CatalogService.Extensions;

/// <summary>
/// класс для инкапсулирования методов расширения
/// добавления сервисов в коллекцию
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// добавляем сервисы слоя api
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddApiServices(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddOpenApi();
        return services;
    }
}