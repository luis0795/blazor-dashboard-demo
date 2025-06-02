namespace BlazorDashboardDemo.Shared.Models;

public class WorkflowInstanceModel
{
    public string Name { get; set; } = string.Empty;
    public int StepsCompleted { get; set; }
    public int StepsTotal { get; set; }
    public WorkflowInstanceState State { get; set; } = WorkflowInstanceState.Waiting;
    public List<WorkflowStepModel> Steps { get; set; } = new();
    public StepType? FirstStepType => Steps.FirstOrDefault()?.Type;


}