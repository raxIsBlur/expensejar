using Abp.Application.Services;
using Abp.Application.Services.Dto;
using expensejar.Categories.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace expensejar.Categories
{
    public interface ICategoryAppService : IApplicationService
    {
        Task<CategoryDto> GetCategoryDetailAsync(EntityDto input);

        Task<ICollection<CategoryDto>> GetAllCategories(GetCategoryInputDto input);

        Task<SubCategoryDto> GetSubCategoryDetailAsync(EntityDto input);

        Task<ICollection<SubCategoryDto>> GetAllSubCategories(GetSubCategoryInputDto input);

        Task CreateOrUpdateCategoryAsync(CategoryDto input);

        Task CreateOrUpdateSubCategoryAsync(SubCategoryDto input);

        Task DeleteCategoryAsync(EntityDto input);

        Task DeleteSubCategoryAsync(EntityDto input);
    }
}
