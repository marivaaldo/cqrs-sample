using Sample.CQRS.Api.Domain.Entities;
using System.Collections.Concurrent;

namespace Sample.CQRS.Api.Domain.Repositories
{
    public abstract class InMemoryCrudRepository<T> : ICrudRepository<T> where T : class, IEntity
    {
        private readonly ConcurrentDictionary<Guid, T> _entities = new();

        public T Add(T entity)
        {
            _entities.TryAdd(entity.Id, entity);

            return entity;
        }

        public T Update(T entity)
        {
            _entities.TryUpdate(entity.Id, entity, entity);

            return entity;
        }

        public void Delete(T entity)
        {
            _entities.TryRemove(entity.Id, out _);
        }

        public T Get(Guid id)
        {
            if (_entities.TryGetValue(id, out T entity))
                return entity;

            return null;
        }

        public IEnumerable<T> GetAll(Func<T, bool> predicate)
        {
            return _entities.Values.Where(predicate).ToList();
        }
    }
}
