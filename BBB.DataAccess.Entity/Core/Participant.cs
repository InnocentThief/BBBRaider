using System.ComponentModel.DataAnnotations;

namespace BBB.DataAccess.Entity.Core
{
    internal sealed class Participant
    {
        [Key]
        public Guid ParticipantKey { get; set; }

        public Guid PlayerKey { get; set; }

        public Guid ScheduleKey { get; set; }

        public Schedule? Schedule { get; set; }

        public Player? Player { get; set; }

        public List<EncounterPositionParticipant> EncounterPositions { get; set; } = new();          
    }
}
