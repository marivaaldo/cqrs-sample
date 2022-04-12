namespace Sample.CQRS.Api.Domain.Commands.Responses
{
    public class CreateProductResponse
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Sku { get; set; }
        public string Name { get; set; }
    }
}
