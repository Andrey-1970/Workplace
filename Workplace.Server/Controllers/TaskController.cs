using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Workplace.Shared;

namespace Workplace.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private static readonly TaskItemDTO[] tasks = new[]
        {
            new TaskItemDTO() { Id = 1, Name = "Задача 1", Description = "Описание 1"},
            new TaskItemDTO() { Id = 2, Name = "Задача 2", Description = "Описание 2"},
            new TaskItemDTO() { Id = 3, Name = "Задача 3", Description = "Описание 3"},

        };

        private readonly ILogger<TaskController> _logger;

        public TaskController(ILogger<TaskController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "tasks")]
        public async Task<IEnumerable<TaskItemDTO>> Get()
        {
            return await Task.FromResult(tasks);
        }
    }
}
