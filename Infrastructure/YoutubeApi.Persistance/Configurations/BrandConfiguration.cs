using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistance.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(256);


            Brand brand1 = new()
            {
                Id = 1,
                Name = "name1",
            };
            Brand brand2 = new()
            {
                Id = 2,
                Name = "Name2",
            };
            Brand brand3 = new()
            {
                Id = 3,
                Name = "Name3",
                IsDeleted = true,
            };

            builder.HasData(brand1, brand2, brand3);
        }
    }
}
