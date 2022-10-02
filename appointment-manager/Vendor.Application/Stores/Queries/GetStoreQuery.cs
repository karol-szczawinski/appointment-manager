using Core.Model.Entities.Business;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendor.Application.Stores.Queries
{
    public class GetStoreQuery : IRequest<Store>
    {
    }
}
