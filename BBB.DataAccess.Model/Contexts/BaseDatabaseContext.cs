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

        }

        protected virtual void CreateUniqueIndexes(ModelBuilder modelBuilder)
        {

        }
    }
}
