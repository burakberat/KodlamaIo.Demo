using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public IActionResult Add(CreateCategoryRequest createCategoryRequest)
        {
            CreatedCategoryResponse createdCategoryResponse = _categoryService.Add(createCategoryRequest);
            return Ok(createCategoryRequest);
        }

        [HttpGet]
        public IActionResult GetAllCategory()
        {
            return Ok(_categoryService.GetAll());
        }

        [HttpPut("updateCategoryRequest")]
        public IActionResult Update(UpdateCategoryRequest updateCategoryRequest)
        {
            UpdatedCategoryResponse updatedCategoryResponse = _categoryService.Update(updateCategoryRequest);
            return Ok(updateCategoryRequest);
        }
    }
}
