using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using PRArticles.Core.Repositories;
using PRArtticles.Infrastructure.DTO;

namespace PRArtticles.Infrastructure.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IMapper _mapper;
        public ArticleService(IArticleRepository articleRepository, IMapper mapper)
        {
            _articleRepository = articleRepository;
            _mapper = mapper;
        }
        public async Task<ArticleDto> GetAsync(Guid id)
        {
           var article = await _articleRepository.GetAsync(id);

           return _mapper.Map<ArticleDto>(article);
        }

        public async Task<ArticleDto> GetAsync(string title)
        {
           var article = await _articleRepository.GetAsync(title);

           return _mapper.Map<ArticleDto>(article);
        }
        public async Task CreateAsync(Guid id, string title, string lead, string content, int categoryId, IEnumerable<int> tags)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Guid id, string title, string lead, string content, int categoryId, IEnumerable<int> tags)
        {
            throw new NotImplementedException();
        }
    }
}