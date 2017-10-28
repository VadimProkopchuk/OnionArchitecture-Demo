using OA.Domain.Core.Interfaces;
using OA.Domain.Interfaces.Core;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Infrastructure.Business.Core
{
    public abstract class BaseService<TKey, TEntity> where TEntity : class, IBaseEntity<TKey>
                                                     where TKey : struct
    {
        private readonly IBaseRepository<TKey, TEntity> repository;

        public BaseService(IBaseRepository<TKey, TEntity> repository)
        {
            this.repository = repository;
        }

        protected IBaseRepository<TKey, TEntity> Repository => repository;

        public async virtual Task CreateAsync(TEntity entity)
        {
            repository.Add(entity);
            await repository.SaveChangesAsync();
        }

        public virtual TEntity Get(TKey key) => repository.Get(key);

        public virtual IQueryable<TEntity> Get() => repository.Get();

        public async virtual Task UpdateAsync(TEntity entity)
        {
            repository.Update(entity);
            await repository.SaveChangesAsync();
        }

        public async virtual Task RemoveAsync(TEntity entity)
        {
            repository.Remove(entity);
            await repository.SaveChangesAsync();
        }
    }
}
