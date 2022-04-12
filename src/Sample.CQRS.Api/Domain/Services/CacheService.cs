using Sample.CQRS.Api.Domain.Entities;
using System.Collections.Concurrent;

namespace Sample.CQRS.Api.Domain.Services
{
    public class CacheService : ICacheService
    {
        private readonly ConcurrentDictionary<string, Dictionary<Guid, IEntity>> _cache = new();

        T ICacheService.Get<T>(Guid id)
        {
            if (_cache.TryGetValue(typeof(T).FullName, out var entities) &&
                entities.TryGetValue(id, out var result))
            {
                return result as T;
            }

            return null;
        }

        void ICacheService.Save<T>(T entity)
        {
            var entities = _cache.GetOrAdd(typeof(T).FullName, new Dictionary<Guid, IEntity>());

            entities[entity.Id] = entity;
        }
    }
}
