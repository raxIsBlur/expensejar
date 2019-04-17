using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace expensejar.Budgets
{
    public interface IBudgetManager : IDomainService
    {
        Task<Budget> GetBudgetAsync(int id);

        Task<ICollection<Budget>> GetAllBudgetsAsync();

        Task<BudgetItem> GetBudgetItemAsync(int id);

        Task<ICollection<BudgetItem>> GetAllBudgetItemsAsync(int? id);

        Task CreateOrUpdateBudgetAsync(Budget budget);

        Task CreateOrUpdateBudgetItemAsync(BudgetItem budgetItem);

        Task DeleteBudgetAsync(int id);

        Task DeleteBudgetItemAsync(int id);
    }
}
