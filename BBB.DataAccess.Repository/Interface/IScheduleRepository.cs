using BBB.DataAccess.Entity.Core;

namespace BBB.DataAccess.Repository
{
    internal interface IScheduleRepository
    {
        void AddSchedule(Schedule schedule);

        void AddParticipant(Participant participant);

        Task<Schedule?> GetScheduleAsync(Guid scheduleKey);

        Task<List<Schedule>> GetSchedulesAsync();
    }
}
