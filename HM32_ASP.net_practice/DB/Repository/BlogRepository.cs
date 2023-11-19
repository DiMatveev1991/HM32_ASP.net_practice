using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using HM32_ASP.net_practice.Models.Db;

namespace HM32_ASP.net_practice.DB.Repository
{
    public class BlogRepository : IBlogRepository
    {
        private BlogContext _blogContext;
        public BlogRepository(BlogContext context)
        {
            _blogContext = context;
        }
        public async Task AddUser(User user)
        {
            var entry = _blogContext.Entry(user);
            if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Detached)
            {
                await _blogContext.Users.AddAsync(user);
            }

            await _blogContext.SaveChangesAsync();
        }

        public async Task<User[]> GetUser()=> await _blogContext.Users.ToArrayAsync();
        
    }
}
