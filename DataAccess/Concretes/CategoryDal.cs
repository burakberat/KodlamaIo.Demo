using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public CategoryDal()
        {
            _categories = new List<Category>();
            _categories.Add(new Category { Id = 1, CategoryName = "Programlama", CreatedDate = DateTime.Now });
        }

        public void Add(Category entity)
        {
            _categories.Add(entity);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category entity)
        {
            Category categoryToUpdate = _categories.FirstOrDefault(c => c.Id == entity.Id);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.CategoryName = entity.CategoryName;
                categoryToUpdate.Id = entity.Id;
                categoryToUpdate.UpdatedDate = DateTime.Now;
            }
        }
    }
}
