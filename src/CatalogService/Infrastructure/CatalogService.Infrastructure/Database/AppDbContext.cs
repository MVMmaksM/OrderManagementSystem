using CatalogService.Domain.Entities;
using CatalogService.Infrastructure.Database.ConfigurationsEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CatalogService.Infrastructure.Database;

public class AppDbContext(IConfiguration configuration) : DbContext
{
    public DbSet<Product> products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //конфигурируем контекст
        //уставливаем snake case имена столбцов в БД
        optionsBuilder
            .UseNpgsql(configuration.GetConnectionString("postgres_db"))
            .UseSnakeCaseNamingConvention();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //применим конфигурации для всех классов, реализующих IEntityTypeConfiguration в сборке
        //где находится ProductEntityConfiguration
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductEntityConfiguration).Assembly);
    }
}