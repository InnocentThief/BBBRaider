using BBB.DataAccess.Entity.Core;
using BBB.Framework.Dto.Core;

namespace BBB.Framework.Conversion.Core
{
    internal static class EncounterConverter
    {
        public static EncounterDto ToDto(this Encounter entity)
        {
            return new EncounterDto
            {
                Positions = entity.Positions.ToDtos(),
                Danger = entity.Danger,
                Description = entity.Description,
                EncounterKey = entity.EncounterKey,
                Fight = entity.Fight,
                Name = entity.Name,
                Preparation = entity.Preparation,
                RaidKey = entity.RaidKey,
                SortOrder = entity.SortOrder
            };
        }

        public static List<EncounterDto> ToDtos(this List<Encounter> entities)
        {
            return entities.Select(ToDto).ToList();
        }
    }
}
