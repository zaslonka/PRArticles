using System;
using System.Threading.Tasks;
using PRArticles.Core.Domain;

namespace PRArticles.Core.Repositories
{
    public interface IArticleRepository
    {
         Task<Article> GetAsync(Guid id);
         Task<Article> GetAsync(string title);
         Task AddAsync(Article article);
         Task UpdateAsync(Article article);
         Task DeleteAsync(Article article);
    }
}