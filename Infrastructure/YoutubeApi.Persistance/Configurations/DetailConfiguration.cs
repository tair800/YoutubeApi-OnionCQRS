using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistance.Configurations
{
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Detail detail1 = new()
            {
                Id = 1,
                Title = "Technology Trends",
                Description = "Latest innovations in the tech industry.",
                CategoryId = 1
            };

            Detail detail2 = new()
            {
                Id = 2,
                Title = "Health and Fitness",
                Description = "Best practices for maintaining a healthy lifestyle.",
                CategoryId = 4,
                IsDeleted = true
            };

            Detail detail3 = new()
            {
                Id = 3,
                Title = "Travel Tips",
                Description = "Top destinations and travel hacks for 2024.",
                CategoryId = 4
            };

            builder.HasData(detail1, detail2, detail3);
        }
    }
}
