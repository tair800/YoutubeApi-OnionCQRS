using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistance.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(50);

            Category category1 = new()
            {
                Id = 1,
                Name = "Elektrik",
                ParentId = 0,
                Priority = 1
            };

            Category category2 = new()
            {
                Id = 2,
                Name = "Moda",
                ParentId = 0,
                Priority = 2
            };

            Category parent1 = new()
            {
                Id = 3,
                Name = "Bilgisayar",
                ParentId = 1,
                Priority = 1
            };
            Category parent2 = new()
            {
                Id = 4,
                Name = "Kadin",
                ParentId = 2,
                Priority = 1
            };

            builder.HasData(category1, category2, parent1, parent2);
        }
    }
}
