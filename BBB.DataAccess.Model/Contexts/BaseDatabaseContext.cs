using BBB.DataAccess.Entity.Core;
using Microsoft.EntityFrameworkCore;

namespace BBB.DataAccess.Model.Contexts
{
    internal abstract class BaseDatabaseContext : DbContext
    {
        public BaseDatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CreateRelationshipDefinitions(modelBuilder);
            CreateUniqueIndexes(modelBuilder);
        }

        protected virtual void CreateRelationshipDefinitions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Encounter>().HasOne(e => e.Raid).WithMany(r => r.Encounters).HasForeignKey(e => e.RaidKey);
            modelBuilder.Entity<EncounterPosition>().HasOne(ep => ep.Encounter).WithMany(e => e.Positions).HasForeignKey(ep => ep.EncounterKey);
            modelBuilder.Entity<EncounterPositionParticipant>().HasOne(pep => pep.EncounterPosition).WithMany().HasForeignKey(pep => pep.EncounterPositionKey);
            modelBuilder.Entity<EncounterPositionParticipant>().HasOne(pep => pep.Participant).WithMany(rp => rp.EncounterPositions).HasForeignKey(pep => pep.ParticipantKey);
            modelBuilder.Entity<Participant>().HasOne(p => p.Schedule).WithMany(r => r.Participants).HasForeignKey(rp => rp.ScheduleKey);
            modelBuilder.Entity<Participant>().HasOne(rp => rp.Player).WithMany().HasForeignKey(rp => rp.PlayerKey);
            modelBuilder.Entity<Schedule>().HasOne(s => s.RaidLeader).WithMany().HasForeignKey(s => s.RaidLeaderPlayerKey);
            modelBuilder.Entity<Schedule>().HasOne(s => s.Raid).WithMany().HasForeignKey(s => s.RaidKey);
        }

        protected virtual void CreateUniqueIndexes(ModelBuilder modelBuilder)
        {

        }
    }
}
