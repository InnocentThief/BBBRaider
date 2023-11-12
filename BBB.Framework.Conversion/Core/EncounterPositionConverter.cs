using BBB.DataAccess.Entity.Core;
using BBB.Framework.Dto.Core;

namespace BBB.Framework.Conversion.Core
{
    internal static class EncounterPositionConverter
    {
        public static EncounterPositionDto ToDto(this EncounterPosition entity)
        {
            return new EncounterPositionDto
            {
                Description = entity.Description,
                EncounterKey = entity.EncounterKey,
                EncounterPositionKey = entity.EncounterPositionKey,
                Name = entity.Name,
                SortOrder = entity.SortOrder,
            };
        }

        public static List<EncounterPositionDto> ToDtos(this List<EncounterPosition> entities)
        {
            return entities.Select(ToDto).ToList();
        }
    }
}
