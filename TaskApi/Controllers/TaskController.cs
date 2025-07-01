using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TaskApi.DTOs;
using TaskApi.Interfaces;
using TaskApi.Models;

namespace TaskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private static List<TaskItem> tasks = new List<TaskItem>();
        private readonly ITaskService _service;

        public TaskController(ITaskService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetTasks()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetTask(int id)
        {
            var task = _service.GetById(id);
            return task == null ? NotFound() : Ok(task);
        }

        [HttpPost]
        public IActionResult PostTask(CreateTaskDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var task = _service.Create(dto.Title);
            return CreatedAtAction(nameof(GetTask), new { id = task.Id }, task);
        }

        [HttpPut("{id}")]
        public IActionResult PutTask(int id, UpdateTaskDto dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            bool updated = _service.Update(id, dto.Title, dto.IsCompleted);
            return updated ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            bool deleted = _service.Delete(id);
            return deleted ? NoContent() : NotFound();
        }
    }
}
