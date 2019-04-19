using Abp.Application.Services;
using Abp.Application.Services.Dto;
using expensejar.Budgets.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace expensejar.Budgets
{
    public interface IBudgetAppService : IApplicationService
    {
        Task<BudgetDto> GetBudgetDetailAsync(EntityDto input);

        Task<ICollection<BudgetDto>> GetAllBudgets(GetBudgetInputDto input);

        Task<BudgetItemDto> GetBudgetItemDetailAsync(EntityDto input);

        Task<ICollection<BudgetItemDto>> GetAllBudgetItems(GetBudgetItemInputDto input);

        Task CreateOrUpdateBudgetAsync(BudgetDto input);

        Task CreateOrUpdateBudgetItemAsync(BudgetItemDto input);

        Task DeleteBudgetAsync(EntityDto input);

        Task DeleteBudgetItemAsync(EntityDto input);
    }
}
