using MediatR;
using YoutubeApi.Application.Features.Product.Rules;
using YoutubeApi.Application.Interface.UnitOfWorks;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Application.Features.Product.Command.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ProductRules productRules;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork, ProductRules productRules)
        {
            this.unitOfWork = unitOfWork;
            this.productRules = productRules;
        }
        public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            IList<Domain.Entities.Product> products = await unitOfWork.GetReadRepository<Domain.Entities.Product>().GetAllAsync();

            await productRules.ProductTitleMustNotBeSame(products, request.Name);

            Domain.Entities.Product product = new(request.Name, request.Description, request.BrandId, request.Price, request.Discount);

            await unitOfWork.GetWriteRepository<Domain.Entities.Product>().AddAsync(product);

            if (await unitOfWork.SaveAsync() > 0)
            {
                foreach (var categoryId in request.CategoryIds)
                    await unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(new()
                    {
                        ProductId = categoryId,
                        CategoryId = categoryId,
                    });

                await unitOfWork.SaveAsync();
            }

            return Unit.Value;


        }
    }
}
