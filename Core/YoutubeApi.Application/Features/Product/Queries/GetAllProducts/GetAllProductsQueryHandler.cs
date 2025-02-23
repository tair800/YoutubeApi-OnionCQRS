using MediatR;
using Microsoft.EntityFrameworkCore;
using YoutubeApi.Application.DTOs;
using YoutubeApi.Application.Interface.UnitOfWorks;
using YoutubeApi.Application.Interfaces.AutoMapper;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Application.Features.Product.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await unitOfWork
                .GetReadRepository<YoutubeApi.Domain.Entities.Product>()
                .GetAllAsync(include: x => x.Include(b => b.Brand));

            var brand = mapper.Map<BrandDto, Brand>(new Brand());

            //List<GetAllProductsQueryResponse> response = new();

            //foreach (var product in products)
            //    response.Add(new GetAllProductsQueryResponse
            //    {
            //        Name = product.Name,
            //        Description = product.Description,
            //        Discount = product.Discount,
            //        Price = product.Price - (product.Price * product.Discount / 100),
            //    });

            var map = mapper.Map<GetAllProductsQueryResponse, Domain.Entities.Product>(products);

            foreach (var product in map)
                product.Price = (product.Price * product.Discount / 100);

            return map;

        }
    }
}
