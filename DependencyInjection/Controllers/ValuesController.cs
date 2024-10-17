using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DependencyInjection.Services;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ITeacher _teacher;

        public ValuesController(ITeacher teacher)
        {
            _teacher = teacher;
        }

        [HttpGet]
        public IActionResult Get()
        {
            string teacherInfo = _teacher.GetInfo();
            return Ok(teacherInfo);
        }
    }
}
