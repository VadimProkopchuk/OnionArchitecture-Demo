using AutoMapper;
using OA.Infrastructure.Mapper.Maps;

namespace OA.Infrastructure.Mapper
{
    public static class ApplicationMapper
    {
        public static void Configure()
        {
            AutoMapper.Mapper.Initialize(InicializeMapper);
        }

        public static TDestination Map<TSource, TDestination>(this TSource source) =>
            AutoMapper.Mapper.Map<TSource, TDestination>(source);

        private static void InicializeMapper(IMapperConfigurationExpression config)
        {
            BookMap.Configure(config);
        }
    }
}
