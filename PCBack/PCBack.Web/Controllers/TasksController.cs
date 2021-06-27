using Microsoft.AspNetCore.Mvc;
using PCBack.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCBack.Web.Controllers
{
    [ApiController]
    public class TasksController : ControllerBase
    {
        [HttpGet("[controller]/{id}")]
        public ActionResult<CompetitionTask> Get(string id)
        {
            var task = new CompetitionTask
            {
                Id = "id",
                Description = "description",
                Name = "name"
            };

            return Ok(task);
        }
    }
}
