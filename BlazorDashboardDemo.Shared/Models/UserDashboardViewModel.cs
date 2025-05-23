using System.Collections.Generic;

namespace BlazorDashboardDemo.Shared.Models
{
    public class UserDashboardViewModel
    {
        public List<TaskModel> Tasks { get; set; } = new();
    }
}
