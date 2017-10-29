using Autofac;
using Microsoft.Owin;
using OA.Infrastructure.DependencyResolver;
using OA.Infrastructure.Mapper;
using Owin;
using System.Reflection;
using System.Web.Http;
using Autofac.Integration.WebApi;

[assembly: OwinStartupAttribute(typeof(OA.WebApi.Startup))]
namespace OA.WebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var builder = new ContainerBuilder();

            Configurator.ConfigureAutofac(builder);
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(builder.Build());

            ApplicationMapper.Configure();
        }
    }
}