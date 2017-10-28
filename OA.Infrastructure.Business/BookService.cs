using OA.Domain.Core;
using OA.Domain.Interfaces;
using OA.Infrastructure.Business.Core;
using OA.Services.Interfaces;
using System;

namespace OA.Infrastructure.Business
{
    public class BookService : BaseService<Guid, Book>, IBookService
    {
        private readonly IBookRepository bookRepository;

        public BookService(IBookRepository bookRepository) : base(bookRepository)
        {

        }
    }
}
