using BBB.DataAccess.Entity.Core;
using BBB.Framework.Dto.Core;

namespace BBB.Framework.Conversion.Core
{
    internal static class PlayerConverter
    {
        public static PlayerDto ToDto(this Player entity)
        {
            return new PlayerDto
            {
                Name = entity.Name,
                PlayerKey = entity.PlayerKey,
            };
        }

        public static List<PlayerDto> ToDtos(this List<Player> entities)
        {
            return entities.Select(ToDto).ToList();
        }
    }
}
