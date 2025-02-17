using MediatR;
using YoutubeApi.Application.Interface.UnitOfWorks;

namespace YoutubeApi.Application.Features.Product.Command.DeleteProduct
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, Unit>
    {
        private readonly IUnitOfWork unitOfWork;

        public DeleteProductCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await unitOfWork.GetReadRepository<Domain.Entities.Product>()
                 .GetAsync(s => s.Id == request.Id && !s.IsDeleted);
            product.IsDeleted = true;

            await unitOfWork.GetWriteRepository<Domain.Entities.Product>()
                .UpdateAsync(product);

            await unitOfWork.SaveAsync();

            return Unit.Value;
        }

    }
}
