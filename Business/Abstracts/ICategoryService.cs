using Business.Dtos.Requests;
using Business.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        CreatedCategoryResponse Add(CreateCategoryRequest createCategoryRequest);
        UpdatedCategoryResponse Update(UpdateCategoryRequest updateCategoryRequest);
        List<GetAllCategoryResponse> GetAll();
    }
}
