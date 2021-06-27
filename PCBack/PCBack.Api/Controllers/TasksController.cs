using MediatR;
using Microsoft.AspNetCore.Mvc;
using PCBack.Application.Tasks;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PCBack.Api.Controllers
{
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly ISender mediator;
        public TasksController(ISender mediator) => this.mediator = mediator;

        [HttpGet("[controller]")]
        public async Task<ActionResult<IEnumerable<CompetitionTask>>> Get()
        {
            var tasks = await mediator.Send(new GetTasksQuery());

            return Ok(tasks);
        }
    }
}
