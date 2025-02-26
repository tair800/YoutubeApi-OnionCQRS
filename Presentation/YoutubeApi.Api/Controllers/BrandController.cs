using MediatR;
using Microsoft.AspNetCore.Mvc;
using YoutubeApi.Application.Features.Brands.Commands.CreateBrand;
using YoutubeApi.Application.Features.Brands.Queries.GetAllBrands;

namespace YoutubeApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IMediator mediator;

        public BrandController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandCommandRequest request)
        {
            await mediator.Send(request);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await mediator.Send(new GetAllBrandsQueryRequest());

            return Ok();
        }
    }
}
