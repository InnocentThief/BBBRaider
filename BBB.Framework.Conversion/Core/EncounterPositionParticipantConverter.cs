using BBB.DataAccess.Entity.Core;
using BBB.Framework.Dto.Core;

namespace BBB.Framework.Conversion.Core
{
    internal static class EncounterPositionParticipantConverter
    {
        public static EncounterPositionParticipantDto ToDto(this EncounterPositionParticipant entity)
        {
            return new EncounterPositionParticipantDto
            {
                EncounterPositionKey = entity.EncounterPositionKey,
                EncounterPositionParticipantKey = entity.EncounterPositionParticipantKey,
                ParticipantKey = entity.ParticipantKey,
            };
        }

        public static List<EncounterPositionParticipantDto> ToDtos(this List<EncounterPositionParticipant> entities)
        {
            return entities.Select(ToDto).ToList();
        }

        public static EncounterPositionParticipant ToEntity(this EncounterPositionParticipantDto dto)
        {
            return new EncounterPositionParticipant
            {
                EncounterPositionKey = dto.EncounterPositionKey,
                EncounterPositionParticipantKey = dto.EncounterPositionParticipantKey,
                ParticipantKey = dto.ParticipantKey,
            };
        }

        public static List<EncounterPositionParticipant> ToEntities(this List<EncounterPositionParticipantDto> dtos)
        {
            return dtos.Select(ToEntity).ToList();
        }
    }
}
