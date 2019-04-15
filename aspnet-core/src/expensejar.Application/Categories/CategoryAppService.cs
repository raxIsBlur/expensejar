using System;
using System.Collections.Generic;
using System.Text;

namespace expensejar.Categories
{
    public class CategoryAppService : expensejarAppServiceBase, ICategoryAppService
    {
        private readonly ICategoryManager _categoryManager;

        public CategoryAppService(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }
    }
}
