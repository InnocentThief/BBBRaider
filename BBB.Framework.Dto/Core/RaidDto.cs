namespace BBB.Framework.Dto.Core
{
    public sealed class RaidDto
    {
        public Guid RaidKey { get; set; }

        public string Name { get; set; } = string.Empty;

        public List<EncounterDto> Encounters { get; set; } = new();
    }
}
