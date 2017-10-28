using AutoMapper;
using OA.Domain.Core;
using OA.Infrastructure.Models;

namespace OA.Infrastructure.Mapper.Maps
{
    internal static class BookMap
    {
        public static void Configure(IMapperConfigurationExpression config)
        {
            config.CreateMap<Book, BookModel>();
            config.CreateMap<BookModel, Book>()
                .ForMember(x => x.Id, opt => opt.Ignore());
        }
    }
}
