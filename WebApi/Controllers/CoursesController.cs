using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpPost]
        public IActionResult Add(CreateCourseRequest createCourseRequest)
        {
            CreatedCourseResponse createdCourseResponse = _courseService.Add(createCourseRequest);
            return Ok(createdCourseResponse);
        }

        [HttpGet]
        public IActionResult GetAllCourse()
        {
            return Ok(_courseService.GetAll());
        }

        [HttpPut("updateCourseRequest")]
        public IActionResult Update(UpdateCourseRequest updateCourseRequest)
        {
            UpdatedCourseResponse updatedCourseResponse = _courseService.Update(updateCourseRequest);
            return Ok(updatedCourseResponse);
        }
    }
}
