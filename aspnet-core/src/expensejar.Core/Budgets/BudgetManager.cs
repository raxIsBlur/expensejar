using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace expensejar.Budgets
{
    class BudgetManager : IBudgetManager
    {
        public Task CreateBudgetAsync(Budget budget)
        {
            throw new NotImplementedException();
        }

        public Task CreateBudgetItemAsync(BudgetItem budgetItem)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBudgetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBudgetItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BudgetItem> GetAllBudgetItemsAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<Budget> GetBudgetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BudgetItem> GetBudgetItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBudgetAsync(Budget budget)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBudgetItemAsync(BudgetItem budgetItem)
        {
            throw new NotImplementedException();
        }
    }
}
