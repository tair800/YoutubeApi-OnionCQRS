using MediatR;

namespace YoutubeApi.Application.Features.Product.Command.DeleteProduct
{
    public class DeleteProductCommandRequest : IRequest
    {
        public int Id { get; set; }
    }
}
