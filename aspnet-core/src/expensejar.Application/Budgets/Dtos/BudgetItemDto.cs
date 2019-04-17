using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using expensejar.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace expensejar.Budgets.Dtos
{
    [AutoMapFrom(typeof(BudgetItem))]
    [AutoMapTo(typeof(BudgetItem))]
    public class BudgetItemDto : EntityDto
    {
        public int BudgetId { get; set; }

        public int CategoryId { get; set; }

        public int? SubCategoryId { get; set; }

        public double? Amount { get; set; }

        [StringLength(EntityStringLengths.RemarksLength)]
        public string Remarks { get; set; }

        public int? AlertThreshold { get; set; }
    }
}
