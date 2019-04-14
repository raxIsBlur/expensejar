using Abp.Domain.Entities.Auditing;
using expensejar.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace expensejar.Budgets
{
    public class Budget : AuditedEntity
    {
        [StringLength(EntityStringLengths.NameLength)]
        public string Name { get; set; }

        [StringLength(EntityStringLengths.DescriptionLength)]
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [InverseProperty(nameof(Budget))]
        public ICollection<BudgetItem> BudgetItems { get; set; }
    }
}
