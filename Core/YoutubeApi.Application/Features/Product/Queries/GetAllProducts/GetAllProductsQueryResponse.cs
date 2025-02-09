using YoutubeApi.Application.DTOs;

namespace YoutubeApi.Application.Features.Product.Queries.GetAllProducts
{
    public class GetAllProductsQueryResponse
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public BrandDto Brand { get; set; }
    }
}
