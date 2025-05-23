using System.Threading.Tasks;
using BlazorDashboardDemo.Shared.Models;

namespace BlazorDashboardDemo.Shared.Services
{
    public interface IUserDashboardService
    {
        Task<UserDashboardViewModel> GetDashboardAsync(string clientId, string userId);
    }
}
