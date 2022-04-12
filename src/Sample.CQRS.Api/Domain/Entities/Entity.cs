namespace Sample.CQRS.Api.Domain.Entities
{
    public abstract class Entity : IEntity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
            CreatedOn = DateTime.UtcNow;
        }

        public Guid Id { get; }

        public DateTime CreatedOn { get; }
    }
}
