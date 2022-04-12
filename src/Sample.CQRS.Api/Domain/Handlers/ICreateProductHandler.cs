using Sample.CQRS.Api.Domain.Commands.Requests;
using Sample.CQRS.Api.Domain.Commands.Responses;

namespace Sample.CQRS.Api.Domain.Handlers
{
    public interface ICreateProductHandler
    {
        CreateProductResponse Handle(CreateProductRequest command);
    }
}
