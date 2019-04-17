using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using expensejar.Categories.Dtos;

namespace expensejar.Categories
{
    public class CategoryAppService : expensejarAppServiceBase, ICategoryAppService
    {
        private readonly ICategoryManager _categoryManager;

        public CategoryAppService(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public async Task CreateOrUpdateCategoryAsync(CategoryDto input)
        {
            await _categoryManager.CreateOrUpdateCategoryAsync(input.MapTo<Category>());
        }

        public async Task CreateOrUpdateSubCategoryAsync(SubCategoryDto input)
        {
            await _categoryManager.CreateOrUpdateSubCategoryAsync(input.MapTo<SubCategory>());

        }

        public async Task DeleteCategoryAsync(EntityDto input)
        {
            await _categoryManager.DeleteCategoryAsync(input.Id);
        }

        public async Task DeleteSubCategoryAsync(EntityDto input)
        {
            await _categoryManager.DeleteSubCategoryAsync(input.Id);
        }

        public async Task<ICollection<CategoryDto>> GetAllCategories(GetCategoryInputDto input)
        {
            return (await _categoryManager.GetAllCategoryAsync()).MapTo<List<CategoryDto>>();
        }

        public async Task<ICollection<SubCategoryDto>> GetAllSubCategories(GetSubCategoryInputDto input)
        {
            return (await _categoryManager.GetAllSubCategoryAsync(input.CategoryId)).MapTo<List<SubCategoryDto>>();
        }

        public async Task<CategoryDto> GetCategoryDetailAsync(EntityDto input)
        {
            return (await _categoryManager.GetCategoryAsync(input.Id)).MapTo<CategoryDto>();
        }

        public async Task<SubCategoryDto> GetSubCategoryDetailAsync(EntityDto input)
        {
            return (await _categoryManager.GetSubCategoryAsync(input.Id)).MapTo<SubCategoryDto>();
        }
    }
}
