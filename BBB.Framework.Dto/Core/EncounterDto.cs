namespace BBB.Framework.Dto.Core
{
    public sealed class EncounterDto
    {
        public Guid EncounterKey { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string? Preparation { get; set; }

        public string? Fight { get; set; }

        public string? Danger { get; set; }

        public int SortOrder { get; set; }

        public Guid RaidKey { get; set; }

        public List<EncounterPositionDto> Positions { get; set; } = new();
    }
}
