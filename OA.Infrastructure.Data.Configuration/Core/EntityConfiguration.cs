using OA.Domain.Core.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace OA.Infrastructure.Data.Configuration.Core
{
    internal static class EntityConfiguration
    {
        public static EntityTypeConfiguration<TEntity> IdentityPrimaryKey<TEntity, TKey>
            (this EntityTypeConfiguration<TEntity> config)
             where TEntity : class, IBaseEntity<TKey>
             where TKey : struct
        {
            config.HasKey(e => e.Id);
            config.Property(e => e.Id)
                  .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            return config;
        }

        public static EntityTypeConfiguration<TEntity> IdentityKey<TEntity, TKey>
           (this EntityTypeConfiguration<TEntity> config)
            where TEntity : class, IBaseEntity<TKey>
            where TKey : struct
        {
            config.Property(x => x.Id)
                  .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            return config;
        }
    }
}
