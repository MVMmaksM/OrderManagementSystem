using CatalogService.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CatalogService.Infrastructure.Database.ConfigurationsEntity;

public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        //имя таблицы
        builder.ToTable("products");
        
        //первичный ключ
        builder
            .HasKey(p => p.Id)
            .HasName("pk_product_id");
        
        //индекс
        builder
            .HasIndex(p => p.Name)
            .IsUnique()
            .HasDatabaseName("idx_product_name");
    }
}