using Sample.CQRS.Api.Domain.Entities;
using Sample.CQRS.Api.Domain.Queries.Requests;
using Sample.CQRS.Api.Domain.Queries.Responses;
using Sample.CQRS.Api.Domain.Services;

namespace Sample.CQRS.Api.Domain.Handlers
{
    public class FindProductByIdHandler : IFindProductByIdHandler
    {
        private readonly ICacheService _cacheService;

        public FindProductByIdHandler(ICacheService cacheService)
        {
            _cacheService = cacheService;
        }

        public FindProductByIdResponse Handle(FindProductByIdRequest query)
        {
            var product = _cacheService.Get<Product>(query.Id);

            return new()
            {
                Sku = product.Sku,
                Name = product.Name,
            };
        }
    }
}
