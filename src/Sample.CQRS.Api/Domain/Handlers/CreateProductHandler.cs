using Sample.CQRS.Api.Domain.Commands.Requests;
using Sample.CQRS.Api.Domain.Commands.Responses;
using Sample.CQRS.Api.Domain.Entities;
using Sample.CQRS.Api.Domain.Repositories;
using Sample.CQRS.Api.Domain.Services;

namespace Sample.CQRS.Api.Domain.Handlers
{
    public class CreateProductHandler : ICreateProductHandler
    {
        private readonly IProductRepository _productRepository;
        private readonly ICacheService _cacheService;

        public CreateProductHandler(IProductRepository productRepository, ICacheService cacheService)
        {
            _productRepository = productRepository;
            _cacheService = cacheService;
        }

        public CreateProductResponse Handle(CreateProductRequest command)
        {
            var product = new Product(command.Sku, command.Name);

            _productRepository.Add(product);

            _cacheService.Save(product);

            return new()
            {
                Id = product.Id,
                CreatedOn = product.CreatedOn,
                Name = product.Name,
                Sku = product.Sku,
            };
        }
    }
}
