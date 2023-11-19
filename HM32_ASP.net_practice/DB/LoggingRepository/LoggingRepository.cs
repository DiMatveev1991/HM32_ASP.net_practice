using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using HM32_ASP.net_practice.Models.Db;

namespace HM32_ASP.net_practice.DB.LoggingRepository
{
    public class LoggingRepository : ILoggingRepository
    {
        private LoggingContext _LoggingContext;

        public LoggingRepository(LoggingContext LoggingContext)
        {
            _LoggingContext = LoggingContext;
        }
        public async Task AddRequest(Request request)
        {
            var entry = _LoggingContext.Entry(request);
            if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Detached)
            {
                await _LoggingContext.Requests.AddAsync(request);
            }

            await _LoggingContext.SaveChangesAsync();
        }
        public async Task<Request[]> GetRequests() => await _LoggingContext.Requests.ToArrayAsync();       
    }
}
