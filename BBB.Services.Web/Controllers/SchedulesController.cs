using BBB.Business.Web;
using BBB.Framework.Dto.Core;
using Microsoft.AspNetCore.Mvc;

namespace BBB.Services.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulesController : ControllerBase
    {
        private IScheduleDomain scheduleDomain;

        public SchedulesController(IScheduleDomain scheduleDomain)
        {
            this.scheduleDomain = scheduleDomain;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetSchedule(Guid id)
        {
            var schedule = await scheduleDomain.GetScheduleAsync(id);
            return Ok(schedule);
        }

        [HttpGet]
        [Route("")]
        public async Task<ActionResult> GetSchedules()
        {
            var schedules = await scheduleDomain.GetSchedulesAsync();
            return Ok(schedules);
        }

        [HttpPost]
        public async Task<ActionResult> AddSchedule(ScheduleDto schedule)
        {
            scheduleDomain.AddSchedule(schedule);
            return Ok();
        }

        [HttpPost]
        [Route("{id}/Participants")]
        public async Task<ActionResult> AddParticipant(ParticipantDto participant)
        {
            scheduleDomain.AddParticipant(participant);
            return Ok();
        }
    }
}
