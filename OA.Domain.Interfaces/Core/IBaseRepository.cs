using OA.Domain.Core.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Domain.Interfaces.Core
{
    public interface IBaseRepository<TKey, TEntity> where TEntity : IBaseEntity<TKey> where TKey : struct
    {
        void Add(TEntity entity);
        TEntity Get(TKey key);
        IQueryable<TEntity> Get();
        void Update(TEntity entity);
        void Remove(TEntity entity);
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
