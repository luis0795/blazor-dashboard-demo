namespace BlazorDashboardDemo.Shared.Models;

public class TaskModel
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }
    public string ProjectName { get; set; } = string.Empty;
    public string? AssignedUserId { get; set; }
    public bool IsPinned { get; set; }
    public string? WorkflowName { get; set; }
    public List<string> AssetNames { get; set; } = new();

    // New WorkflowInstance property
    public WorkflowInstanceModel? WorkflowInstance { get; set; }

}