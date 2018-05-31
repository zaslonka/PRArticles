using System;
using System.Collections.Generic;

namespace PRArticles.Core.Domain
{
    public class Article : Entity
    {
        public string Title {get; protected set;}
        public string Lead {get; protected set;}
        public string Content {get; protected set;}
        public int CategoryId {get; protected set;}
        public IEnumerable<int> Tags {get; protected set;}

        protected Article()
        {

        }

        public Article(Guid id, string title, string lead, string content, int categoryId, IEnumerable<int> tags)
        {
            Id = id;
            Title = title;
            Lead = lead;
            Content = content;
            CategoryId = categoryId;
            Tags = tags;
        }
    }
}