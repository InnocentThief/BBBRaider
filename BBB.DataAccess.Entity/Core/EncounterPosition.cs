using System.ComponentModel.DataAnnotations;

namespace BBB.DataAccess.Entity.Core
{
    internal sealed class EncounterPosition
    {
        [Key]
        public Guid EncounterPositionKey { get; set; }

        public string Name { get; set; } = string.Empty;

        public int SortOrder { get; set; }

        public string Description { get; set; } = string.Empty;

        public Guid EncounterKey { get; set; }

        public Encounter? Encounter { get; set; }
    }
}
