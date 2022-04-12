using Sample.CQRS.Api.Domain.Entities;

namespace Sample.CQRS.Api.Domain.Services
{
    public interface ICacheService
    {
        void Save<T>(T entity) where T : class, IEntity;

        T Get<T>(Guid id) where T : class, IEntity;
    }
}
