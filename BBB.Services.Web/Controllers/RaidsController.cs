using BBB.Business.Web;
using Microsoft.AspNetCore.Mvc;

namespace BBB.Services.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RaidsController : ControllerBase
    {
        private readonly IRaidDomain raidDomain;

        public RaidsController(IRaidDomain raidDomain)
        {
            this.raidDomain = raidDomain;
        }

        [HttpGet]
        public async Task<ActionResult> GetRaidsAsync()
        {
            return Ok();
        }
    }
}
