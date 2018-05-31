using System;
using System.Collections.Generic;

namespace PRArtticles.Infrastructure.Commands.Articles
{
    public class CreateArticle
    {
        public Guid ArticleId {get; set;}
        public string Title {get; set;}
        public string Lead {get; set;}
        public string Content {get; set;}
        public int CategoryId {get; set;}
        public IEnumerable<int> Tags {get; set;}
    }
}