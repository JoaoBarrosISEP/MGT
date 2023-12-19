

using MGT.DTOs;
using MGT.Enums;
using MGT.Models;
using Microsoft.AspNetCore.Mvc;
using Task = MGT.Models.Task;

namespace MGT.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly MgtDbContext _context;

        public TaskController(MgtDbContext context)
        {
            this._context = context;
        }

        [HttpPost("transport-task")]
        public async Task<ActionResult> CreateTask(TaskDto taskDto)
        {
            var task = new Task()
            {
                TaskState = taskDto.TaskState,
                Description = taskDto.Description,
                TaskType = TaskTypeEnum.TRANSPORT_TASK
            };

            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
