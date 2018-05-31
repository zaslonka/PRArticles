using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PRArtticles.Infrastructure.DTO;

namespace PRArtticles.Infrastructure.Services
{
    public interface IArticleService
    {
         Task<ArticleDto> GetAsync(Guid id);
         Task<ArticleDto> GetAsync(string title);
         Task CreateAsync(Guid id, string title, string lead, string content, int categoryId, IEnumerable<int> tags);
         Task UpdateAsync(Guid id, string title, string lead, string content, int categoryId, IEnumerable<int> tags);
         Task DeleteAsync(Guid id);
    }
}