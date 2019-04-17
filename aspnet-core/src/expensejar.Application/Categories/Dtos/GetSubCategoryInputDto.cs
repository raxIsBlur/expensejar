using System;
using System.Collections.Generic;
using System.Text;

namespace expensejar.Categories.Dtos
{
    public class GetSubCategoryInputDto
    {
        public string Name { get; set; }

        public int? CategoryId { get; set; }
    }
}
