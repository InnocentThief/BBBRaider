namespace BBB.Framework.Dto.Core
{
    public sealed class ParticipantDto
    {
        public Guid ParticipantKey { get; set; }

        public Guid PlayerKey { get; set; }

        public PlayerDto? Player { get; set; }

        public Guid ScheduleKey { get; set; }

        public List<EncounterPositionParticipantDto> EncounterPositions { get; set; } = new();
    }
}
