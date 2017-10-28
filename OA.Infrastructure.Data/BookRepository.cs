using OA.Domain.Core;
using OA.Domain.Interfaces;
using OA.Infrastructure.Data.Core;
using OA.Infrastructure.Data.Provider.Interfaces;
using System;

namespace OA.Infrastructure.Data
{
    public class BookRepository : BaseRepository<Guid, Book>, IBookRepository
    {
        public BookRepository(IContextProvider<Guid> contextProvider) : base(contextProvider) { }
    }
}
