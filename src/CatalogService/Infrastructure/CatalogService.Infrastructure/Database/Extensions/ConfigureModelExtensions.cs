using CatalogService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CatalogService.Infrastructure.Database.Extensions;

/// <summary>
/// класс для методов расширения modelBuilder
/// </summary>
public static class ConfigureModelExtensions
{
    /// <summary>
    /// метод расширения для конфигурации
    /// сущности product
    /// </summary>
    /// <param name="modelBuilder"></param>
    /// <returns></returns>
    public static ModelBuilder ConfigureProduct(this ModelBuilder modelBuilder)
    {
        //имя таблицы
        modelBuilder
            .Entity<Product>()
            .ToTable("products");

        //настройка имен полей
        modelBuilder
            .Entity<Product>()
            .Property(p => p.Id)
            .HasColumnName("id");

        modelBuilder
            .Entity<Product>()
            .Property(p => p.Name)
            .HasColumnName("name");
        
        modelBuilder
            .Entity<Product>()
            .Property(p => p.Category)
            .HasColumnName("category");
        
        modelBuilder
            .Entity<Product>()
            .Property(p => p.Description)
            .HasColumnName("description");
        
        modelBuilder
            .Entity<Product>()
            .Property(p => p.CreatedDateUtc)
            .HasColumnName("created_date_utc");
        
        modelBuilder
            .Entity<Product>()
            .Property(p => p.UpdatedDateUtc)
            .HasColumnName("updated_date_utc");
        
        modelBuilder
            .Entity<Product>()
            .Property(p => p.Quantity)
            .HasColumnName("quantity");
        
        modelBuilder
            .Entity<Product>()
            .Property(p => p.Price)
            .HasColumnName("price");

        //первичный ключ
        modelBuilder
            .Entity<Product>()
            .HasKey(p => p.Id)
            .HasName("pk_product_id");
        
        //индекс
        modelBuilder
            .Entity<Product>()
            .HasIndex(p => p.Name)
            .IsUnique()
            .HasDatabaseName("idx_product_name");
            
        return modelBuilder;
    }
}