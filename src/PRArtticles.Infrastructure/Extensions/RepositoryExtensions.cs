using System;
using System.Threading.Tasks;
using PRArticles.Core.Domain;
using PRArticles.Core.Repositories;

namespace PRArtticles.Infrastructure.Extensions
{
    public static class RepositoryExtensions
    {
        public static async Task<Article> ExistsOrNotAsync(this IArticleRepository repository, string title)
        {
            var article = await repository.GetAsync(title);
            if(article != null)
            {
                throw new Exception($"Article with id: '{article.Id}' already exists.");
            }

            return article;
        }

        public static async Task<Article> ExistsOrNotAsync(this IArticleRepository repository, Guid id)
        {
            var article = await repository.GetAsync(id);
            if(article == null)
            {
                throw new Exception($"Article with id: '{article.Id}' does not exists.");
            }

            return article;
        }
    }
}