using BBB.DataAccess.Entity.Core;
using BBB.Framework.Dto.Core;

namespace BBB.Framework.Conversion.Core
{
    internal static class ScheduleConverter
    {
        public static ScheduleDto ToDto(this Schedule entity)
        {
            return new ScheduleDto
            {
                Date = entity.Date,
                Duration = entity.Duration,
                Participants = entity.Participants.ToDtos(),
                PlayerCount = entity.Participants.Count,
                Raid = entity.Raid?.ToDto(),
                RaidKey = entity.RaidKey,
                RaidLeader = entity.RaidLeader?.ToDto(),
                RaidLeaderPlayerKey = entity.RaidLeaderPlayerKey,
                ScheduleKey = entity.ScheduleKey
            };
        }

        public static List<ScheduleDto> ToDtos(this List<Schedule> entities)
        {
            return entities.Select(ToDto).ToList();
        }

        public static Schedule ToEntity(this ScheduleDto dto)
        {
            return new Schedule
            {
                Date = dto.Date,
                Duration = dto.Duration,
                RaidKey = dto.RaidKey,
                RaidLeaderPlayerKey = dto.RaidLeaderPlayerKey,
                ScheduleKey = dto.ScheduleKey
            };
        }
    }
}
