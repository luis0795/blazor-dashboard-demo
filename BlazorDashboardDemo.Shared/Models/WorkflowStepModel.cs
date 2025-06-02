namespace BlazorDashboardDemo.Shared.Models;

public class WorkflowStepModel
{
    public string Name { get; set; } = string.Empty;
    public StepType Type { get; set; } = StepType.Custom;
    public bool IsCompleted { get; set; }
}