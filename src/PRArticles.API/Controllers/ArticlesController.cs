using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PRArtticles.Infrastructure.Commands.Articles;
using PRArtticles.Infrastructure.DTO;
using PRArtticles.Infrastructure.Services;

namespace PRArticles.API.Controllers
{
    [Route("api/[controller]")]
    public class ArticlesController : Controller
    {
        private readonly IArticleService _articleService;
        public ArticlesController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet("{title}")]
        public async Task<IActionResult> Get(string title)
        {
           var article = await _articleService.GetAsync(title);

            return Json(article);
        }

        [HttpGet("{articleId}")]
        public async Task<IActionResult> Get(Guid articleId)
        {
           var article = await _articleService.GetAsync(articleId);
           if(article == null)
           {
               return NotFound();
           }

            return Json(article);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateArticle command)
        {
            command.ArticleId = Guid.NewGuid();
            await _articleService.CreateAsync(command.ArticleId,command.Title,command.Lead,command.Content,command.CategoryId,command.Tags);

            return Created($"articles/{command.ArticleId}", null);
        }

        [HttpPut("{articleId}")]
        public async Task<IActionResult> Update(Guid articleId, [FromBody]UpdateArticle command)
        {
            await _articleService.UpdateAsync(articleId,command.Title,command.Lead,command.Content);

            return NoContent();
        }

        [HttpDelete("{articleId}")]
        public async Task<IActionResult> Delete(Guid articleId)
        {
            await _articleService.DeleteAsync(articleId);

            return NoContent();
        }

    }
}