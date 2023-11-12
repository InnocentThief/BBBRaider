using System.ComponentModel.DataAnnotations;

namespace BBB.DataAccess.Entity.Core
{
    internal sealed class Schedule

    {
        [Key]
        public Guid ScheduleKey { get; set; }

        public DateTime Date { get; set; }

        public int? Duration {  get; set; }

        public Guid RaidLeaderPlayerKey { get; set; }

        public Player? RaidLeader { get; set; }

        public Guid RaidKey { get; set; }

        public Raid? Raid { get; set; }

        public List<Participant> Participants { get; set; } = new();
    }
}
