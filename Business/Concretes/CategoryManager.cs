using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public CreatedCategoryResponse Add(CreateCategoryRequest createCategoryRequest)
        {
            Category category = new Category();
            category.CategoryName = createCategoryRequest.CategoryName;
            category.CreatedDate = DateTime.Now;

            _categoryDal.Add(category);

            CreatedCategoryResponse createdCategoryResponse = new CreatedCategoryResponse();
            createdCategoryResponse.CategoryName = category.CategoryName;
            createdCategoryResponse.Id = 2;
            createdCategoryResponse.CreatedDate = category.CreatedDate;

            return createdCategoryResponse;
        }

        public List<GetAllCategoryResponse> GetAll()
        {
            List<Category> categories = _categoryDal.GetAll();
            List<GetAllCategoryResponse> getAllCategoryResponses = new List<GetAllCategoryResponse>();



            foreach (var category in categories)
            {
                GetAllCategoryResponse getAllCategoryResponse = new GetAllCategoryResponse();
                getAllCategoryResponse.CategoryName = category.CategoryName;
                getAllCategoryResponse.CreatedDate = category.CreatedDate;
                getAllCategoryResponse.Id = category.Id;

                getAllCategoryResponses.Add(getAllCategoryResponse);
            }


            return getAllCategoryResponses;
        }

        public UpdatedCategoryResponse Update(UpdateCategoryRequest updateCategoryRequest)
        {
            Category category = new Category();
            category.CategoryName = updateCategoryRequest.CategoryName;
            category.Id = updateCategoryRequest.Id;
            category.CreatedDate = DateTime.Now;

            _categoryDal.Update(category);

            UpdatedCategoryResponse updatedCategoryResponse = new UpdatedCategoryResponse();
            updatedCategoryResponse.CategoryName = category.CategoryName;
            updatedCategoryResponse.Id = category.Id;
            updatedCategoryResponse.UpdatedDate = DateTime.Now;

            return updatedCategoryResponse;
        }
    }
}
