using System;

namespace OA.Domain.Core
{
    public class Book : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
