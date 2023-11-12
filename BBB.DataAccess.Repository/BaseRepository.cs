using BBB.DataAccess.Model.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BBB.DataAccess.Repository
{
    internal abstract class BaseRepository
    {
        protected readonly IDbContextFactory<WebContext> dbContextFactory;

        public BaseRepository(IDbContextFactory<WebContext> dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        protected WebContext GetDatabaseContext()
        {
            return dbContextFactory.CreateDbContext();
        }

        protected Task<WebContext> GetDatabaseContextAsync()
        {
            return dbContextFactory.CreateDbContextAsync();
        }

        protected void Save<TEntity>(TEntity item, Func<WebContext, DbSet<TEntity>> dbCollection, Expression<Func<TEntity, bool>> predicate) where TEntity : class
        {
            using var entities = GetDatabaseContext();
            var original = dbCollection(entities).SingleOrDefault(predicate);
            if (original == null)
            {
                dbCollection(entities).Attach(item);
                entities.Entry(item).State = EntityState.Added;
            }
            else
            {
                entities.Entry(original).CurrentValues.SetValues(item);
            }
            entities.SaveChanges();
        }
    }
}
