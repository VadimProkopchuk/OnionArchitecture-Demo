using OA.Domain.Core;
using OA.Infrastructure.Mapper;
using OA.Infrastructure.Models;
using OA.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;

namespace OA.WebApi.Controllers
{
    public class BookController : ApiController
    {
        private readonly IBookService bookService;

        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet]
        [ResponseType(typeof(List<BookModel>))]
        public IHttpActionResult Get()
        {
            var books = bookService.Get().ToList();
            var model = ApplicationMapper.Map<List<Book>, List<BookModel>>(books);

            return Ok(model);
        }
    }
}
