using System;
using System.Collections.Generic;
using System.Text;

namespace expensejar.Budgets
{
    public class BudgetAppService : expensejarAppServiceBase, IBudgetAppService
    {
        private readonly IBudgetManager _budgetManager;

        public BudgetAppService(IBudgetManager budgetManager)
        {
            _budgetManager = budgetManager;
        }
    }
}
