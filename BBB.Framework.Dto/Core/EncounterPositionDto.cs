namespace BBB.Framework.Dto.Core
{
    public sealed class EncounterPositionDto
    {
        public Guid EncounterPositionKey { get; set; }

        public string Name { get; set; } = string.Empty;

        public int SortOrder { get; set; }

        public string Description { get; set; } = string.Empty;

        public Guid EncounterKey { get; set; }
    }
}
