using expensejar.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace expensejar.Categories.Dtos
{
    public class SubCategoryDto
    {
        [StringLength(EntityStringLengths.NameLength)]
        public string Name { get; set; }

        [StringLength(EntityStringLengths.DescriptionLength)]
        public string Description { get; set; }

        public bool IsDefault { get; set; }

        public int CategoryId { get; set; }
    }
}
