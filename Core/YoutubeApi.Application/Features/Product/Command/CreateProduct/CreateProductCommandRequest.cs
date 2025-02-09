using MediatR;

namespace YoutubeApi.Application.Features.Product.Command.CreateProduct
{
    public class CreateProductCommandRequest : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
