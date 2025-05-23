using System;

namespace BlazorDashboardDemo.Shared.Models
{
    public class TaskModel
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Project { get; set; } = string.Empty;
        public DateTime Created { get; set; }
    }
}
