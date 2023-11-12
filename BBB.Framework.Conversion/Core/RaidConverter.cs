using BBB.DataAccess.Entity.Core;
using BBB.Framework.Dto.Core;

namespace BBB.Framework.Conversion.Core
{
    internal static class RaidConverter
    {
        public static RaidDto ToDto(this Raid entity)
        {
            return new RaidDto
            {
                Encounters = entity.Encounters.ToDtos(),
                Name = entity.Name,
                RaidKey = entity.RaidKey
            };
        }

        public static List<RaidDto> ToDtos(this List<Raid> entities)
        {
            return entities.Select(ToDto).ToList();
        }
    }
}
