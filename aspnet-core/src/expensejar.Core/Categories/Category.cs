using Abp.Domain.Entities.Auditing;
using expensejar.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace expensejar.Categories
{
    public class Category : AuditedEntity
    {
        [StringLength(EntityStringLengths.NameLength)]
        public string Name { get; set; }

        [StringLength(EntityStringLengths.DescriptionLength)]
        public string Description { get; set; }

        public TransactionType Type { get; set; }

        public bool IsDefault { get; set; }

        public int CategoryId { get; set; }

        [InverseProperty(nameof(Category))]
        public ICollection<SubCategory> SubCategories { get; set; }

    }
}
