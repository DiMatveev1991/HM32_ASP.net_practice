using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using HM32_ASP.net_practice.DB.LoggingRepository;

namespace HM32_ASP.net_practice.Controllers
{
    public class LogsController : Controller
    {
        private ILoggingRepository _loggingRepository;

        public LogsController(ILoggingRepository loggingRepository)
        {
            _loggingRepository = loggingRepository;
        }
        public async Task<IActionResult> Index()
        {
            var requests = await _loggingRepository.GetRequests();
            return View(requests);
        }
    }
}
