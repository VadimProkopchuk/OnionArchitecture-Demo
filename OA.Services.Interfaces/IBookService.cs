using OA.Domain.Core;
using OA.Services.Interfaces.Core;
using System;

namespace OA.Services.Interfaces
{
    public interface IBookService : IBaseService<Guid, Book>
    {
        // other
    }
}
