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

        Task<BudgetItem> GetBudgetItemAsync(int id);

        Task<BudgetItem> GetAllBudgetItemsAsync(int? id);

        Task CreateBudgetAsync(Budget budget);

        Task CreateBudgetItemAsync(BudgetItem budgetItem);

        Task UpdateBudgetAsync(Budget budget);

        Task UpdateBudgetItemAsync(BudgetItem budgetItem);

        Task DeleteBudgetAsync(int id);

        Task DeleteBudgetItemAsync(int id);
    }
}
