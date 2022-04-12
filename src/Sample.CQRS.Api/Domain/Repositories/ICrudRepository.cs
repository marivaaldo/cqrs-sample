using Sample.CQRS.Api.Domain.Entities;

namespace Sample.CQRS.Api.Domain.Repositories
{
    public interface ICrudRepository<T> where T : class, IEntity
    {
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        T Get(Guid id);
        IEnumerable<T> GetAll(Func<T, bool> predicate);
    }
}
