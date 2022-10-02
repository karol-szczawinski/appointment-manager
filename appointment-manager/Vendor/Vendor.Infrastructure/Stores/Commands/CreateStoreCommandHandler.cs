using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vendor.Application.Stores.Commands;

namespace Vendor.Infrastructure.Stores.Commands
{
    internal class CreateStoreCommandHandler : IRequestHandler<CreateStoreCommand>
    {
        public Task<Unit> Handle(CreateStoreCommand request, CancellationToken cancellationToken)
        {
            return Unit.Task;
        }
    }
}
