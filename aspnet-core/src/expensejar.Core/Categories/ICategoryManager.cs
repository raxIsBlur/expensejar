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

        Task<ICollection<Category>> GetAllCategoryAsync();

        Task<SubCategory> GetSubCategoryAsync(int id);

        Task<ICollection<SubCategory>> GetAllSubCategoryAsync(int? id);

        Task CreateOrUpdateCategoryAsync(Category category);

        Task CreateOrUpdateSubCategoryAsync(SubCategory subCategory);

        Task DeleteCategoryAsync(int id);

        Task DeleteSubCategoryAsync(int id);
    }
}
