using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace expensejar.Categories
{
    public class CategoryManager : ICategoryManager
    {
        private readonly IRepository<Category, int> _categoryRepository;
        private readonly IRepository<SubCategory, int> _subCategoryRepository;
        private readonly IAbpSession _abpSession;

        public CategoryManager(
            IRepository<Category, int> categoryRepository,
            IRepository<SubCategory, int> subCategoryRepository,
            IAbpSession abpSession)
        {
            _categoryRepository = categoryRepository;
            _subCategoryRepository = subCategoryRepository;
            _abpSession = abpSession;
        }

        public async Task CreateOrUpdateCategoryAsync(Category category)
        {
            await _categoryRepository.InsertOrUpdateAsync(category);
        }

        public async Task CreateOrUpdateSubCategoryAsync(SubCategory subCategory)
        {
            await _subCategoryRepository.InsertOrUpdateAsync(subCategory);
        }

        public async Task DeleteCategoryAsync(int id)
        {
            await _categoryRepository.DeleteAsync(id);
        }

        public async Task DeleteSubCategoryAsync(int id)
        {
            await _subCategoryRepository.DeleteAsync(id);
        }

        public async Task<ICollection<Category>> GetAllCategoryAsync()
        {
            return await _categoryRepository.GetAllListAsync();
        }

        public async Task<ICollection<SubCategory>> GetAllSubCategoryAsync(int? id)
        {
            return await _subCategoryRepository.GetAllListAsync();
        }

        public async Task<Category> GetCategoryAsync(int id)
        {
            return await _categoryRepository.GetAsync(id);
        }

        public async Task<SubCategory> GetSubCategoryAsync(int id)
        {
            return await _subCategoryRepository.GetAsync(id);
        }
    }
}
