namespace BBB.Framework.Dto.Core
{
    public sealed class EncounterPositionParticipantDto
    {
        public Guid EncounterPositionParticipantKey { get; set; }

        public Guid EncounterPositionKey { get; set; }

        public Guid ParticipantKey { get; set; }
    }
}
