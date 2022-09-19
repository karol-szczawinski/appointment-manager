using Microsoft.AspNetCore.Mvc;

namespace Vendor.Api.Controllers
{
    [Route("[controller]/[action]")]
    public class StoreController: ControllerBase
    {
        [HttpGet]
        public IActionResult MyStore()
        {
            return Ok("success");
        }
    }
}
