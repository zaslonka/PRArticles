using AutoMapper;
using PRArticles.Core.Domain;
using PRArtticles.Infrastructure.DTO;

namespace PRArtticles.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(config =>
            {
                config.CreateMap<Article, ArticleDto>();
            })
            .CreateMapper();
    }
}