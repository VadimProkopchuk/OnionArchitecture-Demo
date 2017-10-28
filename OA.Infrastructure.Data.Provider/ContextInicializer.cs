using OA.Domain.Core;
using System.Data.Entity;

namespace OA.Infrastructure.Data.Provider
{
    internal class ContextInicializer : CreateDatabaseIfNotExists<DbContextProvider>
    {
        protected override void Seed(DbContextProvider context)
        {
            context.Set<Book>().Add(new Book
            {
                Name = "BookName",
                Price = 10.4d
            });

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
