using System.ComponentModel.DataAnnotations;

namespace BBB.DataAccess.Entity.Core
{
    internal sealed class Raid
    {
        [Key]
        public Guid RaidKey { get; set; }

        public string Name { get; set; } = string.Empty;

        public List<Encounter> Encounters { get; set; } = new();
    }
}
