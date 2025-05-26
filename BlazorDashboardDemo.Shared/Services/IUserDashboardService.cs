using BlazorDashboardDemo.Shared.Models;

namespace BlazorDashboardDemo.Shared.Services;

public interface IUserDashboardService
{
    Task<UserDashboardViewModel> GetDashboardDataAsync();
    Task<bool> UpdateTaskAsync(TaskModel task);
    Task<bool> PinTaskAsync(string taskId, bool isPinned);
    Task<bool> ClaimTaskAsync(string taskId);
}