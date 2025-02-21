using MediatR;
using Microsoft.AspNetCore.Http;
using YoutubeApi.Application.Bases;
using YoutubeApi.Application.Interface.UnitOfWorks;
using YoutubeApi.Application.Interfaces.AutoMapper;

namespace YoutubeApi.Application.Features.Product.Command.DeleteProduct
{
    public class DeleteProductCommandHandler : BaseHandler, IRequestHandler<DeleteProductCommandRequest, Unit>
    {

        public DeleteProductCommandHandler(IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(mapper, unitOfWork, httpContextAccessor)
        {
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
