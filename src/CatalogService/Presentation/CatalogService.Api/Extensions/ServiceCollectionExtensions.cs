using CatalogService.Infrastructure.Database;

namespace CatalogService.Extensions;

/// <summary>
/// класс для инкапсулирования методов расширения
/// добавления сервисов в коллекцию
/// </summary>
public static class ServiceCollectionExtensions
{
    public static WebApplicationBuilder AddAppServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<AppDbContext>();
        builder.Services.AddControllers();
        builder.Services.AddOpenApi();
        return builder;
    }
}