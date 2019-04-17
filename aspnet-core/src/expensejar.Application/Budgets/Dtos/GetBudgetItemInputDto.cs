using System;
using System.Collections.Generic;
using System.Text;

namespace expensejar.Budgets.Dtos
{
    public class GetBudgetItemInputDto
    {
        public int BudgetId { get; set; }

        public int CategoryId { get; set; }

        public int? SubCategoryId { get; set; }

        public int? AlertThreshold { get; set; }
    }
}
