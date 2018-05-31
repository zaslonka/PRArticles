using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PRArticles.Core.Domain;
using PRArticles.Core.Repositories;

namespace PRArtticles.Infrastructure.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private static readonly ISet<Article> _articles = new HashSet<Article>();
        public async Task<Article> GetAsync(Guid id)
            => await Task.FromResult(_articles.SingleOrDefault(x => x.Id == id));
        public async Task<Article> GetAsync(string title)
            => await Task.FromResult(_articles.SingleOrDefault(x => x.Title.ToLowerInvariant() == title.ToLowerInvariant()));
        public async Task AddAsync(Article article)
        {
            _articles.Add(article);
            await Task.CompletedTask;
        }
        public async Task DeleteAsync(Article article)
        {
            _articles.Remove(article);
            await Task.CompletedTask;
        }
        public async Task UpdateAsync(Article article)
        {
            await Task.CompletedTask;
        }
    }
}