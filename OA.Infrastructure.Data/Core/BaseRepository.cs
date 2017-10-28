using OA.Domain.Core.Interfaces;
using OA.Infrastructure.Data.Provider.Interfaces;
using System;
using System.Data.Entity;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Infrastructure.Data.Core
{
    public abstract class BaseRepository<TKey, TEntity> where TEntity : class, IBaseEntity<TKey>
                                                        where TKey : struct
    {
        private readonly IContextProvider<TKey> contextProvider;
        private readonly DbSet<TEntity> set;


        public BaseRepository(IContextProvider<TKey> contextProvider)
        {
            this.contextProvider = contextProvider;
            this.set = contextProvider.GetSet<TEntity>();
        }

        protected IContextProvider<TKey> ContextProvider => contextProvider;

        private IQueryable<TEntity> Set { get; set; }

        public void Add(TEntity entity)
        {
            Contract.Requires<ArgumentNullException>(entity != null);
            set.Add(entity);
        }

        public IQueryable<TEntity> Get() => set;

        public TEntity Get(TKey key) => set.Find(key);

        public void Remove(TEntity entity)
        {
            Contract.Requires<ArgumentNullException>(entity != null);
            set.Remove(entity);
        }

        public int SaveChanges() => contextProvider.Save();

        public Task<int> SaveChangesAsync() => contextProvider.SaveAsync();

        public void Update(TEntity entity)
        {
            Contract.Requires<ArgumentNullException>(entity != null);
            set.Attach(entity);
        }
    }
}
