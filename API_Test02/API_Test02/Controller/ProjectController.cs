using System;
using System.Threading.Tasks;
using CoreAPI.Model;
using DataStore.EF;
using Microsoft.AspNetCore.Mvc;

namespace API_Test02.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : ControllerBase
    {
        private readonly BugeContext context;

        public ProjectController(BugeContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Project is Get Result");
        }
        [HttpPost]
        public async Task<IActionResult> PostP([FromBody] Project project)
        {
            this.context.Projects.Add(project);
            await this.context.SaveChangesAsync();
            return Ok(project);
        }
    }
}
