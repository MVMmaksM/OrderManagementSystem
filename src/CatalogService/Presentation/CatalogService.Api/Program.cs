using CatalogService.Extensions;
using CatalogService.Infrastructure.Extensions;

namespace CatalogService;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        //добавляем сервисы для слоя api
        builder.Services.AddApiServices();
        //добавляем сервисы для слоя infrastructure
        builder.Services.AddInfrastructureServices();
        
        var app = builder.Build();
    
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }
        
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}