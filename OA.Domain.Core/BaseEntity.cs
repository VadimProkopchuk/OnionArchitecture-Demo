using OA.Domain.Core.Interfaces;
using System;

namespace OA.Domain.Core
{
    public class BaseEntity<TKey> : IBaseEntity<TKey> where TKey : struct
    {
        public TKey Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }
}
