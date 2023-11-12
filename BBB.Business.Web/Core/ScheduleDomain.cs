using BBB.DataAccess.Repository;
using BBB.Framework.Conversion.Core;
using BBB.Framework.Dto.Core;

namespace BBB.Business.Web.Core
{
    internal sealed class ScheduleDomain : IScheduleDomain
    {
        private IScheduleRepository scheduleRepository;

        public ScheduleDomain(IScheduleRepository raidRepository)
        {
            this.scheduleRepository = raidRepository;
        }

        public void AddSchedule(ScheduleDto dto)
        {
            var schedule = dto.ToEntity();
            scheduleRepository.AddSchedule(schedule);
        }

        public void AddParticipant(ParticipantDto dto)
        {
            var participant = dto.ToEntity();
            scheduleRepository.AddParticipant(participant);
        }

        public async Task<ScheduleDto?> GetScheduleAsync(Guid scheduleKey)
        {
            var schedule = await scheduleRepository.GetScheduleAsync(scheduleKey);
            return schedule?.ToDto();
        }

        public async Task<List<ScheduleDto>> GetSchedulesAsync()
        {
            var schedules = await scheduleRepository.GetSchedulesAsync();
            return schedules.ToDtos();
        }
    }
}
