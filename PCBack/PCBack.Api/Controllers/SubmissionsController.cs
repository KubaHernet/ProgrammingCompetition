using MediatR;
using Microsoft.AspNetCore.Mvc;
using PCBack.Application.Features.Submissions;
using System.Threading.Tasks;

namespace PCBack.Api.Controllers
{
    [ApiController]
    public class SubmissionsController : ControllerBase
    {
        private readonly ISender mediator;

        public SubmissionsController(ISender mediator) => this.mediator = mediator;

        [HttpPost("[controller]")]
        public async Task<ActionResult<SubmissionResult>> Post(CreateSubmissionCommand command)
        {
            var result = await mediator.Send(command);

            return Ok(result);
        }
    }
}
