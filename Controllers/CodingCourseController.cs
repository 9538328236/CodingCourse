using CodingTestAPI.Interfaces;
using CodingTestAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace CodingTestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CodingCourseController : ControllerBase
    {
        private readonly ICodingTestService _codingCourseService;

        public CodingCourseController(ICodingTestService codingCourseService)
        {
            _codingCourseService = codingCourseService;
        }

        [HttpPost]
        [Route("get-response")]
        public async Task<IActionResult> Post([FromBody] string[] inputs)
        {
            var res = await _codingCourseService.DisplayResult(inputs);
            return Ok(res);
        }
       
    }
}