using BBB.DataAccess.Entity.Core;
using BBB.Framework.Dto.Core;

namespace BBB.Framework.Conversion.Core
{
    internal static class ParticipantConverter
    {
        public static ParticipantDto ToDto(this Participant entity)
        {
            return new ParticipantDto
            {
                ParticipantKey = entity.ParticipantKey,
                Player = entity.Player?.ToDto(),
                PlayerKey = entity.PlayerKey,
                ScheduleKey = entity.ScheduleKey
            };
        }

        public static List<ParticipantDto> ToDtos(this List<Participant> entities)
        {
            return entities.Select(ToDto).ToList();
        }

        public static Participant ToEntity(this ParticipantDto dto)
        {
            return new Participant
            {
                EncounterPositions = dto.EncounterPositions.ToEntities(),
                ParticipantKey = dto.ParticipantKey,
                PlayerKey = dto.PlayerKey,
                ScheduleKey = dto.ScheduleKey
            };
        }

        public static List<Participant> ToEntities(this List<ParticipantDto> dtos)
        {
            return dtos.Select(ToEntity).ToList();
        }
    }
}
