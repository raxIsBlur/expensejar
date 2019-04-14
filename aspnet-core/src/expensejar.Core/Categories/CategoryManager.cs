using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace expensejar.Categories
{
    class CategoryManager : ICategoryManager
    {
        public Task CreateCategoryAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task CreateSubCategoryAsync(SubCategory subCategory)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSubCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetAllCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetAllSubCategoryAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SubCategory> GetSubCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(SubCategory subCategory)
        {
            throw new NotImplementedException();
        }
    }
}
