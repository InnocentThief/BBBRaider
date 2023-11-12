using System.ComponentModel.DataAnnotations;

namespace BBB.DataAccess.Entity.Core
{
    internal sealed class EncounterPositionParticipant
    {
        [Key]
        public Guid EncounterPositionParticipantKey { get; set; }

        public Guid EncounterPositionKey { get; set; }

        public EncounterPosition? EncounterPosition { get; set; }

        public Guid ParticipantKey { get; set; }

        public Participant? Participant { get; set; }
    }
}
