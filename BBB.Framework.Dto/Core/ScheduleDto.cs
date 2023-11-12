namespace BBB.Framework.Dto.Core
{
    public sealed class ScheduleDto
    {
        public Guid ScheduleKey { get; set; }

        public DateTime Date { get; set; }

        public int? Duration { get; set; }

        public int PlayerCount { get; set; }

        public Guid RaidLeaderPlayerKey { get; set; }

        public PlayerDto? RaidLeader { get; set; }

        public Guid RaidKey { get; set; }

        public RaidDto? Raid { get; set; }

        public List<ParticipantDto> Participants { get; set; } = new();
    }
}
