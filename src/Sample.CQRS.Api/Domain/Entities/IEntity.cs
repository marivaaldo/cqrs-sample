namespace Sample.CQRS.Api.Domain.Entities
{
    public interface IEntity
    {
        Guid Id { get; }
        DateTime CreatedOn { get; }
    }
}
