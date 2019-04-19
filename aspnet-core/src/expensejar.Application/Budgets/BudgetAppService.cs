using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using expensejar.Budgets.Dtos;

namespace expensejar.Budgets
{
    public class BudgetAppService : expensejarAppServiceBase, IBudgetAppService
    {
        private readonly IBudgetManager _budgetManager;

        public BudgetAppService(IBudgetManager budgetManager)
        {
            _budgetManager = budgetManager;
        }

        public async Task CreateOrUpdateBudgetAsync(BudgetDto input)
        {
            await _budgetManager.CreateOrUpdateBudgetAsync(input.MapTo<Budget>());
        }

        public async Task CreateOrUpdateBudgetItemAsync(BudgetItemDto input)
        {
            await _budgetManager.CreateOrUpdateBudgetItemAsync(input.MapTo<BudgetItem>());
        }

        public async Task DeleteBudgetAsync(EntityDto input)
        {
            await _budgetManager.DeleteBudgetAsync(input.Id);
        }

        public async Task DeleteBudgetItemAsync(EntityDto input)
        {
            await _budgetManager.DeleteBudgetAsync(input.Id);
        }

        public async Task<ICollection<BudgetItemDto>> GetAllBudgetItems(GetBudgetItemInputDto input)
        {
             return (await _budgetManager.GetAllBudgetItemsAsync(input.BudgetId)).MapTo<List<BudgetItemDto>>();
        }

        public async Task<ICollection<BudgetDto>> GetAllBudgets(GetBudgetInputDto input)
        {
            return (await _budgetManager.GetAllBudgetsAsync()).MapTo<List<BudgetDto>>();
        }

        public async Task<BudgetDto> GetBudgetDetailAsync(EntityDto input)
        {
            return (await _budgetManager.GetBudgetAsync(input.Id)).MapTo<BudgetDto>();
        }

        public async Task<BudgetItemDto> GetBudgetItemDetailAsync(EntityDto input)
        {
            return (await _budgetManager.GetBudgetItemAsync(input.Id)).MapTo<BudgetItemDto>();
        }
    }
}
