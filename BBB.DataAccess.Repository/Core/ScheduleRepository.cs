using BBB.DataAccess.Entity.Core;
using BBB.DataAccess.Model.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BBB.DataAccess.Repository.Core
{
    internal sealed class ScheduleRepository : BaseRepository, IScheduleRepository
    {
        public ScheduleRepository(IDbContextFactory<WebContext> dbContextFactory) : base(dbContextFactory)
        {
        }

        public void AddSchedule(Schedule schedule)
        {
            Save(schedule, c => c.Schedule, s => s.ScheduleKey == schedule.ScheduleKey);
        }

        public void AddParticipant(Participant participant)
        {
            Save(participant, c => c.Participant, p => p.ParticipantKey == participant.ParticipantKey);
        }

        public async Task<Schedule?> GetScheduleAsync(Guid scheduleKey)
        {
            await using var entities = await GetDatabaseContextAsync();
            return await entities.Schedule
                .Include(s => s.Participants).ThenInclude(p => p.Player)
                .Include(s => s.Participants).ThenInclude(p => p.EncounterPositions)
                .Include(s => s.Raid!.Encounters).ThenInclude(e => e.Positions)
                .Include(s => s.RaidLeader)
                .SingleOrDefaultAsync(r => r.ScheduleKey == scheduleKey);
        }

        public async Task<List<Schedule>> GetSchedulesAsync()
        {
            await using var entities = await GetDatabaseContextAsync();
            return await entities.Schedule
                .Include(s => s.RaidLeader)
                .Include(s => s.Participants)
                .Include(s => s.Raid)
                .Where(s => s.Date >= DateTime.Today.AddDays(-1))
                .ToListAsync();
        }
    }
}
