using Microsoft.AspNetCore.Mvc;
using System.Net;
using WebApiLibrary.Models.ApiRequestDto;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    public class ApplicationController : Controller
    {
        private readonly ILogger<ApplicationController> logger;
        public ApplicationController(ILogger<ApplicationController> logger)
        {
            this.logger = logger;
        }


        [HttpPost, Route("AddProgramDetails")]
        public async Task<IActionResult> AddProgramDetails([FromBody] ProgramDetailsModel model)
        {

        }
    }
}
