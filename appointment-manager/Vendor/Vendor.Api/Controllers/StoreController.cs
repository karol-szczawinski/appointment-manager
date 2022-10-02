using Core.Model.Entities.Business;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.NetworkInformation;
using Vendor.Application.Stores.Commands;
using Vendor.Application.Stores.Queries;

namespace Vendor.WebApi.Controllers
{
    [Route("[controller]/[action]")]
    public class StoreController: ControllerBase
    {
        private IMediator _mediator;

        public StoreController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> MyStore()
        {
           var result = await _mediator.Send(new GetStoreQuery());

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStore(Store newStore)
        {
            var result = await _mediator.Send(new CreateStoreCommand { Name = newStore.Name });

            return Ok("created");
        }
    }
}
