using YoutubeApi.Domain.Common;

namespace YoutubeApi.Domain.Entities
{
    public class Product : EntityBase
    {
        public Product()
        {

        }
        public Product(string name, string description, int brandId, decimal price, decimal discount)
        {
            Name = name;
            Description = description;
            BrandId = brandId;
            Price = price;
            Discount = discount;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public Brand Brand { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
