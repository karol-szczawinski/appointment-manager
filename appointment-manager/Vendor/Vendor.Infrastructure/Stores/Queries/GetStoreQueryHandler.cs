using MediatR;
using Vendor.Application.Stores.Queries;
using Core.Model.Entities.Business;

namespace Vendor.Infrastructure.Stores.Queries
{
    public class GetStoreQueryHandler : IRequestHandler<GetStoreQuery, Store>
    {
        public Task<Store> Handle(GetStoreQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new Store { Name = "Test" });
        }
    }
}
