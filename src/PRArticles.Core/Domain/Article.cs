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
            UpdateTitle(title);
            UpdateLead(lead);
            UpdateContent(content);
            CategoryId = categoryId;
            Tags = tags;
        }

        public void UpdateTitle(string title)
        {
            if(string.IsNullOrWhiteSpace(title))
            {
                throw new Exception($"Article with id: '{Id}' can not have an empty title");
            }

            Title = title;
        }

        public void UpdateLead(string lead)
        {
            if(string.IsNullOrWhiteSpace(lead))
            {
                throw new Exception($"Article with id: '{Id}' can not have an empty lead");
            }

            Lead = lead;
        }

        public void UpdateContent(string content)
        {
            if(string.IsNullOrWhiteSpace(content))
            {
                throw new Exception($"Article with id: '{Id}' can not have an empty content");
            }

            Content = content;
        }
    }
}