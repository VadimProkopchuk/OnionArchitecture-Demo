using OA.Domain.Core.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Services.Interfaces.Core
{
    public interface IBaseService<TKey, TEntity> where TEntity : class, IBaseEntity<TKey>
                                                 where TKey : struct
    {
        Task CreateAsync(TEntity entity);
        TEntity Get(TKey key);
        IQueryable<TEntity> Get();
        Task UpdateAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);
    }
}
