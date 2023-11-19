using System.Threading.Tasks;
using HM32_ASP.net_practice.Models.Db;

namespace HM32_ASP.net_practice.DB.LoggingRepository
{
    public interface ILoggingRepository
    {
        Task AddRequest(Request request);
        Task<Request[]> GetRequests();
    }
}
