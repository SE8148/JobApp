using JobAppWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobAppWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetJobs()
        {
            List<Job> _jobs = new List<Job>
            {
                new Job()
                {
                    Id = 1,
                    JobTitle = "Fix bathroom door",
                    JobDescription = "Replace door hinges and handles",
                    Completed = false
                }
            };

            return Ok(_jobs);
        }
    }
}
