using Autofac;
using OA.Infrastructure.Business;
using OA.Infrastructure.Data;
using OA.Infrastructure.Data.Provider;
using OA.Infrastructure.Data.Provider.Interfaces;
using System.Linq;

namespace OA.Infrastructure.DependencyResolver
{
    public static class Configurator
    {
        public static void ConfigureAutofac(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(DbContextProvider<>))
                   .As(typeof(IContextProvider<>))
                   .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(BookRepository).Assembly)
                   .Where(obj => obj.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(BookService).Assembly)
                   .Where(obj => obj.Name.EndsWith("Service"))
                   .AsImplementedInterfaces()
                   .InstancePerLifetimeScope();
        }
    }
}
