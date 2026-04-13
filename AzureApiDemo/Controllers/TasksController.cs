using Microsoft.AspNetCore.Mvc;
using AzureApiDemo.Services;
using AzureApiDemo.Models;

namespace AzureApiDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly TaskService _taskService;

        public TasksController(TaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_taskService.GetAll());
        }

        [HttpPost]
        public IActionResult Post(TaskItem task)
        {
            var created = _taskService.Add(task);
            return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
        }
    }
}