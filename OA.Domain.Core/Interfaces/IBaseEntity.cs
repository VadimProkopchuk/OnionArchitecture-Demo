using System;

namespace OA.Domain.Core.Interfaces
{
    public interface IBaseEntity<TKey> where TKey : struct
    {
        TKey Id { get; set; }
        DateTime CreatedOn { get; set; }
        DateTime? ModifiedOn { get; set; }
    }
}
