using YoutubeApi.Application.Bases;
using YoutubeApi.Application.Features.Product.Exceptions;

namespace YoutubeApi.Application.Features.Product.Rules
{
    public class ProductRules : BaseRules
    {
        public Task ProductTitleMustNotBeSame(IList<Domain.Entities.Product> products, string requestTitle)
        {
            if (products.Any(x => x.Name == requestTitle)) throw new ProductTitleMustNotBeSameException();
            return Task.CompletedTask;
        }
    }
}
