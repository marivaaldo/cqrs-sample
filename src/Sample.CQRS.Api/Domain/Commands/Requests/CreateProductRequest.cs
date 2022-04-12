namespace Sample.CQRS.Api.Domain.Commands.Requests
{
    public class CreateProductRequest
    {
        public string Sku { get; set; }
        public string Name { get; set; }
    }
}
