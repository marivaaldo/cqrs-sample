using Sample.CQRS.Api.Domain.Entities;

namespace Sample.CQRS.Api.Domain.Repositories
{
    public class ProductRepository : InMemoryCrudRepository<Product>, IProductRepository
    {
    }
}
