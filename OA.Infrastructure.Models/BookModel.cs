using System;

namespace OA.Infrastructure.Models
{
    public class BookModel
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
