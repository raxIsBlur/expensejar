using Abp.Domain.Entities.Auditing;
using expensejar.Categories;
using expensejar.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace expensejar.Budgets
{
    public class BudgetItem : AuditedEntity
    {
        public int BudgetId { get; set; }

        [ForeignKey(nameof(BudgetId))]
        public Budget Budget { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }

        public int? SubCategoryId { get; set; }

        [ForeignKey(nameof(SubCategoryId))]
        public SubCategory SubCategory { get; set; }

        // this would be the budgeted amount
        public double? Amount { get; set; }

        //public double ActualAmount { get; set; }

        [StringLength(EntityStringLengths.RemarksLength)]
        public string Remarks { get; set; }

        public int? AlertThreshold { get; set; }
    }
}
