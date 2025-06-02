using BlazorDashboardDemo.Shared.Models;
using BlazorDashboardDemo.Shared.Services;

namespace BlazorDashboardDemo.Client.Services;

public class UserDashboardService : IUserDashboardService
{
    private readonly List<TaskModel> _tasks;
    private readonly string _currentUserId = "current-user";

    public UserDashboardService()
    {
        _tasks = new List<TaskModel>
{
    new()
    {
        Id = "1",
        Name = "Review Project Documentation",
        CreatedDate = DateTime.Now.AddDays(-1),
        ProjectName = "Demo Project",
        IsPinned = true,
        WorkflowName = "Documentation",
        AssetNames = new List<string> { "Document A" },
        WorkflowInstance = new WorkflowInstanceModel
        {
            Name = "Documentation Workflow",
            StepsCompleted = 2,
            StepsTotal = 5,
            State = WorkflowInstanceState.InProgress,
            Steps = new List<WorkflowStepModel>
            {
                new() { Name = "Initial Review", Type = StepType.Review, IsCompleted = true },
                new() { Name = "Approval", Type = StepType.Approval, IsCompleted = true },
                new() { Name = "Final Review", Type = StepType.Review, IsCompleted = false },
                new() { Name = "Execution", Type = StepType.Execution, IsCompleted = false },
                new() { Name = "Notification", Type = StepType.Notification, IsCompleted = false }
            }
        }
    },
    new()
    {
        Id = "2",
        Name = "Update Dashboard Features",
        CreatedDate = DateTime.Now.AddDays(-2),
        ProjectName = "Demo Project",
        WorkflowName = "Development",
        AssetNames = new List<string> { "Dashboard Component" },
        WorkflowInstance = new WorkflowInstanceModel
        {
            Name = "Development Workflow",
            StepsCompleted = 3,
            StepsTotal = 3,
            State = WorkflowInstanceState.Completed,
            Steps = new List<WorkflowStepModel>
            {
                new() { Name = "Feature Design", Type = StepType.Execution, IsCompleted = true },
                new() { Name = "Code Implementation", Type = StepType.Execution, IsCompleted = true },
                new() { Name = "Testing", Type = StepType.Review, IsCompleted = true }
            }
        }
    }
};
    }

    public async Task<UserDashboardViewModel> GetDashboardDataAsync()
    {
        await Task.Delay(500); // Simulate API delay
        return new UserDashboardViewModel
        {
            Tasks = _tasks.ToList(),
            CurrentUserId = _currentUserId
        };
    }

    public async Task<bool> UpdateTaskAsync(TaskModel task)
    {
        var existingTask = _tasks.FirstOrDefault(t => t.Id == task.Id);
        if (existingTask != null)
        {
            existingTask.Name = task.Name;
            existingTask.ProjectName = task.ProjectName;
            existingTask.AssignedUserId = task.AssignedUserId;
            existingTask.IsPinned = task.IsPinned;
            return true;
        }
        return false;
    }

    public async Task<bool> PinTaskAsync(string taskId, bool isPinned)
    {
        var task = _tasks.FirstOrDefault(t => t.Id == taskId);
        if (task != null)
        {
            task.IsPinned = isPinned;
            return true;
        }
        return false;
    }

    public async Task<bool> ClaimTaskAsync(string taskId)
    {
        var task = _tasks.FirstOrDefault(t => t.Id == taskId);
        if (task != null)
        {
            task.AssignedUserId = _currentUserId;
            return true;
        }
        return false;
    }
}