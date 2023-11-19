using System.Threading.Tasks;
using HM32_ASP.net_practice.Models.Db;

namespace HM32_ASP.net_practice.DB.Repository
{
    public interface IBlogRepository
    {
        Task AddUser(User user);
        Task<User[]> GetUser();
    }
}
