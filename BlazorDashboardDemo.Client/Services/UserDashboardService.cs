using System.Threading.Tasks;
using BlazorDashboardDemo.Shared.Models;
using BlazorDashboardDemo.Shared.Services;

namespace BlazorDashboardDemo.Client.Services
{
    public class UserDashboardService : IUserDashboardService
    {
        public async Task<UserDashboardViewModel> GetDashboardAsync(string clientId, string userId)
        {
            // For demo/portfolio: return mock data
            await Task.Delay(200); // Simulate async
            return new UserDashboardViewModel
            {
                Tasks = new List<TaskModel>
                {
                    new TaskModel { Id = "1", Name = "Demo Task 1", Project = "Demo Project", Created = DateTime.Now.AddDays(-2) },
                    new TaskModel { Id = "2", Name = "Demo Task 2", Project = "Demo Project", Created = DateTime.Now.AddDays(-1) }
                }
            };
        }
    }
}
