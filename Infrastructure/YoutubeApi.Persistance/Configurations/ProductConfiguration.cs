using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistance.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Product product1 = new()
            {
                Id = 1,
                Name = "iPhone 13",
                Description = "Latest Apple smartphone",
                BrandId = 1,
                Discount = 5.0m,
                Price = 999.99m
            };

            Product product2 = new()
            {
                Id = 2,
                Name = "Samsung Galaxy S23",
                Description = "High-end Android smartphone",
                BrandId = 2,
                Discount = 7.5m,
                Price = 899.99m
            };

            builder.HasData(product1, product2);
        }
    }
}
