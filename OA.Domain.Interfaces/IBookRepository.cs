using OA.Domain.Core;
using OA.Domain.Interfaces.Core;
using System;

namespace OA.Domain.Interfaces
{
    public interface IBookRepository : IBaseRepository<Guid, Book>
    {
        // other 
    }
}
