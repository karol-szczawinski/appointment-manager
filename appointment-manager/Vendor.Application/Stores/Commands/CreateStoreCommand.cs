using MediatR;

namespace Vendor.Application.Stores.Commands
{
    public class CreateStoreCommand : IRequest
    {
        public string Name { get; set; }
    }
}
