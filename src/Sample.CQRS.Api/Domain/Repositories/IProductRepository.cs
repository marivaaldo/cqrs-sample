using Sample.CQRS.Api.Domain.Entities;

namespace Sample.CQRS.Api.Domain.Repositories
{
    public interface IProductRepository : ICrudRepository<Product>
    {
    }
}
