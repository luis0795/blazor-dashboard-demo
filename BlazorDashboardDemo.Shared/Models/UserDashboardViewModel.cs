namespace BlazorDashboardDemo.Shared.Models;

public class UserDashboardViewModel
{
    public List<TaskModel> Tasks { get; set; } = new();
    public string CurrentUserId { get; set; } = string.Empty;

    public IEnumerable<TaskModel> PinnedTasks => Tasks.Where(t => t.IsPinned);

    public IEnumerable<TaskModel> WhatsNextTasks => Tasks
        .Where(t => !t.IsPinned && string.IsNullOrEmpty(t.AssignedUserId))
        .OrderBy(t => t.CreatedDate);
}