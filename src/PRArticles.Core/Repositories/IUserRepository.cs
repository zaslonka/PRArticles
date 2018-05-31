using System;
using System.Threading.Tasks;
using PRArticles.Core.Domain;

namespace PRArticles.Core.Repositories
{
    public interface IUserRepository
    {
         Task<User> GetAsync(Guid id);
         Task<User> GetAsync(string email);
         Task AddAsync(User user);
         Task UpdateAsync(User user);
         Task DeleteAsync(User user);
    }
}