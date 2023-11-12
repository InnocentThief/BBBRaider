using BBB.Framework.Dto.Core;

namespace BBB.Business.Web
{
    public interface IScheduleDomain
    {
        void AddSchedule(ScheduleDto schedule);

        void AddParticipant(ParticipantDto participant);

        Task<ScheduleDto?> GetScheduleAsync(Guid scheduleKey);

        Task<List<ScheduleDto>> GetSchedulesAsync();
    }
}
