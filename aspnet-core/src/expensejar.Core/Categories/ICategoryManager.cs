using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace expensejar.Categories
{
    public interface ICategoryManager : IDomainService
    {
        Task<Category> GetCategoryAsync(int id);

        Task<Category> GetAllCategoryAsync();

        Task<SubCategory> GetSubCategoryAsync(int id);

        Task<Category> GetAllSubCategoryAsync(int? id);

        Task CreateCategoryAsync(Category category);

        Task CreateSubCategoryAsync(SubCategory subCategory);

        Task UpdateAsync(Category category);

        Task UpdateAsync(SubCategory subCategory);

        Task DeleteCategoryAsync(int id);

        Task DeleteSubCategoryAsync(int id);
    }
}
