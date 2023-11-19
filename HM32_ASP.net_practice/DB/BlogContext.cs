using Microsoft.EntityFrameworkCore;
using HM32_ASP.net_practice.Models.Db;

namespace HM32_ASP.net_practice.DB
{
    public class BlogContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserPost> UserPosts { get; set; }

        public BlogContext(DbContextOptions<BlogContext> options) : base(options) => Database.EnsureCreated();
    }
}
