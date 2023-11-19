using Microsoft.EntityFrameworkCore;
using HM32_ASP.net_practice.Models.Db;

namespace HM32_ASP.net_practice.DB
{
    public class LoggingContext: DbContext
    {
        public DbSet<Request> Requests { get; set; }
        public LoggingContext(DbContextOptions<LoggingContext> options) : base(options) => Database.EnsureCreated();
    }
}
