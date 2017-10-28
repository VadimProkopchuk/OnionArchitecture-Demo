using OA.Domain.Core;
using OA.Infrastructure.Data.Configuration.Core;
using System.Data.Entity.ModelConfiguration;
using System;

namespace OA.Infrastructure.Data.Configuration
{
    public class BookConfiguration : EntityTypeConfiguration<Book>
    {
        public BookConfiguration()
        {
            this.IdentityPrimaryKey<Book, Guid>();

            this.Property(x => x.Name).IsRequired();
            this.Property(x => x.Price).IsRequired();

            this.Map(x => x.MapInheritedProperties());
            this.ToTable("Books");
        }
    }
}
