namespace Sample.CQRS.Api.Domain.Entities
{
    public class Product : Entity
    {
        public Product(string sku, string name)
        {
            Sku = sku;
            Name = name;

            var list = new List<Product>();
        }

        public string Sku { get; }
        public string Name { get; }
    }
}
