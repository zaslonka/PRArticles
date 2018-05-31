using System;
using System.Collections.Generic;

namespace PRArtticles.Infrastructure.DTO
{
    public class ArticleDto
    {
        public Guid Id {get; set;}
        public string Title {get; set;}
        public string Lead {get; set;}
        public string Content {get; set;}
        public int CategoryId {get; set;}
        public IEnumerable<int> Tags {get; set;}

    }
}