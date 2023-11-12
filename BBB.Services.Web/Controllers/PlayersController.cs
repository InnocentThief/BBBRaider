using BBB.Business.Web;
using Microsoft.AspNetCore.Mvc;

namespace BBB.Services.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerDomain playerDomain;

        public PlayersController(IPlayerDomain playerDomain)
        {
            this.playerDomain = playerDomain;
        }

        [HttpGet]
        public async Task<ActionResult> GetPlayersAsync()
        {
            var players = await playerDomain.GetPlayersAsync();
            return Ok(players);
        }
    }
}
