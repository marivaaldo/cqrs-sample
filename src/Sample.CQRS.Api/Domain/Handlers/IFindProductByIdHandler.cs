using Sample.CQRS.Api.Domain.Queries.Requests;
using Sample.CQRS.Api.Domain.Queries.Responses;

namespace Sample.CQRS.Api.Domain.Handlers
{
    public interface IFindProductByIdHandler
    {
        FindProductByIdResponse Handle(FindProductByIdRequest query);
    }
}
