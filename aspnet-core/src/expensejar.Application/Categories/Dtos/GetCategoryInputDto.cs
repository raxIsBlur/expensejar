using System;
using System.Collections.Generic;
using System.Text;

namespace expensejar.Categories.Dtos
{
    public class GetCategoryInputDto
    {
        public string Name { get; set; }

        public TransactionType? Type { get; set; }

        public int? CategoryId { get; set; }
    }
}
