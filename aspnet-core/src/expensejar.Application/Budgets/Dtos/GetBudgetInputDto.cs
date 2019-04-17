using System;
using System.Collections.Generic;
using System.Text;

namespace expensejar.Budgets.Dtos
{
    public class GetBudgetInputDto
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
