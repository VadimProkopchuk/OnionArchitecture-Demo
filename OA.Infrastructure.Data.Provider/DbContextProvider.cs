using OA.Infrastructure.Data.Provider.Interfaces;
using OA.Infrastructure.Data.Configuration;
using OA.Domain.Core.Interfaces;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Infrastructure.Data.Provider
{
    public class DbContextProvider<TKey> : DbContext, IContextProvider<TKey> where TKey : struct
    {
        static DbContextProvider()
        {
            Database.SetInitializer(new ContextInicializer());
        }

        public DbContextProvider() : base("ConnectionName") { }

        public DbSet<TEntity> GetSet<TEntity>() where TEntity : class, IBaseEntity<TKey> => base.Set<TEntity>();

        public int Save()
        {
            TimeStamp();
            return base.SaveChanges();
        }

        public Task<int> SaveAsync()
        {
            TimeStamp();
            return base.SaveChangesAsync();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new BookConfiguration());
        }

        private void TimeStamp()
        {
            foreach (var entity in ChangeTracker.Entries().Where(e => e.Entity is IBaseEntity<TKey>))
            {
                var changeEntity = (IBaseEntity<TKey>)entity.Entity;

                switch (entity.State)
                {
                    case EntityState.Added:
                        changeEntity.CreatedOn = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        changeEntity.ModifiedOn = DateTime.Now;
                        break;
                }
            }
        }
    }
}
