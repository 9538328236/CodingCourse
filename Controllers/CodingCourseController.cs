using CodingTestAPI.Interfaces;
using CodingTestAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace CodingTestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CodingCourseController : ControllerBase
    {
        private readonly ICodingCourseService _codingCourseService;

        public CodingCourseController(ICodingCourseService codingCourseService)
        {
            _codingCourseService = codingCourseService;
        }

        [HttpGet(Name = "GetCodingCourseList")]
        public async Task<IActionResult> Get()
        {
            var res = await _codingCourseService.GetAllCodingCourseAsync();
            return Ok(res);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var codingCourseDetails =  await _codingCourseService.GetAllCodingCourseByIdAsync(id);
            if (codingCourseDetails == null)
            {
                return NotFound();
            }
            else { return Ok(codingCourseDetails); }
        }

        [HttpPost]
        [Route("save-coding-course")]
        public async Task<IActionResult> Post([FromBody] CodingCourse codingCourse)
        {
            var id = await _codingCourseService.AddAsync(codingCourse);
            if (id <= 0)
            {
                return NotFound();
            }
            else { return Ok(id); }
        }
    }
}