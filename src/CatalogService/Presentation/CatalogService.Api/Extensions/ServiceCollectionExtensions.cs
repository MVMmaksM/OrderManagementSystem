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
    /// <param name="builder"></param>
    /// <returns></returns>
    public static WebApplicationBuilder AddApiServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        builder.Services.AddOpenApi();
        return builder;
    }
    
    /// <summary>
    /// добавляем сервисы слоя infrastructure
    /// </summary>
    /// <param name="builder"></param>
    /// <returns></returns>
    public static WebApplicationBuilder AddInfrastructureServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<AppDbContext>();
        return builder;
    }
}