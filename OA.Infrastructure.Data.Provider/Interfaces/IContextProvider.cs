using OA.Domain.Core.Interfaces;
using System.Data.Entity;
using System.Threading.Tasks;

namespace OA.Infrastructure.Data.Provider.Interfaces
{
    public interface IContextProvider<TKey> where TKey : struct
    {
        DbSet<TEntity> GetSet<TEntity>() where TEntity : class, IBaseEntity<TKey>;
        int Save();
        Task<int> SaveAsync();
    }
}
