using BlazorDashboardDemo.Shared.Models;
using BlazorDashboardDemo.Shared.Services;
using System;

public class UserDashboardService : IUserDashboardService
{
    private readonly List<TaskModel> _tasks;
    private readonly string _currentUserId = "current-user";

    public UserDashboardService()
    {
        _tasks = GenerateSampleTasks(10); // Generate 10 sample tasks
    }

    private List<TaskModel> GenerateSampleTasks(int count)
    {
        var random = new Random();
        var sampleTasks = new List<TaskModel>();

        for (int i = 1; i <= count; i++)
        {
            var taskId = i.ToString();
            var isPinned = random.Next(0, 2) == 1; // Randomly pin some tasks
            var stepsCompleted = random.Next(0, 5);
            var stepsTotal = random.Next(stepsCompleted, 6); // Ensure stepsCompleted <= stepsTotal

            sampleTasks.Add(new TaskModel
            {
                Id = taskId,
                Name = $"Task {taskId}",
                CreatedDate = DateTime.Now.AddDays(-random.Next(1, 30)), // Random date in the past 30 days
                ProjectName = $"Project {random.Next(1, 5)}", // Random project name
                IsPinned = isPinned,
                WorkflowName = $"Workflow {random.Next(1, 3)}",
                AssetNames = new List<string> { $"Asset {random.Next(1, 10)}" },
                WorkflowInstance = new WorkflowInstanceModel
                {
                    Name = $"Workflow {taskId}",
                    StepsCompleted = stepsCompleted,
                    StepsTotal = stepsTotal,
                    State = stepsCompleted == stepsTotal
                        ? WorkflowInstanceState.Completed
                        : WorkflowInstanceState.InProgress,
                    Steps = GenerateSampleSteps(stepsTotal, stepsCompleted)
                }
            });
        }

        return sampleTasks;
    }

    private List<WorkflowStepModel> GenerateSampleSteps(int totalSteps, int completedSteps)
    {
        var steps = new List<WorkflowStepModel>();
        var stepTypes = Enum.GetValues<StepType>();
        for (int i = 0; i < totalSteps; i++)
        {
            steps.Add(new WorkflowStepModel
            {
                Name = $"Step {i + 1}",
                Type = stepTypes[i % stepTypes.Length], // Cycle through StepType enum values
                IsCompleted = i < completedSteps
            });
        }
        return steps;
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
            await Task.CompletedTask; // Explicitly mark as asynchronous
            return true;
        }
        await Task.CompletedTask; // Explicitly mark as asynchronous
        return false;
    }

    public async Task<bool> PinTaskAsync(string taskId, bool isPinned)
    {
        var task = _tasks.FirstOrDefault(t => t.Id == taskId);
        if (task != null)
        {
            task.IsPinned = isPinned;
            await Task.CompletedTask; // Explicitly mark as asynchronous
            return true;
        }
        await Task.CompletedTask; // Explicitly mark as asynchronous
        return false;
    }

    public async Task<bool> ClaimTaskAsync(string taskId)
    {
        var task = _tasks.FirstOrDefault(t => t.Id == taskId);
        if (task != null)
        {
            task.AssignedUserId = _currentUserId;
            await Task.CompletedTask; // Explicitly mark as asynchronous
            return true;
        }
        await Task.CompletedTask; // Explicitly mark as asynchronous
        return false;
    }
}