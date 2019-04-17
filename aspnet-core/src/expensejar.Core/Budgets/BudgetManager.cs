using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expensejar.Budgets
{
    public class BudgetManager : IBudgetManager
    {
        private readonly IRepository<Budget, int> _budgetRepository;
        private readonly IRepository<BudgetItem, int> _budgetItemRepository;
        private readonly IAbpSession _abpSession;

        public BudgetManager(IRepository<Budget, int> budgetRepository, IRepository<BudgetItem, int> budgetItemRepository, IAbpSession abpSession)
        {
            _budgetRepository = budgetRepository;
            _budgetItemRepository = budgetItemRepository;
            _abpSession = abpSession;
        }

        public async Task CreateOrUpdateBudgetAsync(Budget budget)
        {
            await _budgetRepository.InsertOrUpdateAsync(budget);
        }

        public async Task CreateOrUpdateBudgetItemAsync(BudgetItem budgetItem)
        {
            await _budgetItemRepository.InsertOrUpdateAsync(budgetItem);
        }

        public async Task DeleteBudgetAsync(int id)
        {
            await _budgetRepository.DeleteAsync(id);
        }

        public async Task DeleteBudgetItemAsync(int id)
        {
            await _budgetItemRepository.DeleteAsync(id);
        }

        public async Task<ICollection<Budget>> GetAllBudgetsAsync()
        {
            return await _budgetRepository.GetAll().Where(x => x.CreatorUserId == _abpSession.UserId).ToListAsync();
        }

        public async Task<ICollection<BudgetItem>> GetAllBudgetItemsAsync(int? id)
        {
            return await _budgetItemRepository.GetAll().Where(x => x.CreatorUserId == _abpSession.UserId).ToListAsync();
        }

        public async Task<Budget> GetBudgetAsync(int id)
        {
            return await _budgetRepository.GetAsync(id);
        }

        public async Task<BudgetItem> GetBudgetItemAsync(int id)
        {
            return await _budgetItemRepository.GetAsync(id);
        }
    }
}
